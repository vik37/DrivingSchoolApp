using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Controllers;

[Route("api/categoryd/{id}/[controller]")]
[ApiController]
public class InstructorController : ControllerBase
{
	private readonly IInstructorService _instructorService;
	private ResponseErrorDto _response;
	public InstructorController(IInstructorService instructorService)
	{
		_instructorService = instructorService;
		_response= new ResponseErrorDto();
	}
	[HttpGet("{instructorId}")]
	public async Task<IActionResult> Get([FromRoute] int id, [FromRoute] int instructorId) 
	{
		try
		{
			var instructor = await _instructorService.GetInstructorById(id, instructorId);
			return Ok(instructor);
		}
		catch (CategoryDException ex)
		{
			_response.Message = ex.Message;
			_response.Status = StatusCodes.Status404NotFound;
			return NotFound(_response);
		}
		catch (Exception)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, "Server Problem");
		}
	}
}