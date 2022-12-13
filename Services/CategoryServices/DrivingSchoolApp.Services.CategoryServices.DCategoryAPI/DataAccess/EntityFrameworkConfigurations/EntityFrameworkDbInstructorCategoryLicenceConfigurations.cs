using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.EntityFrameworkConfigurations;

public class EntityFrameworkDbInstructorCategoryLicenceConfigurations
{
	public static void InstructorCategoryLicenceConfiguration(ModelBuilder modelBuilder, string schema)
	{
		modelBuilder.HasDefaultSchema(schema);
		modelBuilder.Entity<InstructorCategoryLicence>().ToTable("InstructorCategoryLicence");

		modelBuilder.Entity<InstructorCategoryLicence>().Property(x => x.CategoryType).HasColumnName("CategoryType").HasColumnType("tinyint").IsRequired(true);
	}
}