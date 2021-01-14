using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using SoftwareStore.Domain.Entities.App;

namespace SoftwareStore.Domain.Entities.Users
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            DateAdded = DateTime.UtcNow;
        }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Display Name")]
        [MaxLength(30)]
        public string DisplayName { get; set; }

        [Display(Name = "About me")]
        [MaxLength(5000)]
        public string About { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
