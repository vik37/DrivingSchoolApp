using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models; 

public class WorkExperienceDto : BaseDto 
{
	public int Experience { get; set; }
	public string Company { get; set; }
	public TypeOfWorkExperience TypeOfWorkExperience { get; set; }
}