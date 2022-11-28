using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities
{
	public class Instructor : Base
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public int Age { get; set; }
		public string LicenceId { get; set; }
		public string Photo { get; set; }
		public string StartedDay { get; set; }
		public int Experience { get; set; }
		public bool isBooked { get; set; }
		public int CategoryAId { get; set; }
		public virtual CategoryA CategoryA { get; set; }
	}
}
