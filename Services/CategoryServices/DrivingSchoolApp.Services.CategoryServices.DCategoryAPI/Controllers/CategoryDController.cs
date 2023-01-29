using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryDController : ControllerBase
{

	private readonly ICategoryDService _categoryDService;
	private ResponseErrorDto _response;

	public CategoryDController(ICategoryDService categoryDService) 
	{
		_categoryDService = categoryDService;
		_response= new ResponseErrorDto();
	}

	/// <summary>
	///    Get all the cities where they offer category-D service.
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
			var categories = await _categoryDService.GetAll();
			return Ok(categories);
		}
		catch (Exception)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, _response);
		}
	}

	/// <summary>
	///	   Get the city by id where they offer category-D service,
	///    include list of: Instructors, Lessons.
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
			var categories = await _categoryDService.GetById(id);
			return Ok(categories);
		}
		catch (CategoryDException ex)
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