using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			IConfiguration configuration = builder.Configuration;
			var services = builder.Services;

			// Add services to the container.
			services.AddCors(opt =>
			{
				opt.AddPolicy(name: "OnlyAngular",
					builder =>
					{
						builder.WithOrigins("http://localhost:4200/")
								.AllowAnyHeader()
								.AllowAnyMethod()
								.AllowCredentials();
					});
			});
			services.AddDbContext<CategoryCDbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddControllers()
				.AddNewtonsoftJson(opt =>
					opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
				.AddNewtonsoftJson(opt =>
					opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseCors("OnlyAngular");
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}