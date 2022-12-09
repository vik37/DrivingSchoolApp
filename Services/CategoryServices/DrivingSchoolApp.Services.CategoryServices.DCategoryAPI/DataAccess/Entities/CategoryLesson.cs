namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities
{
	public class CategoryLesson : Base
	{
		public virtual Lesson Lesson { get; set; }
		public virtual CategoryD CategoryD { get; set; }
		public int CategoryDId { get; set; }
		public int LessonId { get; set; }
	}
}
