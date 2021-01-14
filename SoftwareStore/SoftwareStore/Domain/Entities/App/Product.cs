using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Domain.Entities.App
{
    public class Product : EntityBase
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; } = "Unknown product";

        [Display(Name = "Description")]
        public string Information { get; set; } = "Please describe the new product...";

        [Display(Name = "List of supported OS")]
        public string OS { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
