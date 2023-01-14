using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces
{
	public interface IInstructorService
	{
		Task<InstructorDto> GetInstructorById(int id, int instructorId);
	}
}
