using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.CategoryDSeeds
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
						CategoryType = CategoryType.A,
						ÌnstructorId = 1
					},
					new InstructorCategoryLicence
					{
						Id = 2,
						CategoryType = CategoryType.B,
						ÌnstructorId = 1
					},
					new InstructorCategoryLicence
					{
						Id = 3,
						CategoryType = CategoryType.C,
						ÌnstructorId = 1
					},
					new InstructorCategoryLicence
					{
						Id = 4,
						CategoryType = CategoryType.D,
						ÌnstructorId = 1
					},
					new InstructorCategoryLicence
					{
						Id = 5,
						CategoryType = CategoryType.B,
						ÌnstructorId = 2
					},
					new InstructorCategoryLicence
					{
						Id = 6,
						CategoryType = CategoryType.C,
						ÌnstructorId = 2
					},
					new InstructorCategoryLicence
					{
						Id = 7,
						CategoryType = CategoryType.D,
						ÌnstructorId = 2
					},
					new InstructorCategoryLicence
					{
						Id = 8,
						CategoryType = CategoryType.B,
						ÌnstructorId = 3
					},
					new InstructorCategoryLicence
					{
						Id = 9,
						CategoryType = CategoryType.C,
						ÌnstructorId = 3
					},
					new InstructorCategoryLicence
					{
						Id = 10,
						CategoryType = CategoryType.D,
						ÌnstructorId = 3
					},
					new InstructorCategoryLicence
					{
						Id = 11,
						CategoryType = CategoryType.A,
						ÌnstructorId = 4
					},
					new InstructorCategoryLicence
					{
						Id = 12,
						CategoryType = CategoryType.B,
						ÌnstructorId = 4
					},
					new InstructorCategoryLicence
					{
						Id = 13,
						CategoryType = CategoryType.C,
						ÌnstructorId = 4
					},
					new InstructorCategoryLicence
					{
						Id = 14,
						CategoryType = CategoryType.D,
						ÌnstructorId = 4
					}
				);
		}
	}
}
