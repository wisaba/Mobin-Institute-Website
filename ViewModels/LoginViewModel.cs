using System.ComponentModel.DataAnnotations;

namespace Mobin.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Display(Name = "Remeber me?")]
        public bool RememberMe { get; set; }

    }
}
