using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbWorkExperienceConfigurations
	{
		public static void WorkExperienceConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WorkExperience>().Property(x => x.Experience).HasColumnName("Experience").HasColumnType("int").IsRequired(true);
			modelBuilder.Entity<WorkExperience>().Property(x => x.Company).HasColumnName("Company").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
			modelBuilder.Entity<WorkExperience>().Property(x => x.TypeOfWorkExperience).HasColumnName("TypeOfWorkExperience").HasColumnType("tinyint").IsRequired(true);
		}
	}
}
