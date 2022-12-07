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
