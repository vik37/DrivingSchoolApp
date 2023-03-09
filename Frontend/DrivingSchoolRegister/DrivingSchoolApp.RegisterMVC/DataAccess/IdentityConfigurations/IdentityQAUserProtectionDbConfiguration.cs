using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.IdentityConfigurations
{
	public class IdentityQAUserProtectionDbConfiguration : IEntityTypeConfiguration<QuestionAnswareUserProtection>
	{
		public void Configure(EntityTypeBuilder<QuestionAnswareUserProtection> builder)
		{
			builder.Property(qa => qa.Id).HasColumnName("Id").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
			builder.Property(qa => qa.Question).HasColumnName("Question").HasColumnType("int").IsRequired(true);
			builder.Property(qa => qa.Answare).HasColumnName("Answare").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
		}
	}
}
