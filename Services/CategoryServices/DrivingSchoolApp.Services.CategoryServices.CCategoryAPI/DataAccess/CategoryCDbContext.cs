using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.EntityFrameworkConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess
{
    public class CategoryCDbContext : DbContext
	{
		public CategoryCDbContext(DbContextOptions<CategoryCDbContext> options): base(options)
		{ }

		public DbSet<Truck> Truck { get; set; }
		public DbSet<CategoryC> CategoryC { get; set; }
		public DbSet<Lesson> Lesson { get; set; }
		public DbSet<Instructor> Instructor { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			MainCategoryCSeed.Seed(modelBuilder);

			EntityFrameworkDbCategoryCConfigurations.CategoryCConfiguration(modelBuilder);
			EntityFrameworkDbInstructorCategoryLicenceConfigurations.InstructorCategoryLicenceConfiguration(modelBuilder);
			EntityFrameworkDbInstructorConfigurations.InstructorConfiguration(modelBuilder);
			EntityFrameworkDbLessonConfigurations.LessonConfiguration(modelBuilder);
			EntityFrameworkDbTruckConfigurations.TruckConfiguration(modelBuilder);
			EntityFrameworkDbWorkExperienceConfigurations.WorkExperienceConfiguration(modelBuilder);

			modelBuilder.Entity<CategoryLesson>()
				.HasKey(x => new { x.LessonId, x.CategoryCId });
			modelBuilder.Entity<TruckPerCity>()
				.HasKey(x => new { x.TruckId, x.CategoryCId });
		}
	}
}
