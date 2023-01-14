using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Controllers;

[Route("api/categoryd/{id}/[controller]")]
[ApiController]
public class InstructorController : ControllerBase
{
	private readonly IInstructorService _instructorService;
	public InstructorController(IInstructorService instructorService)
	{
		_instructorService = instructorService;
	}
	[HttpGet("{instructorId}")]
	public async Task<IActionResult> Get([FromRoute] int id, [FromRoute] int instructorId) 
	{
		try
		{
			var instructor = await _instructorService.GetInstructorById(id, instructorId);
			return Ok(instructor);
		}
		catch(CategoryDException ex)
		{
			return NotFound(ex.Message);
		}
		catch (Exception)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, "Server Problem");
		}
	}
}