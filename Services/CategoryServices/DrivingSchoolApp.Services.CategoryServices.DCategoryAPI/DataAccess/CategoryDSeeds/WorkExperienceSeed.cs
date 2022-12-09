using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.CategoryDSeeds
{
	public static class WorkExperienceSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WorkExperience>()
				.HasData(
					new WorkExperience
					{
						Id = 1,
						Experience = 2,
						Company = "Avast Tourist Skopje",
						TypeOfWorkExperience = TypeOfWorkExperience.Assistant,
						InstructorId = 1,
					},
					new WorkExperience
					{
						Id = 2,
						Experience = 5,
						Company = "JSP Skopje",
						TypeOfWorkExperience= TypeOfWorkExperience.Driver,
						InstructorId = 1
					},
					new WorkExperience
					{
						Id = 3,
						Experience = 7,
						Company = "Apollo Crid",
						TypeOfWorkExperience = TypeOfWorkExperience.Instructor,
						InstructorId = 1
					},
					new WorkExperience
					{
						Id = 4,
						Experience = 1,
						Company = "Fabula Travel Kicevo",
						TypeOfWorkExperience = TypeOfWorkExperience.Assistant,
						InstructorId = 2
					},
					new WorkExperience
					{
						Id = 5,
						Experience = 10,
						Company = "Fabula Travel Kicevo",
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 2
					},
					new WorkExperience 
					{
						Id = 6,
						Experience = 3,
						Company = "Febro Transit Skopje",
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 2
					},
					new WorkExperience 
					{
						Id = 7,
						Experience = 4,
						Company = "JUGO Transport Prilep",
						TypeOfWorkExperience = TypeOfWorkExperience.Assistant,
						InstructorId = 3
					},
					new WorkExperience 
					{ 
						Id = 8,
						Experience = 7,
						Company = "Prespa Turist Resen",
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 3
					},
					new WorkExperience 
					{ 
						Id = 9,
						Experience = 2,
						Company = "Vardar Travel Skopje",
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 3
					},
					new WorkExperience 
					{ 
						Id = 10,
						Experience = 8,
						Company = "Drive School Skopje",
						TypeOfWorkExperience = TypeOfWorkExperience.Instructor,
						InstructorId = 3
					},
					new WorkExperience 
					{ 
						Id= 11,
						Experience = 1,
						Company = "Stoby Travel Negotino",
						TypeOfWorkExperience = TypeOfWorkExperience.Assistant,
						InstructorId = 4
					},
					new WorkExperience
					{
						Id= 12,
						Experience = 6,
						Company = "Nekoj Travel Bitola",
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 4
					}
				);
		}
	}
}
