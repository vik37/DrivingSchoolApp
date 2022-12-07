using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services.Interfaces
{
	public interface ICategoryCService
	{
		Task<IEnumerable<CategoryCDto>> GetAll();
		Task<CategoryCDto> GetById(int id);
	}
}
