using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces;
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

		/// <summary>
		///    Get all the cities where they offer category-B service.
		/// </summary>
		/// <returns>
		///    Status 200 with dto models if failed status 500 with ResponseError model,
		///	   with requiered message.
		/// </returns>
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

		/// <summary>
		///	   Get the city by id where they offer category-B service,
		///    include list of: Instructors, Lessons, Cars.
		/// </summary>
		/// <param name="id">city id type of integer</param>
		/// <returns>
		///    Status 200 with dto models. If failed, 
		///    status 404 if its not found,
		///    status 500 with ResponseError model,
		///    with requiered message.
		/// </returns>
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
