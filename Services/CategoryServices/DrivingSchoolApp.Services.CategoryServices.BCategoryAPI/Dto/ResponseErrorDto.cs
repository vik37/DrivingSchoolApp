namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto
{
	public class ResponseErrorDto
	{
		public int Status { get; set; } = 500;
		public string Message { get; set; } = "Problem With Server";
	}
}
