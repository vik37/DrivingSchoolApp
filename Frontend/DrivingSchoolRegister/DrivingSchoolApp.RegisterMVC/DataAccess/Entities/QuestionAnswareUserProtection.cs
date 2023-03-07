using DrivingSchoolApp.RegisterMVC.DataAccess.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.Entities
{
	public class QuestionAnswareUserProtection
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public string Id { get; set; }
		public Question Question { get; set; }
		public string Answare { get; set; }
		public virtual ApplicationUser ApplicationUser { get; set; }
	}
}
