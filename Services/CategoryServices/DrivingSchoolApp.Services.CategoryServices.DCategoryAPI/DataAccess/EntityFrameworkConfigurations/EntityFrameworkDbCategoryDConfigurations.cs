using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbCategoryDConfigurations
	{
		public static void CategoryDConfiguration(ModelBuilder modelBuilder, string schema)
		{
			modelBuilder.HasDefaultSchema(schema);
			modelBuilder.Entity<CategoryD>().ToTable("CategoryD");

			modelBuilder.Entity<CategoryD>()
				.HasMany(x => x.Lessons)
				.WithOne(x => x.CategoryD)
				.HasForeignKey(x => x.CategoryDId);
			modelBuilder.Entity<CategoryD>()
				.HasMany(x => x.Instructors)
				.WithOne(x => x.CategoryD)
				.HasForeignKey(x => x.CategoryDId);

			modelBuilder.Entity<CategoryD>().Property(x => x.City).HasColumnName("City").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			modelBuilder.Entity<CategoryD>().Property(x => x.Address).HasColumnName("Address").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
			modelBuilder.Entity<CategoryD>().Property(x => x.Phone).HasColumnName("Phone").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
			modelBuilder.Entity<CategoryD>().Property(x => x.BusPhoto).HasColumnName("BusPhoto").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
		}
	}
}
