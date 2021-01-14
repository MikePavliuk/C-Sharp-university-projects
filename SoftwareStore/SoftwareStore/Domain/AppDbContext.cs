using System;
using System.Linq;
using SoftwareStore.Domain.Entities.App;
using SoftwareStore.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftwareStore.Domain.Seed;
using SoftwareStore.Infrastructure;

namespace SoftwareStore.Domain
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.UseCollation("Cyrillic_General_CI_AS");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            Guid roleAdminId = new Guid("80725dc8-353e-4b5f-9277-31739833ce2a");
            Guid roleUserId = new Guid("f6a6898d-9bd3-4b44-9cba-d3b13aeb3258");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleAdminId,
                Name = ConstantsWeb.Database.AdminRoleName,
                NormalizedName = ConstantsWeb.Database.AdminRoleName
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = roleUserId,
                UserName = "admin@admin.com",
                NormalizedUserName = "admin@admin.com",
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin12345"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleAdminId,
                UserId = roleUserId
            });

            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
        }
    }
}
