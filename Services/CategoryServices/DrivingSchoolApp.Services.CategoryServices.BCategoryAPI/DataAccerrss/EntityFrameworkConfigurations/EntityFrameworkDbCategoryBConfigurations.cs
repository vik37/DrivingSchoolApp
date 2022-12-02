using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbCategoryBConfigurations
	{
		public static void CategoryBConfigurations(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryB>()
				.HasMany(x => x.Instructors)
				.WithOne(x => x.CategoryB)
				.HasForeignKey(x => x.CategoryBId);
			modelBuilder.Entity<CategoryB>()
				.HasMany(x => x.MotorcyclePerCity)
				.WithOne(x => x.CategoryB)
				.HasForeignKey(x => x.CategoryBId);
			modelBuilder.Entity<CategoryB>()
				.HasMany(x => x.CategoryLessons)
				.WithOne(x => x.CategoryB)
				.HasForeignKey(x => x.CategoryBId);
		}
	}
}
