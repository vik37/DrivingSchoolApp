namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities
{
	public class CategoryLesson : Base
	{
		public virtual Lesson Lessons { get; set; }
		public virtual CategoryC CategoryC { get; set; }
		public int CategoryCId { get; set; }
		public int LessonId { get; set; }
	}
}
