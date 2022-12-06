using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.CategoryCSeeds
{
	public static class CategoryCSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryC>()
				.HasData(
					new CategoryC
					{
						Id = 1,
						City = "Skopje",
						Address = "bul. ASNOM 12/A",
						Phone = "+389 01 222 110"
					},
					new CategoryC
					{
						Id = 2,
						City = "Stip",
						Address = "bul. JNA 120",
						Phone = "+389 01 554 2290"
					}
				);

		}
	}
}
