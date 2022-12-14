using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryDController : ControllerBase
{
	private readonly ICategoryDService _categoryDService;
	public CategoryDController(ICategoryDService categoryDService) 
	{
		_categoryDService = categoryDService;
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
			return StatusCode(StatusCodes.Status500InternalServerError, "Server Problem");
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
			return NotFound(ex.Message);
		}
		catch (Exception)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, "Server Problem");
		}
	}
}