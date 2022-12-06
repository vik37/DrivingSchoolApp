namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities
{
	public class CategoryC : Base
	{
		public string City { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public IEnumerable<CategoryLesson> Lessons { get; set; } = new List<CategoryLesson>();
		public IEnumerable<TruckPerCity> TruckPerCities { get; set; } = new List<TruckPerCity>();
		public IEnumerable<Instructor> Instructors { get; set; } = new List<Instructor>();
	}
}
