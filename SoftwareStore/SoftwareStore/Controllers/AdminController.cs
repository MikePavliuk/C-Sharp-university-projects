using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SoftwareStore.Domain;
using SoftwareStore.Domain.Entities.App;
using SoftwareStore.Domain.Entities.Users;
using SoftwareStore.Models;

namespace SoftwareStore.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public AdminController(
            DataManager dataManager,
            IWebHostEnvironment hostingEnvironment,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> Index(string productid, string datefrom, string dateto)
        {
            AdminViewModel model = new AdminViewModel();
            model.Products = await dataManager.Catalog.GetProducts().ToListAsync();
            model.Users = await dataManager.Users.GetAppUsers().ToListAsync();
            model.Orders = await dataManager.Catalog.GetOrders().ToListAsync();
            model.OrdersFiltered = await dataManager.Catalog.GetOrdersFiltered(productid, datefrom, dateto).ToListAsync();

            ViewBag.ProductId = productid;
            ViewBag.DateFrom = datefrom;
            ViewBag.DateTo = dateto;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AppUsersDelete(Guid id)
        {
            await dataManager.Users.DeleteUserAsync(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> OrdersDelete(Guid orderId)
        {
            await dataManager.Catalog.DeleteOrderAsync(orderId);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ProductsEdit(Guid id)
        {
            Product model = id == default ? new Product() : await dataManager.Catalog.GetProductByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProductsEdit(Product model)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Catalog.SaveProductAsync(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProductsDelete(Guid id)
        {
            await dataManager.Catalog.DeleteProductAsync(id);
            return RedirectToAction("Index");
        }
    }
}
