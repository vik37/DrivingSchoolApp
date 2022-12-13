using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.EntityFrameworkConfigurations;

public class EntityFrameworkDbLessonConfigurations
{
	public static void LessonConfguration(ModelBuilder modelBuilder, string schema)
	{
		modelBuilder.HasDefaultSchema(schema);
		modelBuilder.Entity<Lesson>().ToTable("Lesson");

		modelBuilder.Entity<Lesson>()
			.HasMany(x => x.CategoryLessons)
			.WithOne(x => x.Lesson)
			.HasForeignKey(x => x.LessonId);

		modelBuilder.Entity<Lesson>().Property(x => x.Type).HasColumnName("Type").HasColumnType("tinyint").IsRequired(true);
		modelBuilder.Entity<Lesson>().Property(x => x.Price).HasColumnName("Price").HasColumnType("decimal").HasPrecision(5, 2).IsRequired(true);
		modelBuilder.Entity<Lesson>().Property(x => x.TestPrice).HasColumnName("TestPrice").HasColumnType("decimal").HasPrecision(5, 2).IsRequired(true);
		modelBuilder.Entity<Lesson>().Property(x => x.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(2000).IsRequired(true);
		modelBuilder.Entity<Lesson>().Property(x => x.LicenceDescription).HasColumnName("LicenceDescription").HasColumnType("nvarchar").HasMaxLength(2000).IsRequired(false);
		modelBuilder.Entity<Lesson>().Property(x => x.Duration).HasColumnName("Duration").HasColumnType("int").IsRequired(true);
		modelBuilder.Entity<Lesson>().Property(x => x.VirtualPracticePrice).HasColumnName("VirtualPracticePrice").HasColumnType("decimal").HasPrecision(5, 2).IsRequired(false);
		modelBuilder.Entity<Lesson>().Property(x => x.Discount).HasColumnName("Discount").HasColumnType("smallint").IsRequired(false);
	}
}