﻿// <auto-generated />
using System;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Migrations
{
    [DbContext(typeof(CategoryDDbContext))]
    [Migration("20221213191819_DrivingSchoolCategoryD_AddToDb_Init")]
    partial class DrivingSchoolCategoryD_AddToDb_Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.CategoryD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Address");

                    b.Property<string>("BusPhoto")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)")
                        .HasColumnName("BusPhoto");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("City");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.ToTable("CategoryD", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "bul. ASNOM 12/A",
                            BusPhoto = "skopje-bus",
                            City = "Skopje",
                            Phone = "+389 01 222 110"
                        },
                        new
                        {
                            Id = 2,
                            Address = "ul. Mirche Acev",
                            BusPhoto = "bitola-bus",
                            City = "Bitola",
                            Phone = "+389 21 334 667"
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.CategoryLesson", b =>
                {
                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryDId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("LessonId", "CategoryDId");

                    b.HasIndex("CategoryDId");

                    b.ToTable("CategoryLesson", "dbo");

                    b.HasData(
                        new
                        {
                            LessonId = 1,
                            CategoryDId = 1,
                            Id = 1
                        },
                        new
                        {
                            LessonId = 2,
                            CategoryDId = 1,
                            Id = 2
                        },
                        new
                        {
                            LessonId = 3,
                            CategoryDId = 1,
                            Id = 3
                        },
                        new
                        {
                            LessonId = 4,
                            CategoryDId = 1,
                            Id = 4
                        },
                        new
                        {
                            LessonId = 1,
                            CategoryDId = 2,
                            Id = 5
                        },
                        new
                        {
                            LessonId = 2,
                            CategoryDId = 2,
                            Id = 6
                        },
                        new
                        {
                            LessonId = 3,
                            CategoryDId = 2,
                            Id = 7
                        },
                        new
                        {
                            LessonId = 4,
                            CategoryDId = 2,
                            Id = 8
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<short>("Age")
                        .HasColumnType("smallint")
                        .HasColumnName("Age");

                    b.Property<short>("BusDriveExperience")
                        .HasColumnType("smallint")
                        .HasColumnName("BusDriveExperience");

                    b.Property<int>("CategoryDId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Firstname");

                    b.Property<string>("InstructorAcademy")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)")
                        .HasColumnName("InstructorAcademy");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)")
                        .HasColumnName("Lastname");

                    b.Property<string>("LicenceId")
                        .IsRequired()
                        .HasMaxLength(1150)
                        .HasColumnType("nvarchar(1150)")
                        .HasColumnName("LicenceId");

                    b.Property<string>("Photo")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)")
                        .HasColumnName("Photo");

                    b.Property<string>("StartedDay")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("StartedDay");

                    b.Property<short>("TotalDriveExperience")
                        .HasColumnType("smallint")
                        .HasColumnName("DriveExperience");

                    b.Property<short>("TotalWorkExperience")
                        .HasColumnType("smallint")
                        .HasColumnName("TotalWorkExperience");

                    b.Property<bool>("isBooked")
                        .HasColumnType("bit")
                        .HasColumnName("isBooked");

                    b.HasKey("Id");

                    b.HasIndex("CategoryDId");

                    b.HasIndex("LicenceId")
                        .IsUnique()
                        .HasDatabaseName("XI_LicenceId");

                    b.ToTable("Instructor", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = (short)51,
                            BusDriveExperience = (short)21,
                            CategoryDId = 1,
                            Firstname = "Nikola",
                            InstructorAcademy = "AMSM",
                            Lastname = "Savov",
                            LicenceId = "ad618ebc-b5f2-46c2-bec6-1d130e6428ab",
                            StartedDay = "19/11/2017",
                            TotalDriveExperience = (short)28,
                            TotalWorkExperience = (short)19,
                            isBooked = true
                        },
                        new
                        {
                            Id = 2,
                            Age = (short)47,
                            BusDriveExperience = (short)18,
                            CategoryDId = 1,
                            Firstname = "Ramazan",
                            InstructorAcademy = "AMSM",
                            Lastname = "Serbezovski",
                            LicenceId = "e364ea17-318e-42ce-b02d-bc396c2f1c78",
                            StartedDay = "09/10/2019",
                            TotalDriveExperience = (short)28,
                            TotalWorkExperience = (short)17,
                            isBooked = false
                        },
                        new
                        {
                            Id = 3,
                            Age = (short)54,
                            BusDriveExperience = (short)29,
                            CategoryDId = 2,
                            Firstname = "Risto",
                            InstructorAcademy = "AMSM",
                            Lastname = "Shihkov",
                            LicenceId = "14eafc97-8a48-4bd0-988b-2478ea3db2a4",
                            StartedDay = "25/04/2014",
                            TotalDriveExperience = (short)35,
                            TotalWorkExperience = (short)29,
                            isBooked = false
                        },
                        new
                        {
                            Id = 4,
                            Age = (short)39,
                            BusDriveExperience = (short)9,
                            CategoryDId = 2,
                            Firstname = "Aleksandar",
                            InstructorAcademy = "Asvalt Bitola",
                            Lastname = "Temelkov",
                            LicenceId = "7cf56071-de16-4323-82f9-f50602b02578",
                            StartedDay = "05/02/2021",
                            TotalDriveExperience = (short)21,
                            TotalWorkExperience = (short)8,
                            isBooked = false
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.InstructorCategoryLicence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("CategoryType")
                        .HasColumnType("tinyint")
                        .HasColumnName("CategoryType");

                    b.Property<int>("ÌnstructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ÌnstructorId");

                    b.ToTable("InstructorCategoryLicence", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryType = (byte)0,
                            ÌnstructorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryType = (byte)1,
                            ÌnstructorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryType = (byte)2,
                            ÌnstructorId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryType = (byte)3,
                            ÌnstructorId = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryType = (byte)1,
                            ÌnstructorId = 2
                        },
                        new
                        {
                            Id = 6,
                            CategoryType = (byte)2,
                            ÌnstructorId = 2
                        },
                        new
                        {
                            Id = 7,
                            CategoryType = (byte)3,
                            ÌnstructorId = 2
                        },
                        new
                        {
                            Id = 8,
                            CategoryType = (byte)1,
                            ÌnstructorId = 3
                        },
                        new
                        {
                            Id = 9,
                            CategoryType = (byte)2,
                            ÌnstructorId = 3
                        },
                        new
                        {
                            Id = 10,
                            CategoryType = (byte)3,
                            ÌnstructorId = 3
                        },
                        new
                        {
                            Id = 11,
                            CategoryType = (byte)0,
                            ÌnstructorId = 4
                        },
                        new
                        {
                            Id = 12,
                            CategoryType = (byte)1,
                            ÌnstructorId = 4
                        },
                        new
                        {
                            Id = 13,
                            CategoryType = (byte)2,
                            ÌnstructorId = 4
                        },
                        new
                        {
                            Id = 14,
                            CategoryType = (byte)3,
                            ÌnstructorId = 4
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)")
                        .HasColumnName("Description");

                    b.Property<short?>("Discount")
                        .HasColumnType("smallint")
                        .HasColumnName("Discount");

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("Duration");

                    b.Property<string>("LicenceDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)")
                        .HasColumnName("LicenceDescription");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("Price");

                    b.Property<decimal>("TestPrice")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("TestPrice");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint")
                        .HasColumnName("Type");

                    b.Property<decimal?>("VirtualPracticePrice")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("VirtualPracticePrice");

                    b.HasKey("Id");

                    b.ToTable("Lesson", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "First and foremost, before practical driving has theoretical knowledge. That's why we offer 50 hours of classroom theory with excellent instructors. The price is $110.45 including 3 possible tests. If you don't pass these 3 tests, you will be charged $20 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card or passport is required, you must be over 21 years old, medical certificate for \"D\" category. It's also mandatory to have previously taken \"C\" category.",
                            Duration = 50,
                            Price = 110.45m,
                            TestPrice = 20m,
                            Type = (byte)0
                        },
                        new
                        {
                            Id = 2,
                            Description = "In addition to as part of a medical examination where there is always a psychological test, an additional 15 hours of psychological training have been introduced on our part because we consider it a big responsibility to transport passengers by motor vehicle, i.e. bus. The minimum price is $5, and the test after 4 trials is charged $1 each. This class and test is mandatory before proceeding further with a polygon.",
                            Duration = 15,
                            Price = 5m,
                            TestPrice = 1m,
                            Type = (byte)1
                        },
                        new
                        {
                            Id = 3,
                            Description = "You can continue with driving lessons on Polygon if you have successfully passed or previously passed the theory test. The price is $179.45$, you get 70 practical lessons at the polygon with a highly qualified and experienced instructor that you choose yourself. The price includes the right to take the test 3 times, and then it is $35 each. If you want, you can use a virtual 3D drive-car simulator way of training just for 24.5. Currently, Only in Skopje and Bitola we have the opportunity for D category training.",
                            Discount = (short)15,
                            Duration = 70,
                            Price = 179.45m,
                            TestPrice = 35m,
                            Type = (byte)2,
                            VirtualPracticePrice = 24.5m
                        },
                        new
                        {
                            Id = 4,
                            Description = "The last classes before the opportunity to apply for a license are city driving classes and the test. The price is $215.95, you get 90 practical lessons with a highly qualified and experienced instructor that you choose yourself. The price includes the right to take the test 3 times, and then it is $45 each.",
                            Discount = (short)20,
                            Duration = 90,
                            LicenceDescription = "Different driver's licenses can be used to operate different classes of vehicles. The most common is the passenger (Class D) license, which allows you to legally operate a passenger vehicle. Motor vehicles which are constructed and designed for the carriage of more than 8 passengers in addition to the driver, with or without a trailer with a maximum authorized mass not exceeding 750 kg.",
                            Price = 215.95m,
                            TestPrice = 45m,
                            Type = (byte)3
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)")
                        .HasColumnName("Company");

                    b.Property<int>("Experience")
                        .HasColumnType("int")
                        .HasColumnName("Experience");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<byte>("TypeOfWorkExperience")
                        .HasColumnType("tinyint")
                        .HasColumnName("TypeOfWorkExperience");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("WorkExperience", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Company = "Avast Tourist Skopje",
                            Experience = 2,
                            InstructorId = 1,
                            TypeOfWorkExperience = (byte)1
                        },
                        new
                        {
                            Id = 2,
                            Company = "JSP Skopje",
                            Experience = 5,
                            InstructorId = 1,
                            TypeOfWorkExperience = (byte)2
                        },
                        new
                        {
                            Id = 3,
                            Company = "Apollo Crid",
                            Experience = 7,
                            InstructorId = 1,
                            TypeOfWorkExperience = (byte)0
                        },
                        new
                        {
                            Id = 4,
                            Company = "Fabula Travel Kicevo",
                            Experience = 1,
                            InstructorId = 2,
                            TypeOfWorkExperience = (byte)1
                        },
                        new
                        {
                            Id = 5,
                            Company = "Fabula Travel Kicevo",
                            Experience = 10,
                            InstructorId = 2,
                            TypeOfWorkExperience = (byte)2
                        },
                        new
                        {
                            Id = 6,
                            Company = "Febro Transit Skopje",
                            Experience = 3,
                            InstructorId = 2,
                            TypeOfWorkExperience = (byte)2
                        },
                        new
                        {
                            Id = 7,
                            Company = "JUGO Transport Prilep",
                            Experience = 4,
                            InstructorId = 3,
                            TypeOfWorkExperience = (byte)1
                        },
                        new
                        {
                            Id = 8,
                            Company = "Prespa Turist Resen",
                            Experience = 7,
                            InstructorId = 3,
                            TypeOfWorkExperience = (byte)2
                        },
                        new
                        {
                            Id = 9,
                            Company = "Vardar Travel Skopje",
                            Experience = 2,
                            InstructorId = 3,
                            TypeOfWorkExperience = (byte)2
                        },
                        new
                        {
                            Id = 10,
                            Company = "Drive School Skopje",
                            Experience = 8,
                            InstructorId = 3,
                            TypeOfWorkExperience = (byte)0
                        },
                        new
                        {
                            Id = 11,
                            Company = "Stoby Travel Negotino",
                            Experience = 1,
                            InstructorId = 4,
                            TypeOfWorkExperience = (byte)1
                        },
                        new
                        {
                            Id = 12,
                            Company = "Nekoj Travel Bitola",
                            Experience = 6,
                            InstructorId = 4,
                            TypeOfWorkExperience = (byte)2
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.CategoryLesson", b =>
                {
                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.CategoryD", "CategoryD")
                        .WithMany("Lessons")
                        .HasForeignKey("CategoryDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Lesson", "Lesson")
                        .WithMany("CategoryLessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryD");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Instructor", b =>
                {
                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.CategoryD", "CategoryD")
                        .WithMany("Instructors")
                        .HasForeignKey("CategoryDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryD");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.InstructorCategoryLicence", b =>
                {
                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Instructor", "Instructor")
                        .WithMany("CategoryLicences")
                        .HasForeignKey("ÌnstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.WorkExperience", b =>
                {
                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Instructor", "Instructor")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.CategoryD", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Instructor", b =>
                {
                    b.Navigation("CategoryLicences");

                    b.Navigation("WorkExperiences");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities.Lesson", b =>
                {
                    b.Navigation("CategoryLessons");
                });
#pragma warning restore 612, 618
        }
    }
}