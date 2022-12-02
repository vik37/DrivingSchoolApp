﻿namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities
{
	public class CategoryB : Base
	{
		public string City { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public IEnumerable<CategoryLesson> CategoryLessons { get; set; } = new List<CategoryLesson>();
		public IEnumerable<Instructor> Instructors { get; set; } = new List<Instructor>();
		public IEnumerable<CarPerCity> MotorcyclePerCity { get; set; } = new List<CarPerCity>();
	}
}
