using DrivingSchoolApp.RegisterMVC.DataAccess;
using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.RegisterInitializer;
using DrivingSchoolApp.RegisterMVC.DataAccess.RegisterInitializer.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DrivingSchoolApp.RegisterMVC.Helper
{
	public static class SeedHelper
	{
		public static void SeedUser(WebApplication app)
		{
			var context = app.Services.CreateScope().ServiceProvider.GetService<DrivingSchoolRegisterDbContext>();
			var userManager = app.Services.CreateScope().ServiceProvider.GetService<UserManager<ApplicationUser>>();
			var roleManager = app.Services.CreateScope().ServiceProvider.GetService<RoleManager<IdentityRole>>();

			IUserSeedInitializer userInitializer = new UserSeedInitializer(context, userManager, roleManager);

			userInitializer.InitializeUser();
		}
	}
}
