using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.Entities.Enums;
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

			Seed(builder);
		}

		private void Seed(EntityTypeBuilder<QuestionAnswareUserProtection> builder)
		{
			builder.HasData(
					new QuestionAnswareUserProtection
					{
						Id = "281b5a41-9daf-4a35-9d35-b2cb00272e53",
						Question = Question.WhatIsYourMostFavoriteMovie,
						Answare = "Omen"
					},
					new QuestionAnswareUserProtection
					{
						Id = "2eef48da-a884-4f44-bf88-c1984bf17db9",
						Question = Question.WhatIsYourFavoriteSong,
						Answare = "SMF - I saw your mommy"
					},
					new QuestionAnswareUserProtection
					{
						Id = "49c41e47-2f64-4130-b4d1-ef2fd6a7d803",
						Question = Question.WhatDidYouEatToday,
						Answare = "chocolate with caramel"
					}
				);
		}
	}
}
