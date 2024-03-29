﻿using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.EntityFrameworkConfigurations;

public static class EntityFrameworkDbInstructorConfigurations
{
	public static void InstructorConfiguration(ModelBuilder modelBuilder,string schema)
	{
		modelBuilder.HasDefaultSchema(schema);
		modelBuilder.Entity<Instructor>().ToTable("Instructor");

		modelBuilder.Entity<Instructor>()
			.HasMany(x => x.CategoryLicences)
			.WithOne(x => x.Instructor)
			.HasForeignKey(x => x.ÌnstructorId);
		modelBuilder.Entity<Instructor>()
			.HasMany(x => x.WorkExperiencePerCompany)
			.WithOne(x => x.Instructor)
			.HasForeignKey(x => x.InstructorId);

		modelBuilder.Entity<Instructor>()
			.HasIndex(x => x.LicenceId)
			.IsUnique()
			.HasDatabaseName("XI_LicenceId");

		modelBuilder.Entity<Instructor>().Property(x => x.Firstname).HasColumnName("Firstname").HasColumnType("nvarchar").HasMaxLength(300).IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.Lastname).HasColumnName("Lastname").HasColumnType("nvarchar").HasMaxLength(350).IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.Age).HasColumnName("Age").HasColumnType("smallint").IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.LicenceId).HasColumnName("LicenceId").HasColumnType("nvarchar").HasMaxLength(1150).IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.StartedDay).HasColumnName("StartedDay").HasColumnType("nvarchar").HasMaxLength(500).IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.Photo).HasColumnName("Photo").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(false);
		modelBuilder.Entity<Instructor>().Property(x => x.TotalWorkExperience).HasColumnName("TotalWorkExperience").HasColumnType("smallint").IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.TotalDriveExperience).HasColumnName("DriveExperience").HasColumnType("smallint").IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.BusDriveExperience).HasColumnName("BusDriveExperience").HasColumnType("smallint").IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.InstructorAcademy).HasColumnName("InstructorAcademy").HasColumnType("nvarchar").HasMaxLength(550).IsRequired(true);
		modelBuilder.Entity<Instructor>().Property(x => x.isBooked).HasColumnName("isBooked").HasColumnType("bit").IsRequired(true);
	}
}