using DrivingSchoolApp.RegisterMVC.DataAccess;
using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.RegisterInitializer;
using DrivingSchoolApp.RegisterMVC.DataAccess.RegisterInitializer.Interfaces;
using DrivingSchoolApp.RegisterMVC.DataAccess.Repository;
using DrivingSchoolApp.RegisterMVC.DataAccess.Repository.Interface;
using DrivingSchoolApp.RegisterMVC.Helper;
using DrivingSchoolApp.RegisterMVC.Helper.DuendeIdentityServer;
using Duende.IdentityServer.AspNetIdentity;
using DrivingSchoolApp.RegisterMVC.Services;
using Duende.IdentityServer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.Configure<CookiePolicyOptions>(options =>
{
	options.CheckConsentNeeded= context => true;
	options.MinimumSameSitePolicy = SameSiteMode.None;
});
services.AddDbContext<DrivingSchoolRegisterDbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
					x => x.MigrationsAssembly("DrivingSchoolApp.RegisterMVC")));
services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
	options.Password.RequiredLength = 8;
	options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<DrivingSchoolRegisterDbContext>()
.AddDefaultTokenProviders();

var identityBuilder = services.AddIdentityServer(opt =>
		{
			opt.Events.RaiseErrorEvents = true;
			opt.Events.RaiseFailureEvents = true;
			opt.Events.RaiseSuccessEvents = true;
			opt.Events.RaiseInformationEvents = true;
			opt.EmitStaticAudienceClaim = true;
		})
			.AddInMemoryIdentityResources(IdentityServerConfig.Resources)
			.AddInMemoryApiScopes(IdentityServerConfig.Scopes)
			.AddInMemoryClients(IdentityServerConfig.Clients)
			.AddAspNetIdentity<ApplicationUser>();

services.AddTransient<IQuestionAndAnswareUserProtectionRepository, QuestionAndAnswareUserProtectionRepository>();
services.AddScoped<IUserSeedInitializer, UserSeedInitializer>();
services.AddScoped<IProfileService, ProfileServices>();
identityBuilder.AddDeveloperSigningCredential();

// Add services to the container.
builder.Services.AddControllersWithViews();
services.AddAntiforgery(options => options.SuppressXFrameOptionsHeader = true);


var app = builder.Build();
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; font-src 'self' https://fonts.gstatic.com");
    await next();
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();

app.UseAuthentication();
app.UseAuthorization();

SeedHelper.SeedUser(app);

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
