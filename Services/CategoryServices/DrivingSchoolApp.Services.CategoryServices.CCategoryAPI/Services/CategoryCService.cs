using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Repository.Interfaces;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services.Interfaces;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services; 

public class CategoryCService : BaseService, ICategoryCService 
{ 
	private readonly IRepository<CategoryC> _categoryCRepository; 
	public CategoryCService(IRepository<CategoryC> categoryCRepository, 
							IMapper mapper) 
							: base(mapper) 
	{ 
		_categoryCRepository = categoryCRepository; 
	} 
	public async Task<IEnumerable<CategoryCDto>> GetAll() 
	{
		try 
		{ 
			var categories = await _categoryCRepository.GetAll(); 
			return _mapper.Map<IEnumerable<CategoryC>, IEnumerable<CategoryCDto>>(categories); 
		
		} 
		catch (Exception ex) 
		{ 
			throw new Exception(ex.Message); 
		} 
	} 
	public async Task<CategoryCDto> GetById(int id) 
	{
		try 
		{ 
			var category = await _categoryCRepository.GetById(id); 
			if (category == null) 
				throw new CategoryCException("This category does not exist"); 
			return _mapper.Map<CategoryCDto>(category); 
		} 
		catch (CategoryCException ex) 
		{ 
			throw new CategoryCException(ex.Message); 
		} 
		catch (Exception ex) 
		{ 
			throw new Exception(ex.Message); 
		} 
	} 
}