using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces
{
	public interface ICategoryBService
	{
		Task<IEnumerable<CategoryBDto>> GeAllFromCategoryB();
		Task<CategoryBDto> GetFromCategoryBByID(int id);
	}
}
