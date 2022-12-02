using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities
{
    public class Base
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
	}
}
