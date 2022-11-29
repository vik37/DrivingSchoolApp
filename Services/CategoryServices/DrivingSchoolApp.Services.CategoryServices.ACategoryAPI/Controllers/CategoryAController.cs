using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryAController : ControllerBase
	{
		private readonly IRepository<CategoryA> _categoryARepo;
		public CategoryAController(IRepository<CategoryA> categoryARepo)
		{
			_categoryARepo = categoryARepo;
		}
		[HttpGet]
		public IActionResult Get()
		{
			var model = _categoryARepo.GetAll();
			return Ok(model);
		}
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			try
			{
				var model = _categoryARepo.GetById(id);
				return Ok(model);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
