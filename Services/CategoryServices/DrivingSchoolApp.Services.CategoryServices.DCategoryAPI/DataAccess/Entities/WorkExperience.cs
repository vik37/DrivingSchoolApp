using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;

public class WorkExperience : Base
{
	public int Experience { get; set; }
	public string Company { get; set; }
	public TypeOfWorkExperience TypeOfWorkExperience { get; set; }
	public int? InstructorId { get; set; }
	public virtual Instructor Instructor { get; set; }
}