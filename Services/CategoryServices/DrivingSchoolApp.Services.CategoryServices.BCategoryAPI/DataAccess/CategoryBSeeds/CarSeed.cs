using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.CategoryBSeeds
{
	public static class CarSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>()
				.HasData(
					new Car
					{
						Id = 1,
						Type = "Vauxhall",
						Model = "Corsa",
						Year = 2020,
						Fuel = "Petrol",
						FuelConsuption = 4.1,
						Power = 75,
						Length = 4060,
						Speed = 174,
						Doors = 5,
						Transmission = "Manual, 5 Speed",
						Color = "Red",
						Photo = "vauxhall-corsa",
						AvailableCars = 4
					},
					new Car
					{
						Id = 2,
						Type = "Citroen",
						Model = "C1",
						Year = 2010,
						Fuel = "Diesel",
						FuelConsuption = 5.5,
						Power = 68,
						Length = 3435,
						Speed = 158,
						Doors = 3,
						Transmission = "Manual, 5 Speed",
						Color = "Red",
						Photo = "citroen_C1",
						AvailableCars = 5
					},
					new Car
					{
						Id = 3,
						Type = "Ford",
						Model = "Puma",
						Year = 2019,
						Fuel = "Petrol",
						FuelConsuption = 4.5,
						Power = 125,
						Length = 4186,
						Speed = 200,
						Doors = 5,
						Transmission = "Manual, 6 Speed",
						Color = "Blue",
						Photo = "ford-puma",
						AvailableCars = 3
					},
					new Car
					{
						Id = 4,
						Type = "Renault",
						Model = "Clio",
						Year = 2016,
						Fuel = "Petrol",
						FuelConsuption = 4.8,
						Power = 75,
						Length = 4063,
						Speed = 167,
						Doors = 3,
						Transmission = "Manual, 5 Speed",
						Color = "Red",
						Photo = "renault-clio",
						AvailableCars = 6
					},
					new Car
					{
						Id = 5,
						Type = "Volkswagen",
						Model = "Golf 5",
						Year = 2010,
						Fuel = "Diesel",
						FuelConsuption = 6.5,
						Power = 85,
						Length = 4199,
						Speed = 250,
						Doors = 5,
						Transmission = "6 Speed Automatic with Manual mode",
						Color = "Yellow",
						Photo = "VW-Golf",
						AvailableCars = 7
					}
				);
		}
	}
}
