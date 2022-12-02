﻿using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities
{
	public class Lesson : Base
	{
		public LessonTypes Type { get; set; }
		public double Price { get; set; }
		public double TestPrice { get; set; }
		public string Description { get; set; }
		public string LicenceDescription { get; set; }
		public int Duration { get; set; }
		public double? VirtualPracticePrice { get; set; }
		public int? Discount { get; set; }
		public IEnumerable<CategoryLesson> CategoryLessons { get; set; } = new List<CategoryLesson>();
	}
}
