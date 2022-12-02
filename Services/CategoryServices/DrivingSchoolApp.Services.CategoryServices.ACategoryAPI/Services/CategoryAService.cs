using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository.Interface;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto.Models;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Services.Interfaces;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Services
{
	public class CategoryAService : ICategoryAService
	{
		private readonly IRepository<CategoryA> _categoryARepo;
		private readonly IMapper _mapper;
		public CategoryAService(IRepository<CategoryA> categoryARepo, IMapper mapper)
		{
			_categoryARepo = categoryARepo;
			_mapper = mapper;
		}
		public async Task<IEnumerable<CategoryADto>> GetAllFromCategoryA()
		{
			try
			{
				var cagegories = await _categoryARepo.GetAll();
				return _mapper.Map<IEnumerable<CategoryA>, IEnumerable<CategoryADto>>(cagegories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<CategoryADto> GetFromCategoryAByID(int id)
		{
			try
			{
				var category = await _categoryARepo.GetById(id);
				if (category == null)
					throw new CategoryAException("This Category don't exist!");
				return _mapper.Map<CategoryADto>(category);
			}
			catch(CategoryAException ex)
			{
				throw new CategoryAException(ex.Message);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
