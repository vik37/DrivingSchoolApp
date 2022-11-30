using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository.Interface;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryAController : ControllerBase
	{
		private readonly ICategoryAService _categoryAService;
		private ResponseErrorDto _response;
		public CategoryAController(ICategoryAService categoryAService)
		{
			_categoryAService = categoryAService;
			_response= new ResponseErrorDto();
		}
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				var category = await _categoryAService.GetAllCategories();
				return Ok(category);
			}
			catch (Exception)
			{
				// ex.Message for logger... 
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			try
			{
				var category = await _categoryAService.GetCategoryByID(id);
				return Ok(category);
			}
			catch(CategoryAException ex)
			{
				_response.Status = 404;
				_response.Message = ex.Message;
				return NotFound(_response);
			}
			catch (Exception)
			{
				// ex.Message for logger... 
				return StatusCode(StatusCodes.Status500InternalServerError,_response);
			}
		}
	}
}
