using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services.Interfaces
{
	public interface IInstructorService
	{
		Task<InstructorDto> GetInstructorById(int id);
	}
}
