using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbInstructorConfigurations
	{
		public static void InstructorConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Instructor>().Property(x => x.Firstname).HasColumnName("Firstname").HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
			modelBuilder.Entity<Instructor>().Property(x => x.Lastname).HasColumnName("Lastname").HasColumnType("nvarchar").HasMaxLength(350).IsRequired();
			modelBuilder.Entity<Instructor>().Property(x => x.Age).HasColumnName("Age").HasColumnType("smallint").IsRequired();
			modelBuilder.Entity<Instructor>().Property(x => x.Experience).HasColumnName("Experience").HasColumnType("smallint").IsRequired();
			modelBuilder.Entity<Instructor>().Property(x => x.StartedDay).HasColumnName("StartedDay").HasColumnType("nvarchar").HasMaxLength(500).IsRequired();
			modelBuilder.Entity<Instructor>().Property(x => x.Photo).HasColumnName("Photo").HasColumnType("nvarchar").HasMaxLength(550);
			modelBuilder.Entity<Instructor>().Property(x => x.isBooked).HasColumnName("isBooked").HasColumnType("bit").IsRequired();
		}
	}
}
