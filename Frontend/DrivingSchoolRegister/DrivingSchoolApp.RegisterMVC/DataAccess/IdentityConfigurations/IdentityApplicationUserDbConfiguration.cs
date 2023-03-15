using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.IdentityConfigurations
{
	public class IdentityApplicationUserDbConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			builder.HasOne(au => au.QuestionAnswerUserProtection)
				.WithOne(qa => qa.ApplicationUser)
				.HasForeignKey<ApplicationUser>(au => au.QAId);

			builder.HasIndex(au => au.QAId).IsUnique();

			builder.Property(au => au.Firstname).HasColumnName("Firstname").HasColumnType("nvarchar").HasMaxLength(150).IsRequired(true);
			builder.Property(au => au.Lastname).HasColumnName("Lastname").HasColumnType("nvarchar").HasMaxLength(200).IsRequired(true);
			builder.Property(au => au.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("nvarchar").HasMaxLength(20).IsRequired(true); ;		
			builder.Property(au => au.City).HasColumnName("City").HasColumnType("nvarchar").HasMaxLength(250).IsRequired(true);
			builder.Property(au => au.PostCode).HasColumnName("PostCode").HasColumnType("smallint").IsRequired(true);
			builder.Property(au => au.Address).HasColumnName("Address").HasColumnType("nvarchar").HasMaxLength(200).IsRequired(true);
			builder.Property(au => au.RegistrationDate).HasColumnName("RegistrationDate").HasColumnType("nvarchar").HasMaxLength(250).IsRequired(true);
			builder.Property(au => au.QAId).HasColumnName("QAId").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);

		}
	}
}
