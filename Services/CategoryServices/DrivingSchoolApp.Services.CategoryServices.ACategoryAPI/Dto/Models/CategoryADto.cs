
namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto.Models
{
	public class CategoryADto : BaseDto
	{		
		public string City { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }		
		public IEnumerable<InstructorDto> Instructors { get; set; } = new List<InstructorDto>();
		public IEnumerable<LessonDto> Lessons { get; set; } = new List<LessonDto>();
		public IEnumerable<MotorcycleDto> Motorcycles { get; set; } = new List<MotorcycleDto>();
	}
}
