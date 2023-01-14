using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Controllers
{
	[Route("api/categoryb/{id}/[controller]")]
	[ApiController]
	public class InstructorController : ControllerBase
	{
		private readonly IInstructorService _instructorService;
		private ResponseErrorDto _response;
		public InstructorController(IInstructorService instructorService)
		{
			_instructorService = instructorService;
			_response = new ResponseErrorDto();
		}
		[HttpGet("{instructorId}")]
		public async Task<IActionResult> Get([FromRoute] int id,[FromRoute]int instructorId)
		{
			try
			{
				var instructor = await _instructorService.GetInstructorById(id,instructorId);
				return Ok(instructor);
			}
			catch (CategoryBExceptions ex)
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
