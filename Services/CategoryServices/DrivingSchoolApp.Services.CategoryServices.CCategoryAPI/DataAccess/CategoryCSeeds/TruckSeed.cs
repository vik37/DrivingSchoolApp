using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.CategoryCSeeds
{
    public static class TruckSeed 
	{
		public  static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Truck>()
				.HasData(
					new Truck
					{
						Id= 1,
						TruckNumber = 7011,
						Model = "Mercedes-Benz",
						Type = "Atego 818",
						Year = 2007,
						Fuel = "Diesel",
						Power = 180,
						Transmission = "Manual Gearbox - 6",
						CylinderCapacity = 4249,
						Color = "White",
						Photo = "mercedes-benz",
						AvailableTruck = 7
					},
					new Truck
					{
						Id = 2,
						TruckNumber = 53112,
						Model = "Volvo",
						Type = "FH",
						Year = 2011,
						Fuel = "Diesel",
						Power = 600,
						Transmission = "Splitter and Range with automated gearchanging - 12 speed",
						CylinderCapacity = 12777,
						Color = "Metallic",
						Photo = "volvo-hp",
						AvailableTruck = 4
					}
				);
		}
	}
}
