using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository.Interfaces;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI
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
						builder.WithOrigins(ConnectionUrls.ClientUrl(configuration)["http"], ConnectionUrls.ClientUrl(configuration)["https"])
								.AllowAnyHeader()
								.AllowAnyMethod()
								.AllowCredentials();
					});
			});

			services.AddDbContext<CategoryDDbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddTransient<IRepository<CategoryD>, CategoryDRepository>();
			services.AddTransient<IInstructorRepository,InstructorRepository>();

			services.AddTransient<ICategoryDService,CategoryDService>();
			services.AddTransient<IInstructorService,InstructorService>();

			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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