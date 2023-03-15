using Microsoft.AspNetCore.Identity;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.Entities
{
	public class ApplicationUser : IdentityUser
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string DateOfBirth { get; set; }
		public string City { get; set; }
		public int PostCode { get; set; }
		public string Address { get; set; }
		public string RegistrationDate { get; set; } = DateTime.Now.ToString("dd/mm/yyyy");
		public string QAId { get; set; }
		public virtual QuestionAnswerUserProtection QuestionAnswerUserProtection { get; set; }
	}
}
