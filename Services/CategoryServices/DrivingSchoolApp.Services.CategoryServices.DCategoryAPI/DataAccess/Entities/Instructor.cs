namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;

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
	public int BusDriveExperience { get; set; }
	public string InstructorAcademy { get; set; }
	public bool isBooked { get; set; }
	public int CategoryDId { get; set; }
	public virtual CategoryD CategoryD { get; set; }
	public IEnumerable<WorkExperience> WorkExperiencePerCompany { get; set; } = new List<WorkExperience>();
	public IEnumerable<InstructorCategoryLicence> CategoryLicences { get; set; } = new List<InstructorCategoryLicence>();
}