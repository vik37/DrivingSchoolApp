using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;

public interface ICategoryDService
{
	Task<IEnumerable<CategoryDDto>> GetAll();
	Task<CategoryDDto> GetById(int id);
}