using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto.Models;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Services.Interfaces
{
	public interface ICategoryAService
	{
		Task<IEnumerable<CategoryADto>> GetAllCategories();
		Task<CategoryADto> GetCategoryByID(int id);
	}
}
