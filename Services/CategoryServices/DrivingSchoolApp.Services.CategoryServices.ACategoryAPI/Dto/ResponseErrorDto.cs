﻿namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto
{
	public class ResponseErrorDto
	{
		public bool Success { get; set; } = false;
		public int Status { get; set; } = 500;
		public string Message { get; set; } = "Problem With Server";
	}
}
