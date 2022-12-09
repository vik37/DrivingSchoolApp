using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess
{
	public class CategoryDDbContext : DbContext
	{
		public CategoryDDbContext(DbContextOptions<CategoryDDbContext> options): base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
		} 
	}
}
