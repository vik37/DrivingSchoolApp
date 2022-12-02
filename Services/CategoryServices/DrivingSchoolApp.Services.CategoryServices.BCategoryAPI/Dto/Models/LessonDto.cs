using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models
{
	public class LessonDto : BaseDto
	{
		public LessonType Type { get; set; }
		public double Price { get; set; }
		public double TestPrice { get; set; }
		public string Description { get; set; }
		public string LicenceDescription { get; set; }
		public int Duration { get; set; }
		public double? VirtualPracticePrice { get; set; }
		public int? Discount { get; set; }
	}
}
