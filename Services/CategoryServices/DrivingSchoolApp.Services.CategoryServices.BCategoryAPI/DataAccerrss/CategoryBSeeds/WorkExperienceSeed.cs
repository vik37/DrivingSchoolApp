using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.CategoryBSeeds
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
						Company = "Skopje Drive School",
						Experience = 1,
						InstructorId = 1
					},
					new WorkExperience
					{
						Id = 2,
						Company = "Skorpion Skopje",
						Experience = 4,
						InstructorId = 5
					},
					new WorkExperience
					{
						Id = 3,
						Company = "IKO Kumanovo",
						Experience = 3,
						InstructorId = 6,
					},
					new WorkExperience
					{
						Id = 4,
						Company = "Auto Akademik Skopje",
						Experience = 9,
						InstructorId = 6,
					},
					new WorkExperience
					{
						Id = 5,
						Company = "Skoda Drive Kavadarci",
						Experience = 4,
						InstructorId = 7,
					},
					new WorkExperience
					{
						Id = 6,
						Company = "Tikvesh Kavadarci",
						Experience = 8,
						InstructorId = 7,
					},
					new WorkExperience
					{
						Id = 7,
						Company = "AMSM",
						Experience = 12,
						InstructorId = 7,
					},
					new WorkExperience
					{
						Id = 8,
						Company = "Skorpion Skopje",
						Experience = 1,
						InstructorId = 8,
					},
					new WorkExperience
					{
						Id = 9,
						Company = "Labud Struga",
						Experience = 5,
						InstructorId = 8,
					},
					new WorkExperience
					{
						Id = 10,
						Company = "Krap Dojran",
						Experience = 2,
						InstructorId = 8,
					},
					new WorkExperience
					{
						Id = 11,
						Company = "Roza Skopje",
						Experience = 9,
						InstructorId = 8,
					},
					new WorkExperience
					{
						Id = 12,
						Company = "Roza Skopje",
						Experience = 2,
						InstructorId = 10,
					},
					new WorkExperience
					{
						Id = 13,
						Company = "Roza Skopje",
						Experience = 9,
						InstructorId = 10,
					},
					new WorkExperience
					{
						Id = 14,
						Company = "Auto Zelka Skopje",
						Experience = 5,
						InstructorId = 11,
					}
				);
		}
	}
}
