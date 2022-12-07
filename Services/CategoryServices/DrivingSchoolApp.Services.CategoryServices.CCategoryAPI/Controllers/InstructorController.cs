using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Controllers
{
	[Route("api/CategoryC/[controller]")]
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
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			try
			{
				var instructor = await _instructorService.GetInstructorById(id);
				return Ok(instructor);
			}
			catch(CategoryCException ex)
			{
				_response.Message = ex.Message;
				_response.Status = StatusCodes.Status404NotFound;
				return NotFound(_response);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,_response);
			}
		}
	}
}
