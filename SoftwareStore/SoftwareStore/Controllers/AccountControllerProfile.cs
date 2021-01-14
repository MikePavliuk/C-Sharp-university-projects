using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareStore.Domain.Entities.App;


namespace SoftwareStore.Controllers
{
    public partial class AccountController
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Orders()
        {
            var user = await userManager.GetUserAsync(User);

            List<Order> model = await dataManager.Catalog.GetOrdersByAppUserId(user.Id).ToListAsync();
            return View(model);
        }

        
    }
}