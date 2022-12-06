using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.CategoryCSeeds;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess
{
	public static class MainCategoryCSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			CategoryCSeed.Seed(modelBuilder);
			TruckSeed.Seed(modelBuilder);
			LessonSeed.Seed(modelBuilder);
			InstructorSeed.Seed(modelBuilder);
			WorkExperienceSeed.Seed(modelBuilder);
			InstructorCategoryLicenceSeed.Seed(modelBuilder);

			modelBuilder.Entity<TruckPerCity>()
				.HasData(
					new TruckPerCity
					{
						Id= 1,
						CategoryCId= 1,
						TruckId= 1
					},
					new TruckPerCity
					{
						Id= 2,
						CategoryCId= 1,
						TruckId= 2
					},
					new TruckPerCity
					{
						Id= 3,
						CategoryCId= 2,
						TruckId = 1
					},
					new TruckPerCity
					{
						Id = 4,
						CategoryCId = 2,
						TruckId= 2
					}
				);
			modelBuilder.Entity<CategoryLesson>()
				.HasData(
					new CategoryLesson
					{
						Id= 1,
						CategoryCId= 1,
						LessonId= 1
					},
					new CategoryLesson
					{
						Id= 2,
						CategoryCId= 1,
						LessonId= 2
					},
					new CategoryLesson
					{
						Id= 3,
						CategoryCId= 1,
						LessonId = 3
					},
					new CategoryLesson
					{
						Id= 4,
						CategoryCId= 2,
						LessonId= 1
					},
					new CategoryLesson
					{
						Id= 5,
						CategoryCId= 2,
						LessonId= 2
					},
					new CategoryLesson
					{
						Id= 6,
						CategoryCId= 2,
						LessonId= 3
					}
				);
		}
	}
}
