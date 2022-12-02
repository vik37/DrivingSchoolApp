namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models
{
	public class CarDto : BaseDto
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Fuel { get; set; }
		public double FuelConsuption { get; set; }
		public int Power { get; set; }
		public int Length { get; set; }
		public int Speed { get; set; }
		public int Doors { get; set; }
		public string Transmission { get; set; }
		public string Color { get; set; }
		public string Photo { get; set; }
		public int AvailableCars { get; set; }
	}
}
