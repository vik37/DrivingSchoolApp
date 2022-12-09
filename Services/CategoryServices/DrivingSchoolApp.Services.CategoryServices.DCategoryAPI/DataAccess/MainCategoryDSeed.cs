using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.CategoryDSeeds;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess
{
	public static class MainCategoryDSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			CategoryDSeed.Seed(modelBuilder);
			LessonSeed.Seed(modelBuilder);
			InstructorSeed.Seed(modelBuilder);
			WorkExperienceSeed.Seed(modelBuilder);
			InstructorCategoryLicenceSeed.Seed(modelBuilder);

			modelBuilder.Entity<CategoryLesson>()
				.HasData(
					new CategoryLesson
					{
						Id = 1,
						CategoryDId = 1,
						LessonId = 1
					},
					new CategoryLesson
					{
						Id = 2,
						CategoryDId = 1,
						LessonId = 2
					},
					new CategoryLesson
					{
						Id = 3,
						CategoryDId = 1,
						LessonId = 3
					},
					new CategoryLesson
					{
						Id = 4,
						CategoryDId = 1,
						LessonId = 4
					},
					new CategoryLesson
					{
						Id = 5,
						CategoryDId = 2,
						LessonId = 1
					},
					new CategoryLesson
					{
						Id = 6,
						CategoryDId = 2,
						LessonId = 2
					},
					new CategoryLesson
					{
						Id = 7,
						CategoryDId = 2,
						LessonId = 3
					},
					new CategoryLesson
					{
						Id = 8,
						CategoryDId = 2,
						LessonId = 4
					}
				);
		}
	}
}
