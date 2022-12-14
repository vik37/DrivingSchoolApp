using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;

public interface IInstructorService
{
	Task<InstructorDto> GetInstructorById(int id);
}