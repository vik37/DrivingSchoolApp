using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities
{
	public class Motorcycle : Booked
	{
		public string Type { get; set; }
		public int Speed { get; set; }
		public string Color { get; set; }
		public int CategoryAId { get; set; }
		public CategoryA CategoryA { get; set; }
	}
}
