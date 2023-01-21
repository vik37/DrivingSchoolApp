﻿// <auto-generated />
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Migrations
{
    [DbContext(typeof(CategoryADbContext))]
    [Migration("20230120215652_DrivingSchoolCategoryA_AddToDb_Second")]
    partial class DrivingSchoolCategoryA_AddToDb_Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.CategoryLesson", b =>
                {
                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryAId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("LessonId", "CategoryAId");

                    b.HasIndex("CategoryAId");

                    b.ToTable("CategoryLessons");

                    b.HasData(
                        new
                        {
                            LessonId = 1,
                            CategoryAId = 1,
                            Id = 1
                        },
                        new
                        {
                            LessonId = 2,
                            CategoryAId = 1,
                            Id = 2
                        },
                        new
                        {
                            LessonId = 1,
                            CategoryAId = 2,
                            Id = 3
                        },
                        new
                        {
                            LessonId = 2,
                            CategoryAId = 2,
                            Id = 4
                        },
                        new
                        {
                            LessonId = 1,
                            CategoryAId = 3,
                            Id = 5
                        },
                        new
                        {
                            LessonId = 2,
                            CategoryAId = 3,
                            Id = 6
                        },
                        new
                        {
                            LessonId = 1,
                            CategoryAId = 4,
                            Id = 7
                        },
                        new
                        {
                            LessonId = 2,
                            CategoryAId = 4,
                            Id = 8
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<short>("Age")
                        .HasColumnType("smallint")
                        .HasColumnName("Age");

                    b.Property<int>("CategoryAId")
                        .HasColumnType("int");

                    b.Property<short>("Experience")
                        .HasColumnType("smallint")
                        .HasColumnName("Experience");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Firstname");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)")
                        .HasColumnName("Lastname");

                    b.Property<string>("Photo")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)")
                        .HasColumnName("Photo");

                    b.Property<string>("StartedDay")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("StartedDay");

                    b.Property<bool>("isBooked")
                        .HasColumnType("bit")
                        .HasColumnName("isBooked");

                    b.HasKey("Id");

                    b.HasIndex("CategoryAId");

                    b.ToTable("Instructor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = (short)30,
                            CategoryAId = 1,
                            Experience = (short)7,
                            Firstname = "Dejan",
                            Lastname = "Krstevski",
                            StartedDay = "05/23/2019",
                            isBooked = false
                        },
                        new
                        {
                            Id = 2,
                            Age = (short)43,
                            CategoryAId = 1,
                            Experience = (short)7,
                            Firstname = "Marija",
                            Lastname = "Pavlova",
                            StartedDay = "09/07/2018",
                            isBooked = false
                        },
                        new
                        {
                            Id = 3,
                            Age = (short)29,
                            CategoryAId = 1,
                            Experience = (short)3,
                            Firstname = "Marko",
                            Lastname = "Polo",
                            StartedDay = "03/30/2019",
                            isBooked = false
                        },
                        new
                        {
                            Id = 4,
                            Age = (short)53,
                            CategoryAId = 2,
                            Experience = (short)14,
                            Firstname = "Kristijan",
                            Lastname = "Spasevski",
                            StartedDay = "10/06/1998",
                            isBooked = false
                        },
                        new
                        {
                            Id = 5,
                            Age = (short)46,
                            CategoryAId = 2,
                            Experience = (short)15,
                            Firstname = "Asan",
                            Lastname = "Sandokan",
                            StartedDay = "11/29/2017",
                            isBooked = false
                        },
                        new
                        {
                            Id = 6,
                            Age = (short)51,
                            CategoryAId = 3,
                            Experience = (short)16,
                            Firstname = "Sergej",
                            Lastname = "Cvetkovic",
                            StartedDay = "01/12/2004",
                            isBooked = false
                        },
                        new
                        {
                            Id = 7,
                            Age = (short)57,
                            CategoryAId = 3,
                            Experience = (short)21,
                            Firstname = "Georgi",
                            Lastname = "Hristov",
                            StartedDay = "03/22/2005",
                            isBooked = true
                        },
                        new
                        {
                            Id = 8,
                            Age = (short)32,
                            CategoryAId = 3,
                            Experience = (short)5,
                            Firstname = "Muarem",
                            Lastname = "Muarem",
                            StartedDay = "01/12/2020",
                            isBooked = false
                        },
                        new
                        {
                            Id = 9,
                            Age = (short)37,
                            CategoryAId = 3,
                            Experience = (short)5,
                            Firstname = "Natasha",
                            Lastname = "Sazdova",
                            StartedDay = "07/27/2021",
                            isBooked = false
                        },
                        new
                        {
                            Id = 10,
                            Age = (short)42,
                            CategoryAId = 4,
                            Experience = (short)9,
                            Firstname = "Nomche",
                            Lastname = "Nestor",
                            StartedDay = "04/19/2007",
                            isBooked = false
                        },
                        new
                        {
                            Id = 11,
                            Age = (short)55,
                            CategoryAId = 4,
                            Experience = (short)25,
                            Firstname = "Klime",
                            Lastname = "Kajcev",
                            StartedDay = "11/21/2009",
                            isBooked = false
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Lesson", b =>
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

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("Duration");

                    b.Property<string>("LicenceDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)")
                        .HasColumnName("LicenceDescription");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("Price");

                    b.Property<decimal>("TestPrice")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("TestPrice");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint")
                        .HasColumnName("Type");

                    b.Property<decimal?>("VirtualPracticePrice")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("VirtualPracticePrice");

                    b.HasKey("Id");

                    b.ToTable("Lesson");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "First and foremost, before practical driving has theoretical knowledge. That's why we offer 20 hours of classroom theory with excellent instructors. The price is $45.95 including 2 possible tests. If you do not pass these 2 tests, you will be charged $10 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card is required and you must be over 18 years old.",
                            Duration = 20,
                            Price = 45.95m,
                            TestPrice = 10m,
                            Type = (byte)0
                        },
                        new
                        {
                            Id = 2,
                            Description = "You can continue with practical driving lessons if you have successfully passed or previously passed the theory test. The price is $54.95, you get 40 practical lessons with a highly qualified and experienced instructor that you choose yourself. Also engine of your choice. The price includes the right to take the test 3 times, and then it is $15 each.",
                            Duration = 40,
                            LicenceDescription = "Light motorcycles with an engine size of up to 125 cc and a power output of up to 11 kW. Medium-sized motorcycles up to 25 kW and a power to weight ratio of up to 0.16 kW/kg. Motorcycles with a sidecar and a power to weight ratio of up to 0.16 kW/kg. Any size motorcycle, with or without a sidecar if you have completed the large motorcycle Direct Access Scheme",
                            Price = 54.95m,
                            TestPrice = 15m,
                            Type = (byte)1,
                            VirtualPracticePrice = 24.5m
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.MororsPerCity", b =>
                {
                    b.Property<int>("MotorcycleId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryAId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("MotorcycleId", "CategoryAId");

                    b.HasIndex("CategoryAId");

                    b.ToTable("MororsPerCity");

                    b.HasData(
                        new
                        {
                            MotorcycleId = 1,
                            CategoryAId = 1,
                            Id = 1
                        },
                        new
                        {
                            MotorcycleId = 1,
                            CategoryAId = 2,
                            Id = 2
                        },
                        new
                        {
                            MotorcycleId = 1,
                            CategoryAId = 3,
                            Id = 3
                        },
                        new
                        {
                            MotorcycleId = 1,
                            CategoryAId = 4,
                            Id = 4
                        },
                        new
                        {
                            MotorcycleId = 2,
                            CategoryAId = 1,
                            Id = 5
                        },
                        new
                        {
                            MotorcycleId = 2,
                            CategoryAId = 2,
                            Id = 6
                        },
                        new
                        {
                            MotorcycleId = 2,
                            CategoryAId = 3,
                            Id = 7
                        },
                        new
                        {
                            MotorcycleId = 2,
                            CategoryAId = 4,
                            Id = 8
                        },
                        new
                        {
                            MotorcycleId = 3,
                            CategoryAId = 1,
                            Id = 9
                        },
                        new
                        {
                            MotorcycleId = 3,
                            CategoryAId = 2,
                            Id = 10
                        },
                        new
                        {
                            MotorcycleId = 3,
                            CategoryAId = 3,
                            Id = 11
                        },
                        new
                        {
                            MotorcycleId = 4,
                            CategoryAId = 1,
                            Id = 12
                        },
                        new
                        {
                            MotorcycleId = 4,
                            CategoryAId = 2,
                            Id = 13
                        },
                        new
                        {
                            MotorcycleId = 4,
                            CategoryAId = 4,
                            Id = 14
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Motorcycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<short>("AvailableMotorcycles")
                        .HasColumnType("smallint")
                        .HasColumnName("AvailableMotorcycles");

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("Capacity");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Color");

                    b.Property<short>("Fuel")
                        .HasColumnType("smallint")
                        .HasColumnName("Fuel");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Model");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Photo");

                    b.Property<short>("Speed")
                        .HasColumnType("smallint")
                        .HasColumnName("Speed");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Type");

                    b.Property<int>("Weight")
                        .HasColumnType("int")
                        .HasColumnName("Weight");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("Year");

                    b.HasKey("Id");

                    b.ToTable("Motorcycle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableMotorcycles = (short)3,
                            Capacity = 1158,
                            Color = "Black & Gray",
                            Fuel = (short)22,
                            Model = "Multistrada V4",
                            Photo = "ducati-031",
                            Speed = (short)155,
                            Type = "Ducati",
                            Weight = 240,
                            Year = 2021
                        },
                        new
                        {
                            Id = 2,
                            AvailableMotorcycles = (short)6,
                            Capacity = 1802,
                            Color = "Metalic & Black",
                            Fuel = (short)16,
                            Model = "R 18",
                            Photo = "bmwr18-274",
                            Speed = (short)99,
                            Type = "BMW ",
                            Weight = 345,
                            Year = 2020
                        },
                        new
                        {
                            Id = 3,
                            AvailableMotorcycles = (short)4,
                            Capacity = 1380,
                            Color = "Black & Red",
                            Fuel = (short)20,
                            Model = "MGX 21",
                            Photo = "moto-guzzi-mgx-21-176",
                            Speed = (short)100,
                            Type = "Moto Guzzi",
                            Weight = 314,
                            Year = 2016
                        },
                        new
                        {
                            Id = 4,
                            AvailableMotorcycles = (short)5,
                            Capacity = 659,
                            Color = "Red & Black",
                            Fuel = (short)5,
                            Model = "Tuono 660",
                            Photo = "aprilia-073",
                            Speed = (short)230,
                            Type = "Aprilia",
                            Weight = 181,
                            Year = 2021
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities.CategoryA", b =>
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

                    b.ToTable("CategoryA");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "bul. ASNOM 12/A",
                            City = "Skopje",
                            Phone = "+389 01 222 110"
                        },
                        new
                        {
                            Id = 2,
                            Address = "ul. Mirche Acev",
                            City = "Bitola",
                            Phone = "+389 21 334 667"
                        },
                        new
                        {
                            Id = 3,
                            Address = "bul. JNA 120",
                            City = "Stip",
                            Phone = "+389 01 554 2290"
                        },
                        new
                        {
                            Id = 4,
                            Address = "ul. Marko Nestoroski 22",
                            City = "Ohrid",
                            Phone = "+389 23 904 106"
                        });
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.CategoryLesson", b =>
                {
                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities.CategoryA", "CategoryA")
                        .WithMany("CategoryLessons")
                        .HasForeignKey("CategoryAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Lesson", "Lessons")
                        .WithMany("CategoryLessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryA");

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Instructor", b =>
                {
                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities.CategoryA", "CategoryA")
                        .WithMany("Instructors")
                        .HasForeignKey("CategoryAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryA");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.MororsPerCity", b =>
                {
                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities.CategoryA", "CategoryA")
                        .WithMany("MotorcyclePerCity")
                        .HasForeignKey("CategoryAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Motorcycle", "Motorcycle")
                        .WithMany("MotorsPerCity")
                        .HasForeignKey("MotorcycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryA");

                    b.Navigation("Motorcycle");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Lesson", b =>
                {
                    b.Navigation("CategoryLessons");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities.Motorcycle", b =>
                {
                    b.Navigation("MotorsPerCity");
                });

            modelBuilder.Entity("DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities.CategoryA", b =>
                {
                    b.Navigation("CategoryLessons");

                    b.Navigation("Instructors");

                    b.Navigation("MotorcyclePerCity");
                });
#pragma warning restore 612, 618
        }
    }
}