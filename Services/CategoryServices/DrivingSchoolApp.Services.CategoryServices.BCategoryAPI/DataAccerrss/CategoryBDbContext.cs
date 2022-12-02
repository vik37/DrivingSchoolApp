using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
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

			modelBuilder.Entity<CategoryLesson>()
				.HasKey(x => new { x.LessonId, x.CategoryBId });
			modelBuilder.Entity<CarPerCity>()
				.HasKey(x => new {x.CategoryBId, x.CarId});

			modelBuilder.Entity<CategoryB>().Property(x => x.City).HasColumnName("City").HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
			modelBuilder.Entity<CategoryB>().Property(x => x.Address).HasColumnName("Address").HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
			modelBuilder.Entity<CategoryB>().Property(x => x.Phone).HasColumnName("Phone").HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
		}
	}
}
