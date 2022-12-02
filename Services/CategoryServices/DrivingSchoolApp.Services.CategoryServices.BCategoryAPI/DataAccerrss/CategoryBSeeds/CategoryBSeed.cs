using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.CategoryBSeeds
{
	public static class CategoryBSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryB>()
				.HasData(
					new CategoryB
					{
						Id = 1,
						City = "Skopje",
						Address = "bul. ASNOM 12/A",
						Phone = "+389 01 222 110"
					},
					new CategoryB
					{
						Id = 2,
						City = "Bitola",
						Address = "ul. Mirche Acev",
						Phone = "+389 21 334 667"
					},
					new CategoryB
					{
						Id = 3,
						City = "Stip",
						Address = "bul. JNA 120",
						Phone = "+389 01 554 2290",
					},
					new CategoryB
					{
						Id = 4,
						City = "Ohrid",
						Address = "ul. Marko Nestoroski 22",
						Phone = "+389 23 904 106"
					}
				);
		}
	}
}
