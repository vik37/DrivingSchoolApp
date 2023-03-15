using IdentityServerHost.Quickstart.UI;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DrivingSchoolApp.RegisterMVC.Main_Module.Account
{
    public class RegisterViewModel
    {
        //[Required]
        public string Username { get; set; }

        [Required]
        [DisplayName("E-mail")]
        [StringLength(255, ErrorMessage = "{0} length must be between {2} and {1}", MinimumLength = 6)]
        [EmailAddress(ErrorMessage = "Invalid {0}")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid {0}")]
        public string Email { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "{0} length must be between {2} and {1}", MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Please, use only letters")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "{0} length must be between {2} and {1}", MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Please, use only letters")]
        public string Lastname { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "01/01/1910", "01/01/2020", ErrorMessage = "Invalid Date")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "{0} length must be between {2} and {1}", MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Please, use only letters")]
        public string City { get; set; }

        [Required]
        [DisplayName("Post Code")]
        [Range(1, 32000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int PostCode { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "{0} length must be between {2} and {1}", MinimumLength = 5)]
        public string Address { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        [MinLength(5, ErrorMessage = "{0} Minimum length is {1}")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

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


        public string ReturnUrl { get; set; }
        public string RoleName { get; set; }

        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;

        public IEnumerable<ExternalProvider> ExternalProviders { get; set; } = Enumerable.Empty<ExternalProvider>();
        public IEnumerable<ExternalProvider> VisibleExternalProviders => ExternalProviders.Where(x => !String.IsNullOrWhiteSpace(x.DisplayName));

        public bool IsExternalLoginOnly => EnableLocalLogin == false && ExternalProviders?.Count() == 1;
        public string ExternalLoginScheme => IsExternalLoginOnly ? ExternalProviders?.SingleOrDefault()?.AuthenticationScheme : null;

        public QuestionAnswerViewModel QAUserProtection { get; set; }
    }
}
