using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess;
using Microsoft.EntityFrameworkCore;

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
						builder.WithOrigins("http://localhost:4200/")
								.AllowAnyHeader()
								.AllowAnyMethod()
								.AllowCredentials();
					});
			});

			services.AddDbContext<CategoryDDbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddControllers();
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