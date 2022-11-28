using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.EntityFrameworkConfigurations;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess
{
	public class CategoryADbContext : DbContext
	{
		public CategoryADbContext(DbContextOptions<CategoryADbContext> option) : base(option)
		{ }

		public DbSet<CategoryA> CategoryA { get; set; }
		public DbSet<Instructor> Instructor { get; set; }
		public DbSet<Motorcycle> Motorcycle { get; set; }
		public DbSet<Lesson> Lesson { get; set; }
		public DbSet<CategoryLesson> CategoryLessons { get; set; }
		public DbSet<MororsPerCity> MororsPerCity { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			CategoryASeed.Seed(modelBuilder);

			EntityFrameworkDbCategoryAConfigurations.CategoryAConfiguration(modelBuilder);
			EntityFrameworkDbInstructorConfigurations.InstructorConfiguration(modelBuilder);
			EntityFrameworkDbLessonConfigurations.LessonConfiguration(modelBuilder);
			EntityFrameworkDbMotorcycleConfigurations.MotorcycleConfiguration(modelBuilder);
			
			modelBuilder.Entity<CategoryLesson>()
				.HasKey(x => new {x.LessonId, x.CategoryAId});

			modelBuilder.Entity<MororsPerCity>()
				.HasKey(x => new {x.MotorcycleId,x.CategoryAId});			
		}
	}
}
