using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.CategoryCSeeds
{
	public static class InstructorSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Instructor>()
				.HasData(
					new Instructor
					{
						Id= 1,
						Firstname = "Sasko",
						Lastname = "Savevski",
						Age= 40,
						LicenceId= "bdb105d4-7680-48be-95bc-ae08e8f98d69",
						StartedDay = "05/26/2018",
						TotalWorkExperience = 10,
						TotalDriveExperience= 21,
						TruckDriveExperience= 10,
						InstructorAcademy = "AMSM",
						isBooked= false,
						CategoryCId = 1
					},
					new Instructor
					{
						Id = 2,
						Firstname = "Krste",
						Lastname = "Panvov",
						Age = 44,
						LicenceId = "766b3746-3388-424b-a8bb-51361ad92968",
						StartedDay = "04/19/2017",
						TotalWorkExperience = 16,
						TotalDriveExperience = 22,
						TruckDriveExperience = 17,
						InstructorAcademy = "AMSM",
						isBooked = false,
						CategoryCId = 1
					},
					new Instructor
					{
						Id = 3,
						Firstname = "Tasko",
						Lastname = "Karanfilovski",
						Age = 47,
						LicenceId = "73b9547e-c1bb-4dff-b420-428756f5da01",
						StartedDay = "11/07/2018",
						TotalWorkExperience = 16,
						TotalDriveExperience = 24,
						TruckDriveExperience = 17,
						InstructorAcademy = "AMSM",
						isBooked = false,
						CategoryCId = 2
					}
				);
		}
	}
}
