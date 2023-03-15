using Duende.IdentityServer.Models;
using IdentityServerHost.Quickstart.UI;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DrivingSchoolApp.RegisterMVC.Main_Module.Account
{
    public class ForgottenPasswordViewModel
    {
        [Required]
        [DisplayName("E-mail")]
        [StringLength(255, ErrorMessage = "{0} length must be between {2} and {1}", MinimumLength = 6)]
        [EmailAddress(ErrorMessage = "Invalid {0}")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid {0}")]
        public string Email { get; set; }

        public QuestionAnswerViewModel QAUserProtection { get; set; }

        public string ReturnUrl { get; set; }
    }
}
