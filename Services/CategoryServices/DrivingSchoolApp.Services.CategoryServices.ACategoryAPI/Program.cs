using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var services = builder.Services;

			IConfiguration configuration = builder.Configuration;

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

			services.AddControllers()
				.AddNewtonsoftJson(opt =>
					opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
				.AddNewtonsoftJson(opt =>
					opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver()); ;
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();
			services.AddDbContext<CategoryADbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddTransient<IRepository<CategoryA>, CategoryARepo>();

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