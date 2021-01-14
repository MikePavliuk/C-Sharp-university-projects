using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password one more time")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
