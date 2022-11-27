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
		public TypeOfClass TypeOfClass { get; set; }
		public double Price { get; set; }
		public string Photo { get; set; }
		public string Description { get; set; }
		public IEnumerable<Instructor> Instructors { get; set; } = new List<Instructor>();
		public IEnumerable<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();
	}
}
