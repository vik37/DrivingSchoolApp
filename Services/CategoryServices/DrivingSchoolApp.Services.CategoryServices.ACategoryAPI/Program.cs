using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess;
using Microsoft.EntityFrameworkCore;

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

			services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();
			services.AddDbContext<CategoryADbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

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