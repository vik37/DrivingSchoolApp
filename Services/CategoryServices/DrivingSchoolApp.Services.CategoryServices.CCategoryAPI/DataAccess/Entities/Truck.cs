namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities
{
    public class Truck : Base
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
		public IEnumerable<TruckPerCity> TruckPerCities { get; set; } = new List<TruckPerCity>();
	}
}
