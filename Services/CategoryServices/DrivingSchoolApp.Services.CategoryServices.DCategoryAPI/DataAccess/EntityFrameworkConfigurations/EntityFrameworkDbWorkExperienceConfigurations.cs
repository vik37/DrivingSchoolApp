using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.EntityFrameworkConfigurations;
	
public class EntityFrameworkDbWorkExperienceConfigurations
{
	public static void WorkExperienceConfiguration(ModelBuilder modelBuilder,string schema)
	{
		modelBuilder.HasDefaultSchema(schema);
		modelBuilder.Entity<WorkExperience>().ToTable("WorkExperience");

		modelBuilder.Entity<WorkExperience>().Property(x => x.Experience).HasColumnName("Experience").HasColumnType("int").IsRequired(true);
		modelBuilder.Entity<WorkExperience>().Property(x => x.Company).HasColumnName("Company").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
		modelBuilder.Entity<WorkExperience>().Property(x => x.TypeOfWorkExperience).HasColumnName("TypeOfWorkExperience").HasColumnType("tinyint").IsRequired(true);
	}
}