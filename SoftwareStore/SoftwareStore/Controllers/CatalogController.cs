using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using SoftwareStore.Domain;
using SoftwareStore.Domain.Entities.App;
using SoftwareStore.Domain.Entities.Users;
using SoftwareStore.Models;

namespace SoftwareStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public CatalogController(
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

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> DownloadDemo(Guid id)
        {
            try
            {
                var entity = await dataManager.Catalog.GetProductByIdAsync(id);
                var path = Path.GetFullPath(Path.Combine(hostingEnvironment.WebRootPath, "docs/", "doc.docx"));
                var stream = new FileStream(path, FileMode.Open);
                return File(stream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", $"{entity.Title}_Preview.docx");
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Download(Guid id)
        {
            try
            {
                var entity = await dataManager.Catalog.GetProductByIdAsync(id);
                var path = Path.GetFullPath(Path.Combine(hostingEnvironment.WebRootPath, "docs/", "doc.docx"));
                var stream = new FileStream(path, FileMode.Open);
                return File(stream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", $"{entity.Title}_Full.docx");
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> NewOrder(Guid productId)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("~/Views/Home/Message.cshtml", "Please log in before you can buy software.");
            }

            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);

                CheckoutViewModel model = new CheckoutViewModel();

                Order entity = new Order();
                entity.ProductId = productId;
                entity.AppUserId = user.Id;

                model.User = user;
                model.OrderId = await dataManager.Catalog.SaveOrderAsync(entity);
                model.Product = await dataManager.Catalog.GetProductByIdAsync(productId);
                return View(model);
            }

            return View("~/Views/Home/Message.cshtml", "Something went wrong, please try again.");
        }

        
    }
}
