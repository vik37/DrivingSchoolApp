using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchool.FileServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImageController : ControllerBase
	{
		private readonly IWebHostEnvironment _webHostEnvironment;
		public ImageController(IWebHostEnvironment webHostEnvironment)
		{
			_webHostEnvironment = webHostEnvironment;
		}
		[HttpGet("{type}/{filename}")]
		public IActionResult Get([FromRoute] string type, [FromRoute] string filename)
		{
			try
			{
				string path = _webHostEnvironment.WebRootPath + $"\\photo\\{type}\\";
				var filePath = path + filename + ".jpg";
				if (System.IO.File.Exists(filePath))
				{
					byte[] bt = System.IO.File.ReadAllBytes(filePath);
					return File(bt, "image/jpg");
				}
				return null;
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Server Problem");
			}
		}
	}
}
