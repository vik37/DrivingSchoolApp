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