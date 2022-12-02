namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities
{
    public class Instructor : Base
    {
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public int Age { get; set; }
		public string LicenceId { get; set; }
		public string Photo { get; set; }
		public string StartedDay { get; set; }
		public int TotalWorkExperience { get; set; }
		public int DriveExperience { get; set; }
		public string InstructorAcademy { get; set; }
		public bool isBooked { get; set; }
		public int CategoryBId { get; set; }
		public virtual CategoryB CategoryB { get; set; }
		public IEnumerable<WorkExperience> WorkExperiencesPerCompany { get; set; } = new List<WorkExperience>();
	}
}
