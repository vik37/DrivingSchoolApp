using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities
{
	public class MororsPerCity : Base
	{
		public int CategoryAId { get; set; }
		public virtual CategoryA CategoryA { get; set; }
		public int MotorcycleId { get; set;}
		public virtual Motorcycle Motorcycle { get; set; }
	}
}
