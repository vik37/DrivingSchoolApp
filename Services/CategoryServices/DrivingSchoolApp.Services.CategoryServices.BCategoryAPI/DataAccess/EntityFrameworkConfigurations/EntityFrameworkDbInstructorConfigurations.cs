using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbInstructorConfigurations
	{
		public static void InstructorConfigurations(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Instructor>()
				.HasMany(x => x.WorkExperiencesPerCompany)
				.WithOne(x => x.Instructor)
				.HasForeignKey(x => x.InstructorId);

			modelBuilder.Entity<Instructor>().Property(x => x.Firstname).HasColumnName("Firstname").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
			modelBuilder.Entity<Instructor>().Property(x => x.Lastname).HasColumnName("Lastname").HasColumnType("nvarchar").HasMaxLength(350).IsRequired(true);
			modelBuilder.Entity<Instructor>().Property(x => x.Age).HasColumnName("Age").HasColumnType("smallint").IsRequired(true);
			modelBuilder.Entity<Instructor>().Property(x => x.LicenceId).HasColumnName("LicenceId").HasColumnType("nvarchar").HasMaxLength(1150).IsRequired(true);
			modelBuilder.Entity<Instructor>().Property(x => x.StartedDay).HasColumnName("StartedDay").HasColumnType("nvarchar").HasMaxLength(500).IsRequired(true);
			modelBuilder.Entity<Instructor>().Property(x => x.Photo).HasColumnName("Photo").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(false);
			modelBuilder.Entity<Instructor>().Property(x => x.InstructorAcademy).HasColumnName("InstructorAcademy").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);			
			modelBuilder.Entity<Instructor>().Property(x => x.isBooked).HasColumnName("isBooked").HasColumnType("bit").IsRequired(true);
		}
	}
}
