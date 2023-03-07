using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.RegisterInitializer.Interfaces;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.RegisterInitializer
{
	public class UserSeedInitializer : IUserSeedInitializer
	{
		private readonly DrivingSchoolRegisterDbContext _db;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		public UserSeedInitializer(DrivingSchoolRegisterDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_db = db;
			_userManager = userManager;
			_roleManager = roleManager;
		}

		public void InitializeUser()
		{
			if (_roleManager.FindByNameAsync(Role.Admin).Result == null)
			{
				_roleManager.CreateAsync(new IdentityRole(Role.Admin)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(Role.Instructor)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(Role.Student)).GetAwaiter().GetResult();
			}
			else { return; };
			ApplicationUser adminUser = new ApplicationUser
			{
				Firstname = "Marko",
				Lastname = "Petkovski",
				Email = "marko_krale@gmail.com",
				NormalizedEmail = "marko_krale@gmail.com",
				UserName = "marko_krale@gmail.com",
				RegistrationDate = "19/04/2012",
				DateOfBirth = "02/23/1985",
				Address = "ul. prespanska No. 123",
				City = "Skopje",
				PostCode = 1000,
				PhoneNumber = "+389/65-122-221",
				SecurityStamp = string.Empty,
				QAId = "281b5a41-9daf-4a35-9d35-b2cb00272e53"
			};
			_userManager.CreateAsync(adminUser, "Admin123#").GetAwaiter().GetResult();
			_userManager.AddToRoleAsync(adminUser, Role.Admin).GetAwaiter().GetResult();
			var tempAdmin = _userManager.AddClaimsAsync(adminUser, new Claim[]
			{
				new Claim(type: JwtClaimTypes.Name, value: $"{adminUser.Firstname} {adminUser.Lastname}"),
				new Claim(type: JwtClaimTypes.GivenName, value: adminUser.Firstname),
				new Claim(type: JwtClaimTypes.FamilyName, value: adminUser.Lastname),
				new Claim(type: JwtClaimTypes.Email, value: adminUser.Email),
				new Claim(type: JwtClaimTypes.PhoneNumber, value: adminUser.PhoneNumber),
				new Claim(type: JwtClaimTypes.Role, value: Role.Admin)
			}).Result;

			ApplicationUser instructorUser = new ApplicationUser
			{
				Firstname = "Davor",
				Lastname = "Shurjak",
				Email = "davor@outlook.com",
				NormalizedEmail = "davor@outlook.com",
				UserName = "davor@outlook.com",
				RegistrationDate = "09/07/2015",
				DateOfBirth = "09/12/1981",
				Address = "bul. JNA 12/B",
				City = "Skopje",
				PostCode = 1000,
				PhoneNumber = "+389/034-222-332",
				SecurityStamp = string.Empty,
				QAId = "2eef48da-a884-4f44-bf88-c1984bf17db9"
			};
			_userManager.CreateAsync(instructorUser, "Daci229&A").GetAwaiter().GetResult();
			_userManager.AddToRoleAsync(instructorUser, Role.Instructor).GetAwaiter().GetResult();
			var tempInstructor = _userManager.AddClaimsAsync(instructorUser, new Claim[]
			{
				new Claim(type: JwtClaimTypes.Name, value: $"{instructorUser.Firstname} {instructorUser.Lastname}"),
				new Claim(type: JwtClaimTypes.GivenName, value: instructorUser.Firstname),
				new Claim(type: JwtClaimTypes.FamilyName, value: instructorUser.Lastname),
				new Claim(type: JwtClaimTypes.Email, value: instructorUser.Email),
				new Claim(type: JwtClaimTypes.PhoneNumber, value: instructorUser.PhoneNumber),
				new Claim(type: JwtClaimTypes.Role, value: Role.Instructor)
			}).Result;

			ApplicationUser studentUser = new ApplicationUser
			{
				Firstname = "Kata",
				Lastname = "Despotovska",
				Email = "kata@yahoo.com",
				NormalizedEmail = "kata@yahoo.com",
				UserName = "kata@yahoo.com",
				RegistrationDate = "17/10/2022",
				DateOfBirth = "19/12/1978",
				Address = "ul. Maksim Gorki",
				City = "Negotino",
				PostCode = 1440,
				PhoneNumber = "+389/23-445-887",
				SecurityStamp = string.Empty,
				QAId = "49c41e47-2f64-4130-b4d1-ef2fd6a7d803"
			};
			_userManager.CreateAsync(studentUser, "Kata1#PrviDan2020").GetAwaiter().GetResult();
			_userManager.AddToRoleAsync(studentUser, Role.Student).GetAwaiter().GetResult();
			var tempStudent = _userManager.AddClaimsAsync(studentUser, new Claim[]
			{
				new Claim(type: JwtClaimTypes.Name, value: $"{studentUser.Firstname} {studentUser.Lastname}"),
				new Claim(type: JwtClaimTypes.GivenName, value: studentUser.Firstname),
				new Claim(type: JwtClaimTypes.FamilyName, value: studentUser.Lastname),
				new Claim(type: JwtClaimTypes.Email, value: studentUser.Email),
				new Claim(type: JwtClaimTypes.PhoneNumber, value: studentUser.PhoneNumber),
				new Claim(type: JwtClaimTypes.Role, value: Role.Student)
			}).Result;
		}
	}
}
