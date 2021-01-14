using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using SoftwareStore.Domain;
using SoftwareStore.Domain.Entities.Users;
using SoftwareStore.Domain.Repositories.Abstract;
using SoftwareStore.Domain.Repositories.EntityFramework;
using SoftwareStore.Infrastructure;
using SoftwareStore.Infrastructure.Config;

namespace SoftwareStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //di
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IUrlHelper>(x =>
            {
                var actionContext = x.GetRequiredService<IActionContextAccessor>().ActionContext;
                var factory = x.GetRequiredService<IUrlHelperFactory>();
                return factory.GetUrlHelper(actionContext);
            });
            services.AddTransient<DataManager>();
            services.AddTransient<ServiceEmail>();
            services.AddHttpContextAccessor();
            services.AddTransient<IUsersRepository, EFUsersRepository>();
            services.AddTransient<ICatalogRepository, EFCatalogRepository>();

            //project appsettings config
            var config = new ProjectConfiguration();
            Configuration.Bind("Project", config);
            services.AddSingleton(config);

            //routing
            services.AddRouting(option =>
            {
                option.LowercaseUrls = true;
            });

            //session
            services.AddSession(x =>
                {
                    x.IdleTimeout = TimeSpan.FromMinutes(20);
                    x.Cookie.Name = "soft";
                    x.Cookie.HttpOnly = true;
                    x.Cookie.IsEssential = false;
                });

            //database
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.Database.ConnectionString));

            //identity
            services.AddIdentity<AppUser, AppRole>(opts =>
            {
                //password settings
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = true;
                opts.Password.RequireDigit = false;

                //lockout settings
                opts.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                opts.Lockout.MaxFailedAccessAttempts = 5;
                opts.Lockout.AllowedForNewUsers = true;

                //user settings
                opts.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                opts.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //identity cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "softAuth";
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
            });

            //html engine cyrillic rendering
            services.AddSingleton<HtmlEncoder>(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

            //add mvc
            services.AddControllersWithViews(options =>
                {
                    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()); //global check for XSRF/CSRF
                })
                .SetCompatibilityVersion(CompatibilityVersion.Latest).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            //static files
            var fileOptions = new StaticFileOptions
            {
                OnPrepareResponse = (context) => context.Context.Response.Headers[HeaderNames.CacheControl] = "public, max-age=604800"
            };
            app.UseStaticFiles(fileOptions);
            app.UseCookiePolicy();

            //culture
            var ci = new CultureInfo("en-US");
            ci.NumberFormat.NumberDecimalSeparator = ".";
            ci.NumberFormat.NumberGroupSeparator = " ";
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo> { ci },
                SupportedUICultures = new List<CultureInfo> { ci }
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
