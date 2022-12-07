using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models
{
    public class LessonDto : BaseDto
    {
		public LessonTypes Type { get; set; }
		public double Price { get; set; }
		public double TestPrice { get; set; }
		public string Description { get; set; }
		public string LicenceDescription { get; set; }
		public int Duration { get; set; }
		public double? VirtualPracticePrice { get; set; }
		public int? Discount { get; set; }
	}
}
