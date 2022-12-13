using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models;

public class InstructorCategoryLicenceDto : BaseDto
{
	public CategoryType CategoryType { get; set; }
	public int ÌnstructorId { get; set; }
	public InstructorDto Instructor { get; set; }
}