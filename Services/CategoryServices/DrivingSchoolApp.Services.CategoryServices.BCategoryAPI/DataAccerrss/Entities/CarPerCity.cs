namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities
{
	public class CarPerCity : Base
	{
		public int CategoryBId { get; set; }
		public virtual CategoryB CategoryB { get; set; }
		public int CarId { get; set; }
		public virtual Car Car { get; set; }
	}
}
