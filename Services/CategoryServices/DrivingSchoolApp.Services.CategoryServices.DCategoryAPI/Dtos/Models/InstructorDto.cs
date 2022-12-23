namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models; 

public class InstructorDto : BaseDto 
{
	public string Fullname { get; set; }
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
	public IEnumerable<WorkExperienceDto> WorkExperiences { get; set; } = new List<WorkExperienceDto>();
	public IEnumerable<InstructorCategoryLicenceDto> CategoryLicences { get; set; } = new List<InstructorCategoryLicenceDto>();
}