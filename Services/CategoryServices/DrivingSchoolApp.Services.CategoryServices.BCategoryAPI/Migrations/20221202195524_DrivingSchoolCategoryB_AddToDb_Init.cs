using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Migrations
{
    public partial class DrivingSchoolCategoryB_AddToDb_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FuelConsuption = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false),
                    Power = table.Column<short>(type: "smallint", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Doors = table.Column<byte>(type: "tinyint", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    AvailableCars = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    TestPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    LicenceDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    VirtualPracticePrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Discount = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarPerCity",
                columns: table => new
                {
                    CategoryBId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPerCity", x => new { x.CategoryBId, x.CarId });
                    table.ForeignKey(
                        name: "FK_CarPerCity_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarPerCity_CategoryB_CategoryBId",
                        column: x => x.CategoryBId,
                        principalTable: "CategoryB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    LicenceId = table.Column<string>(type: "nvarchar(1150)", maxLength: 1150, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    StartedDay = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TotalWorkExperience = table.Column<int>(type: "int", nullable: false),
                    DriveExperience = table.Column<int>(type: "int", nullable: false),
                    InstructorAcademy = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    isBooked = table.Column<bool>(type: "bit", nullable: false),
                    CategoryBId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_CategoryB_CategoryBId",
                        column: x => x.CategoryBId,
                        principalTable: "CategoryB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryLesson",
                columns: table => new
                {
                    CategoryBId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryLesson", x => new { x.LessonId, x.CategoryBId });
                    table.ForeignKey(
                        name: "FK_CategoryLesson_CategoryB_CategoryBId",
                        column: x => x.CategoryBId,
                        principalTable: "CategoryB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryLesson_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperience",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperience_Instructor_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructor",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "AvailableCars", "Color", "Doors", "Fuel", "FuelConsuption", "Length", "Model", "Photo", "Power", "Speed", "Transmission", "Type", "Year" },
                values: new object[,]
                {
                    { 1, (byte)4, "Red", (byte)5, "Petrol", 4.1m, 4060, "Corsa", "vauxhall-corsa", (short)75, 174, "Manual, 5 Speed", "Vauxhall", 2020 },
                    { 2, (byte)5, "Red", (byte)3, "Diesel", 5.5m, 3435, "C1", "citroen_C1", (short)68, 158, "Manual, 5 Speed", "Citroen", 2010 },
                    { 3, (byte)3, "Blue", (byte)5, "Petrol", 4.5m, 4186, "Puma", "ford-puma", (short)125, 200, "Manual, 6 Speed", "Ford", 2019 },
                    { 4, (byte)6, "Red", (byte)3, "Petrol", 4.8m, 4063, "Clio", "renault-clio", (short)75, 167, "Manual, 5 Speed", "Renault", 2016 },
                    { 5, (byte)7, "Yellow", (byte)5, "Diesel", 6.5m, 4199, "Golf 5", "VW-Golf", (short)85, 250, "6 Speed Automatic with Manual mode", "Volkswagen", 2010 }
                });

            migrationBuilder.InsertData(
                table: "CategoryB",
                columns: new[] { "Id", "Address", "City", "Phone" },
                values: new object[,]
                {
                    { 1, "bul. ASNOM 12/A", "Skopje", "+389 01 222 110" },
                    { 2, "ul. Mirche Acev", "Bitola", "+389 21 334 667" },
                    { 3, "bul. JNA 120", "Stip", "+389 01 554 2290" },
                    { 4, "ul. Marko Nestoroski 22", "Ohrid", "+389 23 904 106" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "Id", "Description", "Discount", "Duration", "LicenceDescription", "Price", "TestPrice", "Type", "VirtualPracticePrice" },
                values: new object[,]
                {
                    { 1, "First and foremost, before practical driving has theoretical knowledge. That's why we offer 30 hours of classroom theory with excellent instructors. The price is $65.45 including 2 possible tests. If you don't pass these 2 tests, you will be charged $10 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card or passport is required, you must be over 18 years old, medical certificate for \"B\" category.", null, 30, null, 65.45m, 10m, (byte)0, null },
                    { 2, "You can continue with driving lessons on Polygon if you have successfully passed or previously passed the theory test. The price is $127.95, you get 50 practical lessons at the polygon with a highly qualified and experienced instructor that you choose yourself. Also car of your choice. The price includes the right to take the test 3 times, and then it is $20 each. If you want, you can use a virtual 3D drive-car simulator way of training just for 24.5", (short)15, 50, null, 127.95m, 20m, (byte)1, 24.5m },
                    { 3, "The last classes before the opportunity to apply for a license are city driving classes and the test. The price is $159.95, you get 60 practical lessons with a highly qualified and experienced instructor that you choose yourself. Also car of your choice. The price includes the right to take the test 3 times, and then it is $15 each.", (short)20, 60, "B category - vehicles with a maximum mass not exceeding 3500 kg and seats, excluding the driver's seat, not exceeding 8 seats. The driving license of the categories can be obtained reaching the age of 18. Necessary conditions are to complete a training at driving school and passing the theoretical and driving tests.", 159.95m, 25m, (byte)2, null }
                });

            migrationBuilder.InsertData(
                table: "CarPerCity",
                columns: new[] { "CarId", "CategoryBId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 1, 2, 6 },
                    { 2, 2, 7 },
                    { 3, 2, 8 },
                    { 4, 2, 9 },
                    { 5, 2, 10 },
                    { 2, 3, 11 },
                    { 4, 3, 12 },
                    { 5, 3, 13 },
                    { 1, 4, 14 },
                    { 2, 4, 15 },
                    { 4, 4, 16 }
                });

            migrationBuilder.InsertData(
                table: "CategoryLesson",
                columns: new[] { "CategoryBId", "LessonId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 },
                    { 3, 1, 7 },
                    { 4, 1, 10 },
                    { 1, 2, 2 },
                    { 2, 2, 5 },
                    { 3, 2, 8 },
                    { 4, 2, 11 },
                    { 1, 3, 3 },
                    { 2, 3, 6 },
                    { 3, 3, 9 },
                    { 4, 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "Age", "CategoryBId", "DriveExperience", "Firstname", "InstructorAcademy", "Lastname", "LicenceId", "Photo", "StartedDay", "TotalWorkExperience", "isBooked" },
                values: new object[,]
                {
                    { 1, (short)41, 1, 21, "Davor", "AMSMS", "Shurjak", "c49f5ef9-12b0-43d5-b642-0c6a41e9ca4b", null, "04/19/2009", 14, false },
                    { 2, (short)37, 1, 18, "Tatjana", "AMSMS", "Crvenkovska", "df0b96c7-0016-44c2-b75e-770ab9d43c4c", null, "10/31/2015", 7, false },
                    { 3, (short)52, 1, 34, "Toni", "InstructorsMKD Company", "Zajkov", "962e96d6-5017-4bef-bd32-7ae1af381c42", null, "07/01/1997", 25, true },
                    { 4, (short)37, 1, 9, "Sasa", "AMSMS", "Ciric", "96963be0-3157-4e29-ae95-333969bdce05", null, "07/17/2017", 5, true },
                    { 5, (short)31, 1, 8, "Metodija", "InstructorsMKD Company", "Spasovski", "3f362685-b8b0-4fa3-aa96-1b1c700e4d31", null, "29/01/2021", 5, false },
                    { 6, (short)41, 2, 18, "Filip", "Oslomej Kicevo", "Ristoski", "083d6982-6234-4553-934f-e75f2b58b921", null, "29/01/2019", 15, false },
                    { 7, (short)58, 2, 40, "Maida", "AMSM", "Musandra", "1985be12-6bf4-4063-bf23-56498d029225", null, "12/08/2006", 34, false },
                    { 8, (short)51, 2, 30, "Kristina", "AMSM", "Neagu", "51a01164-2e9b-423e-bb57-c4286695caf0", null, "26/05/2012", 29, false },
                    { 9, (short)29, 2, 11, "Marko", "AMSM", "Mojsov", "9d613151-ac1a-4bb5-a9cb-a34de1c55153", null, "02/02/2017", 5, false },
                    { 10, (short)41, 3, 20, "Cedo", "AS Vardar", "Janevski", "b1952570-ecd5-4f14-9cce-4968a2d7c296", null, "02/02/2017", 16, false },
                    { 11, (short)37, 3, 18, "Pere", "ASMS", "Tosev", "9a05d276-9516-4349-be19-3c7dfa79fa81", null, "03/19/2019", 8, false },
                    { 12, (short)28, 4, 10, "Petar", "ASMS", "Milosevski", "748cf5dd-67f6-4fae-a816-9d8aa067019d", null, "03/19/2018", 4, false },
                    { 13, (short)35, 4, 10, "Sabri", "AS Vardar", "Asan", "9d297b8a-0f70-43bd-ba7c-154a2ea54f53", null, "03/19/2020", 5, false },
                    { 14, (short)32, 4, 14, "Klimentina", "Biljanini Izvori", "Rasko", "c2c5c12c-b37e-4fa5-9552-c1c48a7a8e86", null, "03/19/2014", 9, false }
                });

            migrationBuilder.InsertData(
                table: "WorkExperience",
                columns: new[] { "Id", "Company", "Experience", "InstructorId" },
                values: new object[,]
                {
                    { 1, "Skopje Drive School", 1, 1 },
                    { 2, "Skorpion Skopje", 4, 5 },
                    { 3, "IKO Kumanovo", 3, 6 },
                    { 4, "Auto Akademik Skopje", 9, 6 },
                    { 5, "Skoda Drive Kavadarci", 4, 7 },
                    { 6, "Tikvesh Kavadarci", 8, 7 },
                    { 7, "AMSM", 12, 7 },
                    { 8, "Skorpion Skopje", 1, 8 },
                    { 9, "Labud Struga", 5, 8 },
                    { 10, "Krap Dojran", 2, 8 },
                    { 11, "Roza Skopje", 9, 8 },
                    { 12, "Roza Skopje", 2, 10 },
                    { 13, "Roza Skopje", 9, 10 },
                    { 14, "Auto Zelka Skopje", 5, 11 },
                    { 15, "Drim Debar", 1, 13 },
                    { 16, "Tikvesh Kavadarci", 2, 13 },
                    { 17, "Kajce Ohrid", 1, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarPerCity_CarId",
                table: "CarPerCity",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLesson_CategoryBId",
                table: "CategoryLesson",
                column: "CategoryBId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_CategoryBId",
                table: "Instructor",
                column: "CategoryBId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_InstructorId",
                table: "WorkExperience",
                column: "InstructorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPerCity");

            migrationBuilder.DropTable(
                name: "CategoryLesson");

            migrationBuilder.DropTable(
                name: "WorkExperience");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "CategoryB");
        }
    }
}
