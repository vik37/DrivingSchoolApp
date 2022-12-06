using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbInstructorCategoryLicenceConfigurations
	{
		public static void InstructorCategoryLicenceConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<InstructorCategoryLicence>().Property(x => x.CategoryType).HasColumnName("CategoryType").HasColumnType("tinyint").IsRequired(true);
		}
	}
}
