using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbMotorcycleConfigurations
	{
		public static void MotorcycleConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Motorcycle>()
				.HasMany(x => x.MotorsPerCity)
				.WithOne(x => x.Motorcycle)
				.HasForeignKey(x => x.MotorcycleId);

			modelBuilder.Entity<Motorcycle>().Property(x => x.Type).HasColumnName("Type").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Model).HasColumnName("Model").HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Year).HasColumnName("Year").HasColumnType("int").IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Fuel).HasColumnName("Fuel").HasColumnType("smallint").IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Capacity).HasColumnName("Capacity").HasColumnType("int").IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Weight).HasColumnName("Weight").HasColumnType("int").IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Speed).HasColumnName("Speed").HasColumnType("smallint").IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Color).HasColumnName("Color").HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.Photo).HasColumnName("Photo").HasColumnType("nvarchar").HasMaxLength(1000).IsRequired();
			modelBuilder.Entity<Motorcycle>().Property(x => x.AvailableMotorcycles).HasColumnName("AvailableMotorcycles").HasColumnType("smallint").IsRequired();
		}
	}
}
