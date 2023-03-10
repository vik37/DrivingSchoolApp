
using DriverSchool.Gateway;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Values;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.AddCors(opt =>
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
configuration = builder.Configuration
								.AddJsonFile("ocelot.json",optional: false,reloadOnChange: true)
								.Build();
builder.Services.AddAuthentication("Bearer")
	.AddJwtBearer("Bearer", opt =>
	{
		opt.Authority = ConnectionUrls.IdentityServer(configuration)["iisUrl"];
		opt.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateAudience = false
		};
    });

builder.Services.AddOcelot(configuration);

var app = builder.Build();
app.UseCors("OnlyAngular");
await app.UseOcelot();

app.Run();
