using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTemplate.App.Models
{
    public class UserViewModel
    {

        [Required(ErrorMessage = "UserName is required")]
        [Display(Name = "UserName:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password:")]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password", ErrorMessage = "Both passwords must match. Try again.")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Display(Name = "Confirm Password:")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

    }
}
