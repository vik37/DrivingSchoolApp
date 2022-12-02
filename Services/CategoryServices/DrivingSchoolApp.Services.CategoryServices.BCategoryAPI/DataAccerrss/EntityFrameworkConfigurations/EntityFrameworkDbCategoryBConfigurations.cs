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
				.HasMany(x => x.CarPerCity)
				.WithOne(x => x.CategoryB)
				.HasForeignKey(x => x.CategoryBId);
			modelBuilder.Entity<CategoryB>()
				.HasMany(x => x.CategoryLessons)
				.WithOne(x => x.CategoryB)
				.HasForeignKey(x => x.CategoryBId);

			modelBuilder.Entity<CategoryB>().Property(x => x.City).HasColumnName("City").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			modelBuilder.Entity<CategoryB>().Property(x => x.Address).HasColumnName("Address").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
			modelBuilder.Entity<CategoryB>().Property(x => x.Phone).HasColumnName("Phone").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
		}
	}
}
