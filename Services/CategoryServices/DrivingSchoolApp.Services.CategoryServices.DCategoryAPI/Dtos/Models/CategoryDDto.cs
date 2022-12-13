namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models; 

public class CategoryDDto : BaseDto 
{
	public string City { get; set; }
	public string Address { get; set; }
	public string Phone { get; set; }
	public string BusPhoto { get; set; }
	public IEnumerable<LessonDto> Lessons { get; set; } = new List<LessonDto>();
	public IEnumerable<InstructorDto> Instructors { get; set; } = new List<InstructorDto>();
}