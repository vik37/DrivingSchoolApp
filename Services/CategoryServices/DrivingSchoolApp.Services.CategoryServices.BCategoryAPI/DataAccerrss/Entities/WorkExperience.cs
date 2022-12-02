namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities
{
	public class WorkExperience : Base
	{
		public int Experience { get; set; }
		public string Company { get; set; }
		public int InstructorId { get; set; }
		public virtual Instructor Instructor { get; set; }
	}
}
