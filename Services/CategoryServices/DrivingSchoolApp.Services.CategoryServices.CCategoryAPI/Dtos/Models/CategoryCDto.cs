namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models
{
    public class CategoryCDto : BaseDto
    {
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public IEnumerable<TruckDto> Trucks { get; set; } = new List<TruckDto>();
        public IEnumerable<LessonDto> Lessons { get; set; } = new List<LessonDto>();
        public IEnumerable<InstructorDto> Instructors { get; set; } = new List<InstructorDto>();
    }
}
