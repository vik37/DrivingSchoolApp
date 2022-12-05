using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public class EntityFrameworkDbWorkExperienceConfigurations
	{
		public static void WorkExperienceConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WorkExperience>().Property(x => x.Experience).HasColumnName("Experience").HasColumnType("int").IsRequired(true);
			modelBuilder.Entity<WorkExperience>().Property(x => x.Company).HasColumnName("Company").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
		}
	}
}
