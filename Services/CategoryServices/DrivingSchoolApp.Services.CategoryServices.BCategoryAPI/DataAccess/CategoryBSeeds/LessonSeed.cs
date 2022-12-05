using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.CategoryBSeeds
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
						Price = 65.45,
						TestPrice = 10,
						Duration = 30,
						Description = $"First and foremost, before practical driving has theoretical knowledge. That's why we offer 30 hours of classroom theory with excellent instructors. The price is $65.45 including 2 possible tests. If you don't pass these 2 tests, you will be charged $10 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card or passport is required, you must be over 18 years old, medical certificate for \"B\" category."
					},
					new Lesson
					{
						Id = 2,
						Type = LessonTypes.Polygon,
						Price = 127.95,
						TestPrice = 20,
						Duration = 50,
						VirtualPracticePrice = 24.5,
						Discount = 15,
						Description = $"You can continue with driving lessons on Polygon if you have successfully passed or previously passed the theory test. The price is $127.95, you get 50 practical lessons at the polygon with a highly qualified and experienced instructor that you choose yourself. Also car of your choice. The price includes the right to take the test 3 times, and then it is $20 each. If you want, you can use a virtual 3D drive-car simulator way of training just for 24.5",
					},
					new Lesson
					{
						Id = 3,
						Type = LessonTypes.City,
						Price = 159.95,
						TestPrice = 25,
						Duration = 60,
						Discount = 20,
						LicenceDescription = "B category - vehicles with a maximum mass not exceeding 3500 kg and seats, excluding the driver's seat, not exceeding 8 seats. The driving license of the categories can be obtained reaching the age of 18. Necessary conditions are to complete a training at driving school and passing the theoretical and driving tests.",
						Description = $"The last classes before the opportunity to apply for a license are city driving classes and the test. The price is $159.95, you get 60 practical lessons with a highly qualified and experienced instructor that you choose yourself. Also car of your choice. The price includes the right to take the test 3 times, and then it is $15 each.",
					}
				);
		}
	}
}
