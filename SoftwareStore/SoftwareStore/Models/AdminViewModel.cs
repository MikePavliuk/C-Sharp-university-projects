using System.Collections.Generic;
using SoftwareStore.Domain.Entities.App;
using SoftwareStore.Domain.Entities.Users;

namespace SoftwareStore.Models
{
    public class AdminViewModel
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<AppUser> Users { get; set; }
        public List<Order> OrdersFiltered { get; set; }
    }
}
