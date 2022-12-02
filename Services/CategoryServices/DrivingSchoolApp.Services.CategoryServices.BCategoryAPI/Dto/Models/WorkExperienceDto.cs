namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models
{
	public class WorkExperienceDto : BaseDto
	{
		public int Experience { get; set; }
		public string Company { get; set; }
		public int? InstructorId { get; set; }
	}
}
