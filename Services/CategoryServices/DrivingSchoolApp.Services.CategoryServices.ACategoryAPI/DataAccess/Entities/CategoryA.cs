using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Enum;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities
{
	public class CategoryA : Base
	{		
		public string City { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }		
		public IEnumerable<CategoryLesson> CategoryLessons { get; set; } = new List<CategoryLesson>();
		public IEnumerable<Instructor> Instructors { get; set; } = new List<Instructor>();
		public IEnumerable<MororsPerCity> MotorcyclePerCity { get; set; } = new List<MororsPerCity>();
	}
}
