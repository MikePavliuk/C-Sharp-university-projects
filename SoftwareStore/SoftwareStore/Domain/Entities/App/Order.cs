using System;
using SoftwareStore.Domain.Entities.Users;

namespace SoftwareStore.Domain.Entities.App
{
    public class Order : EntityBase
    {
        public AppUser AppUser { get; set; }
        public Guid AppUserId { get; set; }

        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
