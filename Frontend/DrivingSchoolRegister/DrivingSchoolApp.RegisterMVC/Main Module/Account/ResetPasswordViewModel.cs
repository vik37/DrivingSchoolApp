using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DrivingSchoolApp.RegisterMVC.Main_Module.Account
{
    public class ResetPasswordViewModel
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string ReturnUrl { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(8, ErrorMessage = "{0} Minimum length is {1}")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
                ErrorMessage = "{0} at least one uppercase letter, one lowercase letter, one number and one special character")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "You must confirm the password")]
        [MinLength(8, ErrorMessage = "{0} Minimum length is {1}")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must be same")]
        public string ConfirmPassword { get; set; }
    }
}
