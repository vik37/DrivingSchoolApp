namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities
{
	public class CategoryLesson : Base
	{
		public virtual Lesson Lessons { get; set; }
		public virtual CategoryB CategoryB { get; set; }
		public int CategoryBId { get; set; }
		public int LessonId { get; set; }
	}
}
