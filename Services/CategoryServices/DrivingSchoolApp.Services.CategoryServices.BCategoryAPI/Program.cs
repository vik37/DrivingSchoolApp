using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Repository;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Repository.Interface;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI
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
			services.AddControllers()
				.AddNewtonsoftJson(opt =>
					opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
				.AddNewtonsoftJson(opt =>
					opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver()); ;
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			services.AddDbContext<CategoryBDbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddTransient<IRepository<CategoryB>, CategoryBRepository>();

			services.AddTransient<ICategoryBService, CategoryBService>();

			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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