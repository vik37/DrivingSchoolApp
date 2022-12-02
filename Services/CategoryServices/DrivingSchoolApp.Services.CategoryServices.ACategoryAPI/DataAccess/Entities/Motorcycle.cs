using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities
{
	public class Motorcycle : Base
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public int Fuel { get; set; }
		public int Capacity { get; set; }
		public int Weight { get; set; }
		public int Speed { get; set; }
		public string Color { get; set; }
		public string Photo { get; set; }
		public int AvailableMotorcycles { get; set; }
		public IEnumerable<MororsPerCity> MotorsPerCity { get; set; } = new List<MororsPerCity>();
	}
}
