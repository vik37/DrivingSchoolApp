using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.CategoryCSeeds
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
						Price = 89.95,
						TestPrice = 15,
						Duration = 40,
						Description = $"First and foremost, before practical driving has theoretical knowledge. That's why we offer 30 hours of classroom theory with excellent instructors. The price is $89.95 including 3 possible tests. If you don't pass these 3 tests, you will be charged $15 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card or passport is required, you must be over 21 years old, medical certificate for \"C\" category. It's also mandatory to have previously taken \"B\" category."
					},
					new Lesson
					{
						Id = 2,
						Type = LessonTypes.Polygon,
						Price = 141.55,
						TestPrice = 25,
						Duration = 60,
						VirtualPracticePrice = 24.5,
						Discount = 15,
						Description = $"You can continue with driving lessons on Polygon if you have successfully passed or previously passed the theory test. The price is $141.55$, you get 60 practical lessons at the polygon with a highly qualified and experienced instructor that you choose yourself. Also truck of your choice. The price includes the right to take the test 3 times, and then it is $25 each. If you want, you can use a virtual 3D drive-car simulator way of training just for 24.5. Currently, Only in Skopje and Shtip we have the opportunity for C category training.",
					},
					new Lesson
					{
						Id = 3,
						Type = LessonTypes.City,
						Price = 170.00,
						TestPrice = 35,
						Duration = 70,
						Discount = 20,
						LicenceDescription = "Drivers of this category of vehicles tend to do more local deliveries than large vehicles.  A category C license allows drivers to drive vehicles over 3.5 tonnes, but must not exceed 32 tonnes. Category C (or Class 2 as they are otherwise known) licences typically cover a vehicle with a cab and trailer fixed permanently together. In other words, what we would consider a ‘standard lorry’ or a rigid vehicle.",
						Description = $"The last classes before the opportunity to apply for a license are city driving classes and the test. The price is $170.00, you get 70 practical lessons with a highly qualified and experienced instructor that you choose yourself. Also truck of your choice. The price includes the right to take the test 3 times, and then it is $35 each.",
					}
				);
		}
	}
}
