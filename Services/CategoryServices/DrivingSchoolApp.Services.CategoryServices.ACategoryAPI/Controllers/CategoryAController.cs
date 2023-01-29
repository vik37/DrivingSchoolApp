using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Services.Interfaces;
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

		/// <summary>
		///    Get all the cities where they offer category-A service.
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
				var category = await _categoryAService.GetAllFromCategoryA();
				return Ok(category);
			}
			catch (Exception)
			{
				// ex.Message for logger... 
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}

		/// <summary>
		///	   Get the city by id where they offer category-A service,
		///    include list of: Instructors, Lessons, Motorcycles.
		/// </summary>
		/// <param name="id">city id type of integer</param>
		/// <returns>
		///    Status 200 with dto models. 
		///    If failed, 
		///    status 404 if its not found,
		///    status 500 with ResponseError model,
		///    with requiered message.
		/// </returns>
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			try
			{
				var category = await _categoryAService.GetFromCategoryAByID(id);
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
