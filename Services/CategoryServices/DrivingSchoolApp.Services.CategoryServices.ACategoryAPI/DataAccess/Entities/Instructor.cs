using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities
{
	public class Instructor : Booked
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public int Age { get; set; }
		public string LicenceId { get; set; }
		public string Photo { get; set; }
		public int Experience { get; set; }
		public string StartedDay { get; set; }
		public string EndedDay { get; set; }
		public int CategoryAId { get; set; }
		public CategoryA CategoryA { get; set; }

	}
}
