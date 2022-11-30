
namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto.Models
{ 
	public class MotorcycleDto : BaseDto
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
	}
}
