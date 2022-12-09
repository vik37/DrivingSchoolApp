using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.CategoryDSeeds
{
	public static class InstructorSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Instructor>()
				.HasData(
					new Instructor
					{
						Id = 1,
						Firstname = "Nikola",
						Lastname = "Savov",
						Age = 51,
						LicenceId = "ad618ebc-b5f2-46c2-bec6-1d130e6428ab",
						StartedDay = "19/11/2017",
						TotalWorkExperience = 19,
						TotalDriveExperience = 28,
						BusDriveExperience = 21,
						InstructorAcademy = "AMSM",
						isBooked = true,
						CategoryDId = 1
					},
					new Instructor
					{
						Id = 2,
						Firstname = "Ramazan",
						Lastname = "Serbezovski",
						Age =47,
						LicenceId = "e364ea17-318e-42ce-b02d-bc396c2f1c78",
						StartedDay = "09/10/2019",
						TotalWorkExperience = 17,
						TotalDriveExperience = 28,
						BusDriveExperience = 18,
						InstructorAcademy = "AMSM",
						isBooked = false,
						CategoryDId = 1
					},
					new Instructor
					{
						Id = 3,
						Firstname = "Risto",
						Lastname = "Shihkov",
						Age = 54,
						LicenceId = "14eafc97-8a48-4bd0-988b-2478ea3db2a4",
						StartedDay = "25/04/2014",
						TotalWorkExperience = 29,
						TotalDriveExperience = 35,
						BusDriveExperience = 29,
						InstructorAcademy = "AMSM",
						isBooked = false,
						CategoryDId = 2
					},
					new Instructor
					{
						Id = 4,
						Firstname = "Aleksandar",
						Lastname = "Temelkov",
						Age = 39,
						LicenceId = "7cf56071-de16-4323-82f9-f50602b02578",
						StartedDay = "05/02/2021",
						TotalWorkExperience = 8,
						TotalDriveExperience = 21,
						BusDriveExperience = 9,
						InstructorAcademy = "Asvalt Bitola",
						isBooked = false,
						CategoryDId = 2
					}
				);
		}
	}
}
