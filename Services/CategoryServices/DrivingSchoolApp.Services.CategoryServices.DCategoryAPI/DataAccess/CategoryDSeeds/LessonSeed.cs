using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.CategoryDSeeds
{
	public static class LessonSeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Lesson>()
				.HasData(
					new Lesson
					{
						Id = 1,
						Type = LessonTypes.Theory,
						Price = 110.45,
						TestPrice = 20,
						Duration = 50,
						Description = $"First and foremost, before practical driving has theoretical knowledge. That's why we offer 50 hours of classroom theory with excellent instructors. The price is $110.45 including 3 possible tests. If you don't pass these 3 tests, you will be charged $20 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card or passport is required, you must be over 21 years old, medical certificate for \"D\" category. It's also mandatory to have previously taken \"C\" category."
					},
					new Lesson
					{
						Id = 2,
						Type = LessonTypes.Psichologic,
						Price = 5,
						TestPrice = 1,
						Duration = 15,
						Description = "In addition to as part of a medical examination where there is always a psychological test, an additional 15 hours of psychological training have been introduced on our part because we consider it a big responsibility to transport passengers by motor vehicle, i.e. bus. The minimum price is $5, and the test after 4 trials is charged $1 each. This class and test is mandatory before proceeding further with a polygon."
					},
					new Lesson
					{
						Id = 3,
						Type = LessonTypes.Polygon,
						Price = 179.45,
						TestPrice = 35,
						Duration = 70,
						VirtualPracticePrice = 24.5,
						Discount = 15,
						Description = $"You can continue with driving lessons on Polygon if you have successfully passed or previously passed the theory test. The price is $179.45$, you get 70 practical lessons at the polygon with a highly qualified and experienced instructor that you choose yourself. The price includes the right to take the test 3 times, and then it is $35 each. If you want, you can use a virtual 3D drive-car simulator way of training just for 24.5. Currently, Only in Skopje and Bitola we have the opportunity for D category training.",
					},
					new Lesson
					{
						Id = 4,
						Type = LessonTypes.City,
						Price = 215.95,
						TestPrice = 45,
						Duration = 90,
						Discount = 20,
						LicenceDescription = "Different driver's licenses can be used to operate different classes of vehicles. The most common is the passenger (Class D) license, which allows you to legally operate a passenger vehicle. Motor vehicles which are constructed and designed for the carriage of more than 8 passengers in addition to the driver, with or without a trailer with a maximum authorized mass not exceeding 750 kg.",
						Description = $"The last classes before the opportunity to apply for a license are city driving classes and the test. The price is $215.95, you get 90 practical lessons with a highly qualified and experienced instructor that you choose yourself. The price includes the right to take the test 3 times, and then it is $45 each.",
					}
				);
		}
	}
}
