﻿using System.ComponentModel.DataAnnotations;

namespace Mobin.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Name is required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public String Email { get; set; }
        
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at min {2} and at max {1} characters ")]
        [Compare("ConfirmPassword",ErrorMessage ="Password does not match")]

        public String Password{ get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public String ConfirmPassword { get; set; }
    }
}
