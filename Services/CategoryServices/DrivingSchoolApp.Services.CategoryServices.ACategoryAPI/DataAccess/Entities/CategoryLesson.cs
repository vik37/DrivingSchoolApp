using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities
{
	public class CategoryLesson : Base
	{
		public virtual Lesson Lessons { get; set; }
		public virtual CategoryA CategoryA { get; set; }
		public int CategoryAId { get; set; }
		public int LessonId { get; set; }
	}
}
