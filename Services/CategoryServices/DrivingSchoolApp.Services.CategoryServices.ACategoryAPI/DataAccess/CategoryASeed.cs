using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Enum;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess
{
	public static class CategoryASeed
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Lesson>()
				.HasData(
					new Lesson
					{
						Id = 1,
						Type = LessonTypes.Test,
						Price = 45.95,
						TestPrice= 10,
						Duration = 20,
						Description = $"First and foremost, before practical driving has theoretical knowledge. That's why we offer 20 hours of classroom theory with excellent instructors. The price is $45.95 including 2 possible tests. If you do not pass these 2 tests, you will be charged $10 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card is required and you must be over 18 years old."
					},
					new Lesson
					{
						Id = 2,
						Type = LessonTypes.Practise,
						Price = 54.95,
						TestPrice = 15,
						Duration = 40,
						VirtualPracticePrice = 24.5,
						LicenceDescription = "Light motorcycles with an engine size of up to 125 cc and a power output of up to 11 kW. Medium-sized motorcycles up to 25 kW and a power to weight ratio of up to 0.16 kW/kg. Motorcycles with a sidecar and a power to weight ratio of up to 0.16 kW/kg. Any size motorcycle, with or without a sidecar if you have completed the large motorcycle Direct Access Scheme",
						Description = $"You can continue with practical driving lessons if you have successfully passed or previously passed the theory test. The price is $54.95, you get 40 practical lessons with a highly qualified and experienced instructor that you choose yourself. Also engine of your choice. The price includes the right to take the test 3 times, and then it is $15 each.",												
					}
				); ;
			modelBuilder.Entity<CategoryA>()
				.HasData(
					new CategoryA
					{
						Id= 1,
						City = "Skopje",
						Address = "bul. ASNOM 12/A",
						Phone = "+389 01 222 110",						
					},
					new CategoryA
					{
						Id = 2,
						City = "Bitola",
						Address = "ul. Mirche Acev",
						Phone = "+389 21 334 667"
					},
					new CategoryA
					{
						Id = 3,
						City = "Stip",
						Address = "bul. JNA 120",
						Phone = "+389 01 554 2290",
					},
					new CategoryA
					{
						Id = 4,
						City = "Ohrid",
						Address = "ul. Marko Nestoroski 22",
						Phone = "+389 23 904 106"
					}
				);
			modelBuilder.Entity<CategoryLesson>()
				.HasData(
					new CategoryLesson
					{
						Id = 1,
						CategoryAId = 1,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 2,
						CategoryAId = 1,
						LessonId = 2,
					},
					new CategoryLesson
					{
						Id = 3,
						CategoryAId = 2,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 4,
						CategoryAId = 2,
						LessonId = 2,
					},
					new CategoryLesson
					{
						Id = 5,
						CategoryAId = 3,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 6,
						CategoryAId = 3,
						LessonId = 2,
					},
					new CategoryLesson
					{
						Id = 7,
						CategoryAId = 4,
						LessonId = 1,
					},
					new CategoryLesson
					{
						Id = 8,
						CategoryAId = 4,
						LessonId = 2,
					}
				);
			modelBuilder.Entity<Instructor>()
				.HasData(
					new Instructor
					{
						Id = 1,
						Firstname = "Dejan",
						Lastname = "Krstevski",
						Age= 30,
						LicenceId = "39ff30b1-c444-4c68-87ee-cc2aab3ea621",
						StartedDay = "05/23/2019",
						Experience = 7,
						CategoryAId= 1,
						isBooked= false
					},
					new Instructor
					{
						Id =2,
						Firstname = "Marija",
						Lastname = "Pavlova",
						Age = 43,
						LicenceId = "2ba87e71-1a1b-4457-9571-7d5603ffd5c9",
						StartedDay = "09/07/2018",
						CategoryAId = 1,
						Experience= 7, 
						isBooked = false
					},
					new Instructor
					{
						Id = 3,
						Firstname = "Marko",
						Lastname = "Polo",
						Age = 29,
						LicenceId = "28ea30a1-fab2-46f4-90aa-46306cbae26d",
						StartedDay = "03/30/2019",
						Experience= 3,
						CategoryAId = 1,
						isBooked = false
					},
					new Instructor
					{
						Id = 4,
						Firstname = "Kristijan",
						Lastname = "Spasevski",
						Age = 53,
						LicenceId = "7260b77a-9d58-45f5-99f5-4cd1cac42899",
						StartedDay = "10/06/1998",
						Experience = 14,
						CategoryAId = 2,
						isBooked = false
					},
					new Instructor
					{
						Id = 5,
						Firstname = "Asan",
						Lastname = "Sandokan",
						Age = 46,
						LicenceId = "6488955b-26e0-4ca2-9093-4b1794b8caca",
						StartedDay = "11/29/2017",
						Experience=	15,
						CategoryAId = 2,
						isBooked = false
					},
					new Instructor
					{
						Id = 6,
						Firstname = "Sergej",
						Lastname = "Cvetkovic",
						Age = 51,
						LicenceId = "962eb826-0fc8-4037-bb01-056a90e84257",
						StartedDay = "01/12/2004",
						Experience = 16,
						CategoryAId = 3,
						isBooked = false
					},
					new Instructor
					{
						Id = 7,
						Firstname = "Georgi",
						Lastname = "Hristov",
						Age = 57,
						LicenceId = "cdf71027-ecb5-4f6d-ba03-f7beb357ca84",
						StartedDay = "03/22/2005",
						Experience= 21,
						CategoryAId = 3,
						isBooked = true
					},
					new Instructor
					{
						Id = 8,
						Firstname = "Muarem",
						Lastname = "Muarem",
						Age = 32,
						LicenceId = "c2033c8b-78f3-4084-bb44-baaba228d8f2",
						StartedDay = "01/12/2020",
						Experience= 5,
						CategoryAId = 3,
						isBooked = false
					},
					new Instructor
					{
						Id = 9,
						Firstname = "Natasha",
						Lastname = "Sazdova",
						Age = 37,
						LicenceId = "c720c512-2187-42ba-bc6b-61474a2d9fba",
						StartedDay = "07/27/2021",
						Experience= 5,
						CategoryAId = 3,
						isBooked = false
					},
					new Instructor
					{
						Id = 10,
						Firstname = "Nomche",
						Lastname = "Nestor",
						Age = 42,
						LicenceId = "ea6c9280-de1a-4022-915c-3cc7e6e5b59c",
						StartedDay = "04/19/2007",
						Experience = 9,
						CategoryAId = 4,
						isBooked = false
					},
					new Instructor
					{
						Id = 11,
						Firstname = "Klime",
						Lastname = "Kajcev",
						Age = 55,
						LicenceId = "1f999c4b-da54-412f-893d-8663e58c12a3",
						StartedDay = "11/21/2009",
						Experience = 25,
						CategoryAId = 4,
						isBooked = false
					}
				);
			modelBuilder.Entity<Motorcycle>()
				.HasData(
					new Motorcycle
					{
						Id = 1,
						Type = "Ducati",
						Model = "Multistrada V4",
						Year= 2021,
						Fuel = 22,
						Capacity= 1158,
						Weight = 240,
						Speed= 155,
						Color = "Black & Gray",
						Photo = "ducati-031",
						AvailableMotorcycles = 3
					},
					new Motorcycle
					{
						Id = 2,
						Type = "BMW ",
						Model = "R 18",
						Year = 2020,
						Fuel = 16,
						Capacity = 1802,
						Weight = 345,
						Speed = 99,
						Color = "Metalic & Black",
						Photo = "bmwr18-274",
						AvailableMotorcycles = 6
					},
					new Motorcycle
					{
						Id = 3,
						Type = "Moto Guzzi",
						Model = "MGX 21",
						Year = 2016,
						Fuel = 20,
						Capacity = 1380,
						Weight = 314,
						Speed = 100,
						Color = "Black & Red",
						Photo = "moto-guzzi-mgx-21-176",
						AvailableMotorcycles = 4
					},
					new Motorcycle
					{
						Id = 4,
						Type = "Aprilia",
						Model = "Tuono 660",
						Year = 2021,
						Fuel = 5,
						Capacity = 659,
						Weight = 181,
						Speed = 230,
						Color = "Red & Black",
						Photo = "aprilia-073",
						AvailableMotorcycles = 5
					}
			);
			modelBuilder.Entity<MororsPerCity>()
				.HasData(
					new MororsPerCity
					{
						Id = 1,
						MotorcycleId = 1,
						CategoryAId = 1,
					},
					new MororsPerCity
					{
						Id = 2,
						MotorcycleId = 1,
						CategoryAId = 2,
					},
					new MororsPerCity
					{
						Id = 3,
						MotorcycleId = 1,
						CategoryAId = 3,
					},
					new MororsPerCity
					{
						Id = 4,
						MotorcycleId = 1,
						CategoryAId = 4,
					},
					new MororsPerCity
					{
						Id = 5,
						MotorcycleId = 2,
						CategoryAId = 1,
					},
					new MororsPerCity
					{
						Id = 6,
						MotorcycleId = 2,
						CategoryAId = 2,
					},
					new MororsPerCity
					{
						Id = 7,
						MotorcycleId = 2,
						CategoryAId = 3,
					},
					new MororsPerCity
					{
						Id = 8,
						MotorcycleId = 2,
						CategoryAId = 4,
					},
					new MororsPerCity
					{
						Id = 9,
						MotorcycleId = 3,
						CategoryAId = 1,
					},
					new MororsPerCity
					{
						Id = 10,
						MotorcycleId = 3,
						CategoryAId = 2,
					},
					new MororsPerCity
					{
						Id = 11,
						MotorcycleId = 3,
						CategoryAId = 3,
					},
					new MororsPerCity
					{
						Id = 12,
						MotorcycleId = 4,
						CategoryAId = 1,
					},
					new MororsPerCity
					{
						Id = 13,
						MotorcycleId = 4,
						CategoryAId = 2,
					},
					new MororsPerCity
					{
						Id = 14,
						MotorcycleId = 4,
						CategoryAId = 4,
					}
				);
		}
	}
}
