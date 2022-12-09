using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.CategoryDSeeds
{
	public static class CategoryDSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryD>()
				.HasData(
					new CategoryD
					{
						Id = 1,
						City = "Skopje",
						Address = "bul. ASNOM 12/A",
						Phone = "+389 01 222 110",
						BusPhoto = "skopje-bus"
					},
					new CategoryD
					{
						Id = 2,
						City = "Bitola",
						Address = "ul. Mirche Acev",
						Phone = "+389 21 334 667",
						BusPhoto = "bitola-bus"
					}
				);
		}
	}
}
