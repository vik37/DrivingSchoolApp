using DrivingSchoolApp.RegisterMVC.DataAccess.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.Entities
{
	public class QuestionAnswerUserProtection
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public string Id { get; set; }
		public Question Question { get; set; }
		public string Answer { get; set; }
		public virtual ApplicationUser ApplicationUser { get; set; }
	}
}
