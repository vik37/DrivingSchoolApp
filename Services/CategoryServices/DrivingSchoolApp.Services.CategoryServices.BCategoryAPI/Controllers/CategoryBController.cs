using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryBController : ControllerBase
	{
		private readonly ICategoryBService _categoryBService;
		private ResponseErrorDto _response;
		public CategoryBController(ICategoryBService categoryBService)
		{
			_categoryBService= categoryBService;
			_response= new ResponseErrorDto();
		}
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				var categoryB = await _categoryBService.GeAllFromCategoryB();
				return Ok(categoryB);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Get([FromRoute] int id)
		{
			try
			{
				var category = await _categoryBService.GetFromCategoryBByID(id);
				return Ok(category);
			}
			catch(CategoryBExceptions ex)
			{
				_response.Status = 400;
				_response.Message = ex.Message;
				return BadRequest(_response);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}
	}
}
