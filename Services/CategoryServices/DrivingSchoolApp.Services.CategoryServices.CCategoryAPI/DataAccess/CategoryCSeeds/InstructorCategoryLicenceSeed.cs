using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.CategoryCSeeds
{
	public static class InstructorCategoryLicenceSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<InstructorCategoryLicence>()
				.HasData(
					new InstructorCategoryLicence
					{
						Id = 1,
						CategoryType = CategoryType.B,
						ÌnstructorId= 1
					},
					new InstructorCategoryLicence
					{
						Id = 2,
						CategoryType = CategoryType.C,
						ÌnstructorId = 1
					},
					new InstructorCategoryLicence
					{
						Id = 3,
						CategoryType = CategoryType.A,
						ÌnstructorId = 2
					},
					new InstructorCategoryLicence
					{
						Id = 4,
						CategoryType = CategoryType.B,
						ÌnstructorId = 2
					},
					new InstructorCategoryLicence
					{
						Id = 5,
						CategoryType = CategoryType.C,
						ÌnstructorId = 2
					},
					new InstructorCategoryLicence
					{
						Id = 6,
						CategoryType = CategoryType.D,
						ÌnstructorId = 2
					},
					new InstructorCategoryLicence
					{
						Id = 7,
						CategoryType = CategoryType.B,
						ÌnstructorId = 3
					},
					new InstructorCategoryLicence
					{
						Id = 8,
						CategoryType = CategoryType.C,
						ÌnstructorId = 3
					}
				);
		}
	}
}
