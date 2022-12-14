using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository.Interfaces;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services;

public class CategoryDService : BaseService, ICategoryDService
{
	private readonly IRepository<CategoryD> _categoryDRepo;
	public CategoryDService(IMapper mapper, IRepository<CategoryD> categoryDRepo) : base(mapper)
	{ 
		_categoryDRepo = categoryDRepo;
	}

	public async Task<IEnumerable<CategoryDDto>> GetAll()
	{
		try
		{
			var categories = await _categoryDRepo.GetAll();
			return _mapper.Map<IEnumerable<CategoryD>,IEnumerable<CategoryDDto>>(categories);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	public async Task<CategoryDDto> GetById(int id)
	{
		try
		{
			var category = await _categoryDRepo.GetById(id);
			if (category == null)
				throw new CategoryDException("Category does not exist");
			return _mapper.Map<CategoryDDto>(category);
		}
		catch(CategoryDException ex)
		{
			throw new CategoryDException(ex.Message);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}
}