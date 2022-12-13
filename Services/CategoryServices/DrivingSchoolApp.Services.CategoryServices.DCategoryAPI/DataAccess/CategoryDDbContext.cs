using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.EntityFrameworkConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess;

public class CategoryDDbContext : DbContext
{
	public CategoryDDbContext(DbContextOptions<CategoryDDbContext> options): base(options)
	{ }
	public DbSet<CategoryD> CategoryD { get; set; }
	public DbSet<Instructor> Instructor { get; set; }
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
			
		MainCategoryDSeed.Seed(modelBuilder);

		string schema = "dbo";

		EntityFrameworkDbCategoryDConfigurations.CategoryDConfiguration(modelBuilder,schema);
		EntityFrameworkDbInstructorCategoryLicenceConfigurations.InstructorCategoryLicenceConfiguration(modelBuilder,schema);
		EntityFrameworkDbInstructorConfigurations.InstructorConfiguration(modelBuilder,schema);
		EntityFrameworkDbLessonConfigurations.LessonConfguration(modelBuilder,schema);
		EntityFrameworkDbWorkExperienceConfigurations.WorkExperienceConfiguration(modelBuilder,schema);

		modelBuilder.Entity<CategoryLesson>()
			.HasKey(x => new { x.LessonId, x.CategoryDId });
	} 
}