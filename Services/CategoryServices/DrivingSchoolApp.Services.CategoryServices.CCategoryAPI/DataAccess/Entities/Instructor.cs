namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities
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
		public int TotalDriveExperience { get; set; }
		public int TruckDriveExperience { get; set; }
		public string InstructorAcademy { get; set; }
		public bool isBooked { get; set; }
		public int CategoryCId { get; set; }
		public virtual CategoryC CategoryC { get; set; }
		public IEnumerable<WorkExperience> WorkExperiencePerCompany { get; set; } = new List<WorkExperience>();
		public IEnumerable<InstructorCategoryLicence> CategoryLicences { get; set; } = new List<InstructorCategoryLicence>();
	}
}
