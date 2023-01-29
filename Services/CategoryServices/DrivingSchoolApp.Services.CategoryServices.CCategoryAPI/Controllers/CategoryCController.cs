using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryCController : ControllerBase
	{
		private readonly ICategoryCService _categoryCService;
		private ResponseErrorDto _response;
		public CategoryCController(ICategoryCService categoryCService)
		{
			_categoryCService = categoryCService;
			_response = new ResponseErrorDto();
		}

		/// <summary>
		///    Get all the cities where they offer category-C service.
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
				var categoris = await _categoryCService.GetAll();
				return Ok(categoris);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}

		/// <summary>
		///	   Get the city by id where they offer category-C service,
		///    include list of: Instructors, Lessons, Trucks.
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
		public async Task<ActionResult> Get(int id)
		{
			try
			{
				var category = await _categoryCService.GetById(id);
				return Ok(category);
			}
			catch (CategoryCException ex)
			{
				_response.Message = ex.Message;
				_response.Status = StatusCodes.Status404NotFound;
				return NotFound(_response);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}
	}
}
