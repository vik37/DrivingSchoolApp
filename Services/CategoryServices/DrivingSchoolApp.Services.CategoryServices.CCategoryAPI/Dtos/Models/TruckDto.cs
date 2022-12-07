namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models
{
    public class TruckDto : BaseDto
    {
		public int TruckNumber { get; set; }
		public string Type { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Fuel { get; set; }
		public int Power { get; set; }
		public string Transmission { get; set; }
		public int CylinderCapacity { get; set; }
		public string Color { get; set; }
		public string Photo { get; set; }
		public int AvailableTruck { get; set; }
	}
}
