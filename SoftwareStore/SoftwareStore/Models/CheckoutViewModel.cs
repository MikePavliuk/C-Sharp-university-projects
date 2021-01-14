using System;
using SoftwareStore.Domain.Entities.App;
using SoftwareStore.Domain.Entities.Users;

namespace SoftwareStore.Models
{
    public class CheckoutViewModel
    {
        public AppUser User { get; set; }
        public Guid OrderId { get; set; }
        public Product Product { get; set; }
    }
}
