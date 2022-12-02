
namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models
{
	public class CategoryBDto : BaseDto
	{
		public string City { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public IEnumerable<LessonDto> Lessons { get; set; } = new List<LessonDto>();
		public IEnumerable<InstructorDto> Instructors { get; set; } = new List<InstructorDto>();
		public IEnumerable<CarDto> Cars{ get; set; } = new List<CarDto>();
	}
}
