using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.EntityFrameworkConfigurations
{
	public static class EntityFrameworkDbTruckConfigurations
	{
		public static void TruckConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Truck>()
				.HasMany(x => x.TruckPerCities)
				.WithOne(x => x.Truck)
				.HasForeignKey(x => x.TruckId);

			modelBuilder.Entity<Truck>().Property(x => x.Type).HasColumnName("Type").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.Model).HasColumnName("Model").HasColumnType("nvarchar").HasMaxLength(200).IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.Year).HasColumnName("Year").HasColumnType("int").IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.Fuel).HasColumnName("Fuel").HasColumnType("nvarchar").HasMaxLength(500).IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.Power).HasColumnName("Power").HasColumnType("smallint").IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.Transmission).HasColumnName("Transmission").HasColumnType("nvarchar").HasMaxLength(650).IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.CylinderCapacity).HasColumnName("CylinderCapacity").HasColumnType("int").IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.Color).HasColumnName("Color").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.Photo).HasColumnName("Photo").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
			modelBuilder.Entity<Truck>().Property(x => x.AvailableTruck).HasColumnName("AvailableTruck").HasColumnType("tinyint").IsRequired(true);
		}
	}
}
