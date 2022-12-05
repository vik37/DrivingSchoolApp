using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.CategoryBSeeds;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess
{
	public static class MainCategoryBSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			CarSeed.Seed(modelBuilder);
			CategoryBSeed.Seed(modelBuilder);
			LessonSeed.Seed(modelBuilder);
			InstructorSeed.Seed(modelBuilder);
			WorkExperienceSeed.Seed(modelBuilder);

			modelBuilder.Entity<CategoryLesson>()
				.HasData(
					new CategoryLesson
					{
						Id = 1,
						CategoryBId = 1,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 2,
						CategoryBId = 1,
						LessonId = 2,
					},
					new CategoryLesson
					{
						Id = 3,
						CategoryBId = 1,
						LessonId = 3,
					},
					new CategoryLesson
					{
						Id = 4,
						CategoryBId = 2,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 5,
						CategoryBId = 2,
						LessonId = 2,
					},
					new CategoryLesson
					{
						Id = 6,
						CategoryBId = 2,
						LessonId = 3,
					},
					new CategoryLesson
					{
						Id = 7,
						CategoryBId = 3,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 8,
						CategoryBId = 3,
						LessonId = 2,
					},
					new CategoryLesson
					{
						Id = 9,
						CategoryBId = 3,
						LessonId = 3,
					},
					new CategoryLesson
					{
						Id = 10,
						CategoryBId = 4,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 11,
						CategoryBId = 4,
						LessonId = 2,
					},
					new CategoryLesson
					{
						Id = 12,
						CategoryBId = 4,
						LessonId = 3,
					}
				);
			
			modelBuilder.Entity<CarPerCity>()
				.HasData(
					new CarPerCity
					{
						Id = 1,
						CategoryBId = 1,
						CarId = 1
					},
					new CarPerCity
					{
						Id = 2,
						CategoryBId = 1,
						CarId = 2
					},
					new CarPerCity
					{
						Id = 3,
						CategoryBId = 1,
						CarId = 3
					},
					new CarPerCity
					{
						Id = 4,
						CategoryBId = 1,
						CarId = 4
					},
					new CarPerCity
					{
						Id = 5,
						CategoryBId = 1,
						CarId = 5
					},
					new CarPerCity
					{
						Id = 6,
						CategoryBId = 2,
						CarId = 1
					},
					new CarPerCity
					{
						Id = 7,
						CategoryBId = 2,
						CarId = 2
					},
					new CarPerCity
					{
						Id = 8,
						CategoryBId = 2,
						CarId = 3
					},
					new CarPerCity
					{
						Id = 9,
						CategoryBId = 2,
						CarId = 4
					},
					new CarPerCity
					{
						Id = 10,
						CategoryBId = 2,
						CarId = 5
					},
					new CarPerCity
					{
						Id = 11,
						CategoryBId = 3,
						CarId = 2
					},
					new CarPerCity
					{
						Id = 12,
						CategoryBId = 3,
						CarId = 4
					},
					new CarPerCity
					{
						Id = 13,
						CategoryBId = 3,
						CarId = 5
					},
					new CarPerCity
					{
						Id = 14,
						CategoryBId = 4,
						CarId = 1
					},
					new CarPerCity
					{
						Id = 15,
						CategoryBId = 4,
						CarId = 2
					},
					new CarPerCity
					{
						Id = 16,
						CategoryBId = 4,
						CarId = 4
					}
				);			
		}
	}
}
