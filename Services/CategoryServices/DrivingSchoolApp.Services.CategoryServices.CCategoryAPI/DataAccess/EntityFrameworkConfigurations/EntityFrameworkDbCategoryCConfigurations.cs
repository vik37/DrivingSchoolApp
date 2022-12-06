using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbCategoryCConfigurations
	{
		public static void CategoryCConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryC>()
				.HasMany(x => x.TruckPerCities)
				.WithOne(x => x.CategoryC)
				.HasForeignKey(x => x.CategoryCId);
			modelBuilder.Entity<CategoryC>()
				.HasMany(x => x.Lessons)
				.WithOne(x => x.CategoryC)
				.HasForeignKey(x => x.CategoryCId);
			modelBuilder.Entity<CategoryC>()
				.HasMany(x => x.Instructors)
				.WithOne(x => x.CategoryC)
				.HasForeignKey(x => x.CategoryCId);

			modelBuilder.Entity<CategoryC>().Property(x => x.City).HasColumnName("City").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			modelBuilder.Entity<CategoryC>().Property(x => x.Address).HasColumnName("Address").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
			modelBuilder.Entity<CategoryC>().Property(x => x.Phone).HasColumnName("Phone").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
		}
	}
}
