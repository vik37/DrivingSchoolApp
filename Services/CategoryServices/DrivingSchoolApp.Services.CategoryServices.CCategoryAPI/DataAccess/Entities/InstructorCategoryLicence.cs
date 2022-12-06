using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities
{
	public class InstructorCategoryLicence : Base
	{
		public CategoryType CategoryType { get; set; }
		public Instructor Instructor { get; set; }
		public int ÌnstructorId { get; set; }
	}
}
