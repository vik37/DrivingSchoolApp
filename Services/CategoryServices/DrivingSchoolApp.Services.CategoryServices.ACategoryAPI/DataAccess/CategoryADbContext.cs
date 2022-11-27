using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess
{
	public class CategoryADbContext : DbContext
	{
		public CategoryADbContext(DbContextOptions option) : base(option)
		{ }

		public DbSet<CategoryA> CategoryA { get; set; }
		public DbSet<Instructor> Instructor { get; set; }
		public DbSet<Motorcycle> Motorcycle { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryA>()
				.HasMany(x => x.Instructors)
				.WithOne(x => x.CategoryA)
				.HasForeignKey(x => x.CategoryAId);			
		}
	}
}
