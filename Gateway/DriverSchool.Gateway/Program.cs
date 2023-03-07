
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Values;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddCors(opt => { opt.AddPolicy(name: "CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); });
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
IConfiguration configuration = builder.Configuration
								.AddJsonFile("ocelot.json",optional: false,reloadOnChange: true)
								.Build();
builder.Services.AddAuthentication("Bearer")
	.AddJwtBearer("Bearer", opt =>
	{
		opt.Authority = "https://localhost:44326";
		opt.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateAudience = false
		};

    });

builder.Services.AddOcelot(configuration);

var app = builder.Build();
//app.UseCors("CorsPolicy");
app.UseCors("OnlyAngular");
await app.UseOcelot();

app.Run();
