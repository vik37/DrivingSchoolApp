using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.EntityFrameworkConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss
{
	public class CategoryBDbContext : DbContext
	{
		public CategoryBDbContext(DbContextOptions<CategoryBDbContext> option) : base(option)
		{ }

		public DbSet<CategoryB> CategoryB { get; set; }
		public DbSet<Car> Car { get; set; }
		public DbSet<Lesson> Lesson { get; set; }
		public DbSet<Instructor> Instructor { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			MainCategoryBSeed.Seed(modelBuilder);

			EntityFrameworkDbCarConfigurations.CarConfigurations(modelBuilder);
			EntityFrameworkDbCategoryBConfigurations.CategoryBConfigurations(modelBuilder);
			EntityFrameworkDbInstructorConfigurations.InstructorConfigurations(modelBuilder);
			EntityFrameworkDbLessonConfigurations.LessonConfigurations(modelBuilder);
			EntityFrameworkDbWorkExperienceConfigurations.WorkExperienceConfiguration(modelBuilder);

			modelBuilder.Entity<CategoryLesson>()
				.HasKey(x => new { x.LessonId, x.CategoryBId });
			modelBuilder.Entity<CarPerCity>()
				.HasKey(x => new {x.CategoryBId, x.CarId});
			
		}
	}
}
