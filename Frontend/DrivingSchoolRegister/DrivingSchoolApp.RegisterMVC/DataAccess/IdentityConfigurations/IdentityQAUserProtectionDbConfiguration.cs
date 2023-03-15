using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.IdentityConfigurations
{
	public class IdentityQAUserProtectionDbConfiguration : IEntityTypeConfiguration<QuestionAnswerUserProtection>
	{
		public void Configure(EntityTypeBuilder<QuestionAnswerUserProtection> builder)
		{
			builder.Property(qa => qa.Id).HasColumnName("Id").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
			builder.Property(qa => qa.Question).HasColumnName("Question").HasColumnType("int").IsRequired(true);
			builder.Property(qa => qa.Answer).HasColumnName("Answer").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
		}
	}
}
