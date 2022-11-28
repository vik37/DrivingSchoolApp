using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbCategoryAConfigurations
	{
		public static void CategoryAConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryA>()
				.HasMany(x => x.Instructors)
				.WithOne(x => x.CategoryA)
				.HasForeignKey(x => x.CategoryAId);
			modelBuilder.Entity<CategoryA>()
				.HasMany(x => x.CategoryLessons)
				.WithOne(x => x.CategoryA)
				.HasForeignKey(x => x.CategoryAId);
			modelBuilder.Entity<CategoryA>()
				.HasMany(x => x.MotorcyclePerCity)
				.WithOne(x => x.CategoryA)
				.HasForeignKey(x => x.CategoryAId);

			modelBuilder.Entity<CategoryA>().Property(x => x.City).HasColumnName("City").HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
			modelBuilder.Entity<CategoryA>().Property(x => x.Address).HasColumnName("Address").HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
			modelBuilder.Entity<CategoryA>().Property(x => x.Phone).HasColumnName("Phone").HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
		}
	}
}
