namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;

public class CategoryD : Base
{
	public string City { get; set; }
	public string Address { get; set; }
	public string Phone { get; set; }
	public string BusPhoto { get; set; }
	public IEnumerable<CategoryLesson> Lessons { get; set; } = new List<CategoryLesson>();
	public IEnumerable<Instructor> Instructors { get; set; } = new List<Instructor>();
}