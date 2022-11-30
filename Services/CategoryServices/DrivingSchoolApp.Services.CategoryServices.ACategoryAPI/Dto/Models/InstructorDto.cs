
namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto.Models
{
	public class InstructorDto : BaseDto
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public int Age { get; set; }
		public string LicenceId { get; set; }
		public string Photo { get; set; }
		public string StartedDay { get; set; }
		public int Experience { get; set; }
		public bool isBooked { get; set; }
		public int CategoryAId { get; set; }
		public virtual CategoryADto CategoryA { get; set; }
	}
}
