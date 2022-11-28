using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbLessonConfigurations
	{
		public static void LessonConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Lesson>()
				.HasMany(x => x.CategoryLessons)
				.WithOne(x => x.Lessons)
				.HasForeignKey(x => x.LessonId);

			modelBuilder.Entity<Lesson>().Property(x => x.Type).HasColumnName("Type").HasColumnType("tinyint").IsRequired();
			modelBuilder.Entity<Lesson>().Property(x => x.Price).HasColumnName("Price").HasColumnType("decimal(5,2)").IsRequired();
			modelBuilder.Entity<Lesson>().Property(x => x.TestPrice).HasColumnName("TestPrice").HasColumnType("decimal(5,2)").IsRequired();
			modelBuilder.Entity<Lesson>().Property(x => x.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(2000).IsRequired();
			modelBuilder.Entity<Lesson>().Property(x => x.LicenceDescription).HasColumnName("LicenceDescription").HasColumnType("nvarchar").HasMaxLength(2000);
			modelBuilder.Entity<Lesson>().Property(x => x.Duration).HasColumnName("Duration").HasColumnType("int").IsRequired();
			modelBuilder.Entity<Lesson>().Property(x => x.VirtualPracticePrice).HasColumnName("VirtualPracticePrice").HasColumnType("decimal(5,2)");
		}
	}
}
