namespace DrivingSchool.FileServiceAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddCors(opt =>
			{
				opt.AddPolicy(name: "OnlyAngular",
					builder =>
					{
						builder.WithOrigins("http://localhost:4200", "https://localhost:4200")
								.AllowAnyHeader()
								.AllowAnyMethod()
								.AllowCredentials();
					});
			});

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