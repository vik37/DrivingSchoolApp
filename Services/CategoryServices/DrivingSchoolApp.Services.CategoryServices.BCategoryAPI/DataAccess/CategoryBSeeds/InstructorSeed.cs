using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.CategoryBSeeds
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
						Firstname = "Davor",
						Lastname = "Shurjak",
						Age = 41,
						LicenceId = "c49f5ef9-12b0-43d5-b642-0c6a41e9ca4b",
						StartedDay = "04/19/2009",
						TotalWorkExperience = 14,
						DriveExperience = 21,
						InstructorAcademy = "AMSMS",
						isBooked = false,
						CategoryBId= 1,
					},
					new Instructor
					{
						Id = 2,
						Firstname = "Tatjana",
						Lastname = "Crvenkovska",
						Age = 37,
						LicenceId = "df0b96c7-0016-44c2-b75e-770ab9d43c4c",
						StartedDay = "10/31/2015",
						TotalWorkExperience = 7,
						DriveExperience = 18,
						InstructorAcademy = "AMSMS",
						isBooked = false,
						CategoryBId= 1,
					},
					new Instructor
					{
						Id = 3,
						Firstname = "Toni",
						Lastname = "Zajkov",
						Age = 52,
						LicenceId = "962e96d6-5017-4bef-bd32-7ae1af381c42",
						StartedDay = "07/01/1997",
						TotalWorkExperience = 25,
						DriveExperience = 34,
						InstructorAcademy = "InstructorsMKD Company",
						isBooked = true,
						CategoryBId = 1
					},
					new Instructor
					{
						Id = 4,
						Firstname = "Sasa",
						Lastname = "Ciric",
						Age = 37,
						LicenceId = "96963be0-3157-4e29-ae95-333969bdce05",
						StartedDay = "07/17/2017",
						TotalWorkExperience = 5,
						DriveExperience = 9,
						InstructorAcademy = "AMSMS",
						isBooked = true,
						CategoryBId = 1
					},
					new Instructor
					{
						Id = 5,
						Firstname = "Metodija",
						Lastname = "Spasovski",
						Age = 31,
						LicenceId = "3f362685-b8b0-4fa3-aa96-1b1c700e4d31",
						StartedDay = "29/01/2021",
						TotalWorkExperience = 5,
						DriveExperience = 8,
						InstructorAcademy = "InstructorsMKD Company",
						isBooked = false,
						CategoryBId = 1
					},
					new Instructor
					{
						Id = 6,
						Firstname = "Filip",
						Lastname = "Ristoski",
						Age = 41,
						LicenceId = "083d6982-6234-4553-934f-e75f2b58b921",
						StartedDay = "29/01/2019",
						TotalWorkExperience = 15,
						DriveExperience = 18,
						InstructorAcademy = "Oslomej Kicevo",
						isBooked = false,
						CategoryBId = 2
					},
					new Instructor
					{
						Id = 7,
						Firstname = "Maida",
						Lastname = "Musandra",
						Age = 58,
						LicenceId = "1985be12-6bf4-4063-bf23-56498d029225",
						StartedDay = "12/08/2006",
						TotalWorkExperience = 34,
						DriveExperience = 40,
						InstructorAcademy = "AMSM",
						isBooked = false,
						CategoryBId = 2
					},
					new Instructor
					{
						Id = 8,
						Firstname = "Kristina",
						Lastname = "Neagu",
						Age = 51,
						LicenceId = "51a01164-2e9b-423e-bb57-c4286695caf0",
						StartedDay = "26/05/2012",
						TotalWorkExperience = 29,
						DriveExperience = 30,
						InstructorAcademy = "AMSM",
						isBooked = false,
						CategoryBId = 2
					},
					new Instructor
					{
						Id = 9,
						Firstname = "Marko",
						Lastname = "Mojsov",
						Age = 29,
						LicenceId = "9d613151-ac1a-4bb5-a9cb-a34de1c55153",
						StartedDay = "02/02/2017",
						TotalWorkExperience = 5,
						DriveExperience = 11,
						InstructorAcademy = "AMSM",
						isBooked = false,
						CategoryBId = 2
					},
					new Instructor
					{
						Id = 10,
						Firstname = "Cedo",
						Lastname = "Janevski",
						Age = 41,
						LicenceId = "b1952570-ecd5-4f14-9cce-4968a2d7c296",
						StartedDay = "02/02/2017",
						TotalWorkExperience = 16,
						DriveExperience = 20,
						InstructorAcademy = "AS Vardar",
						isBooked = false,
						CategoryBId = 3
					},
					new Instructor
					{
						Id = 11,
						Firstname = "Pere",
						Lastname = "Tosev",
						Age = 37,
						LicenceId = "9a05d276-9516-4349-be19-3c7dfa79fa81",
						StartedDay = "03/19/2019",
						TotalWorkExperience = 8,
						DriveExperience = 18,
						InstructorAcademy = "ASMS",
						isBooked = false,
						CategoryBId = 3
					},
					new Instructor
					{
						Id = 12,
						Firstname = "Petar",
						Lastname = "Milosevski",
						Age = 28,
						LicenceId = "748cf5dd-67f6-4fae-a816-9d8aa067019d",
						StartedDay = "03/19/2018",
						TotalWorkExperience = 4,
						DriveExperience = 10,
						InstructorAcademy = "ASMS",
						isBooked = false,
						CategoryBId = 4
					},
					new Instructor
					{
						Id = 13,
						Firstname = "Sabri",
						Lastname = "Asan",
						Age = 35,
						LicenceId = "9d297b8a-0f70-43bd-ba7c-154a2ea54f53",
						StartedDay = "03/19/2020",
						TotalWorkExperience = 5,
						DriveExperience = 10,
						InstructorAcademy = "AS Vardar",
						isBooked = false,
						CategoryBId = 4
					},
					new Instructor
					{
						Id = 14,
						Firstname = "Klimentina",
						Lastname = "Rasko",
						Age = 32,
						LicenceId = "c2c5c12c-b37e-4fa5-9552-c1c48a7a8e86",
						StartedDay = "03/19/2014",
						TotalWorkExperience = 9,
						DriveExperience = 14,
						InstructorAcademy = "Biljanini Izvori",
						isBooked = false,
						CategoryBId = 4
					}
				);
		}
	}
}
