namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities
{
	public class TruckPerCity : Base
	{
		public int CategoryCId { get; set; }
		public virtual CategoryC CategoryC { get; set; }
		public int TruckId { get; set; }
		public virtual Truck Truck { get; set; }
	}
}
