using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbCarConfigurations
	{
		public static void CarConfigurations(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>()
				.HasMany(x => x.CarsPerCity)
				.WithOne(x => x.Car)
				.HasForeignKey(x => x.CarId);

			modelBuilder.Entity<Car>().Property(x => x.Type).HasColumnName("Type").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Model).HasColumnName("Model").HasColumnType("nvarchar").HasMaxLength(200).IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Year).HasColumnName("Year").HasColumnType("int").IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Fuel).HasColumnName("Fuel").HasColumnType("nvarchar").HasMaxLength(500).IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.FuelConsuption).HasColumnName("FuelConsuption").HasColumnType("decimal").HasPrecision(2,1).IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Power).HasColumnName("Power").HasColumnType("smallint").IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Length).HasColumnName("Length").HasColumnType("int").IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Speed).HasColumnName("Speed").HasColumnType("int").IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Doors).HasColumnName("Doors").HasColumnType("tinyint").IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Transmission).HasColumnName("Transmission").HasColumnType("nvarchar").HasMaxLength(350).IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Color).HasColumnName("Color").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.Photo).HasColumnName("Photo").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
			modelBuilder.Entity<Car>().Property(x => x.AvailableCars).HasColumnName("AvailableCars").HasColumnType("tinyint").IsRequired(true);
		}
	}
}
