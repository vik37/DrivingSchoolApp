using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.IdentityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.RegisterMVC.DataAccess
{
	public class DrivingSchoolRegisterDbContext : IdentityDbContext<ApplicationUser>
	{
		public DrivingSchoolRegisterDbContext(DbContextOptions<DrivingSchoolRegisterDbContext> option): base(option)
		{ }

		public DbSet<QuestionAnswerUserProtection> QuestionAnswerUserProtections { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new IdentityApplicationUserDbConfiguration());
			builder.ApplyConfiguration(new IdentityQAUserProtectionDbConfiguration());

		}
	}
}
