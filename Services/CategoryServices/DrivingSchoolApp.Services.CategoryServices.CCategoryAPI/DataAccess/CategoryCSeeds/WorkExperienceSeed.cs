using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.CategoryCSeeds
{
	public static class WorkExperienceSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WorkExperience>()
				.HasData(
					new WorkExperience
					{
						Id= 1,
						Company = "Voznja Kumanovo",
						Experience=2,
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId= 3
					},
					new WorkExperience
					{
						Id = 2,
						Company = "Scania Skopje",
						Experience = 4,
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 1
					},
					new WorkExperience
					{
						Id = 3,
						Company = "Vardar Express Negotino",
						Experience = 7,
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 2
					},
					new WorkExperience
					{
						Id = 4,
						Company = "Polog Tetovo",
						Experience = 4,
						TypeOfWorkExperience = TypeOfWorkExperience.Instructor,
						InstructorId = 2
					},
					new WorkExperience
					{
						Id = 5,
						Company = "Vardar Express Negotino",
						Experience = 2,
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 3
					},
					new WorkExperience
					{
						Id = 6,
						Company = "Polog Tetovo",
						Experience = 5,
						TypeOfWorkExperience = TypeOfWorkExperience.Driver,
						InstructorId = 3
					},
					new WorkExperience
					{
						Id = 7,
						Company = "AAK Drive School Stip",
						Experience = 5,
						TypeOfWorkExperience = TypeOfWorkExperience.Instructor,
						InstructorId = 3
					}
				);
		}
	}
}
