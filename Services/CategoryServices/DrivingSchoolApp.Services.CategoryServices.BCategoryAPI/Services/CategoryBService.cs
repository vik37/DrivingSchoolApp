using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Repository.Interface;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services
{
	public class CategoryBService : ICategoryBService
	{
		private readonly IRepository<CategoryB> _categoryBRepository;
		private readonly IMapper _mapper;
		public CategoryBService(IRepository<CategoryB> categoryBRepository,
									IMapper mapper)
		{
			_categoryBRepository = categoryBRepository;
			_mapper = mapper;
		}

		public async Task<IEnumerable<CategoryBDto>> GeAllFromCategoryB()
		{
			try
			{
				var categories = await _categoryBRepository.GetAll();
				return _mapper.Map<IEnumerable<CategoryB>, IEnumerable<CategoryBDto>>(categories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<CategoryBDto> GetFromCategoryBByID(int id)
		{
			try
			{
				var category = await _categoryBRepository.GetById(id);
				if (category == null)
					throw new CategoryBExceptions("This Category don't exist!");
				return _mapper.Map<CategoryBDto>(category);
			}
			catch(CategoryBExceptions ex)
			{
				throw new CategoryBExceptions(ex.Message);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
