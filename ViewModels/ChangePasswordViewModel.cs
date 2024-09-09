using System.ComponentModel.DataAnnotations;

namespace Mobin.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at min {2} and at max {1} characters ")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match")]

        public String NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public String ConfirmNewPassword { get; set; }
    }
}
