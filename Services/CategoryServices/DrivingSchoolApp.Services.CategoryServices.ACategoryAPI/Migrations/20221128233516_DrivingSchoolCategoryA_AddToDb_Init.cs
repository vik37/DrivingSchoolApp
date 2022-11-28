using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Migrations
{
    public partial class DrivingSchoolCategoryA_AddToDb_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryA",
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
                    table.PrimaryKey("PK_CategoryA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TestPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    LicenceDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    VirtualPracticePrice = table.Column<decimal>(type: "decimal(5,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motorcycle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<short>(type: "smallint", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<short>(type: "smallint", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    AvailableMotorcycles = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycle", x => x.Id);
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
                    Experience = table.Column<short>(type: "smallint", nullable: false),
                    isBooked = table.Column<bool>(type: "bit", nullable: false),
                    CategoryAId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_CategoryA_CategoryAId",
                        column: x => x.CategoryAId,
                        principalTable: "CategoryA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryLessons",
                columns: table => new
                {
                    CategoryAId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryLessons", x => new { x.LessonId, x.CategoryAId });
                    table.ForeignKey(
                        name: "FK_CategoryLessons_CategoryA_CategoryAId",
                        column: x => x.CategoryAId,
                        principalTable: "CategoryA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryLessons_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MororsPerCity",
                columns: table => new
                {
                    CategoryAId = table.Column<int>(type: "int", nullable: false),
                    MotorcycleId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MororsPerCity", x => new { x.MotorcycleId, x.CategoryAId });
                    table.ForeignKey(
                        name: "FK_MororsPerCity_CategoryA_CategoryAId",
                        column: x => x.CategoryAId,
                        principalTable: "CategoryA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MororsPerCity_Motorcycle_MotorcycleId",
                        column: x => x.MotorcycleId,
                        principalTable: "Motorcycle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryA",
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
                columns: new[] { "Id", "Description", "Duration", "LicenceDescription", "Price", "TestPrice", "Type", "VirtualPracticePrice" },
                values: new object[,]
                {
                    { 1, "First and foremost, before practical driving has theoretical knowledge. That's why we offer 20 hours of classroom theory with excellent instructors. The price is $45.95 including 2 possible tests. If you do not pass these 2 tests, you will be charged $10 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card is required and you must be over 18 years old.", 20, null, 45.95m, 10m, (byte)0, null },
                    { 2, "You can continue with practical driving lessons if you have successfully passed or previously passed the theory test. The price is $54.95, you get 40 practical lessons with a highly qualified and experienced instructor that you choose yourself. Also engine of your choice. The price includes the right to take the test 3 times, and then it is $15 each.", 40, "Light motorcycles with an engine size of up to 125 cc and a power output of up to 11 kW. Medium-sized motorcycles up to 25 kW and a power to weight ratio of up to 0.16 kW/kg. Motorcycles with a sidecar and a power to weight ratio of up to 0.16 kW/kg. Any size motorcycle, with or without a sidecar if you have completed the large motorcycle Direct Access Scheme", 45.95m, 15m, (byte)1, 24.5m }
                });

            migrationBuilder.InsertData(
                table: "Motorcycle",
                columns: new[] { "Id", "AvailableMotorcycles", "Capacity", "Color", "Fuel", "Model", "Photo", "Speed", "Type", "Weight", "Year" },
                values: new object[,]
                {
                    { 1, (short)3, 1158, "Black & Gray", (short)22, "Multistrada V4", "ducati-031", (short)155, "Ducati", 240, 2021 },
                    { 2, (short)6, 1802, "Metalic & Black", (short)16, "R 18", "bmwr18-274", (short)99, "BMW ", 345, 2020 },
                    { 3, (short)4, 1380, "Black & Red", (short)20, "MGX 21", "moto-guzzi-mgx-21-176", (short)100, "Moto Guzzi", 314, 2016 },
                    { 4, (short)5, 659, "Red & Black", (short)5, "Tuono 660", "aprilia-073", (short)230, "Aprilia", 181, 2021 }
                });

            migrationBuilder.InsertData(
                table: "CategoryLessons",
                columns: new[] { "CategoryAId", "LessonId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 3 },
                    { 3, 1, 5 },
                    { 4, 1, 7 },
                    { 1, 2, 2 },
                    { 2, 2, 4 },
                    { 3, 2, 6 },
                    { 4, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "Age", "CategoryAId", "Experience", "Firstname", "Lastname", "LicenceId", "Photo", "StartedDay", "isBooked" },
                values: new object[,]
                {
                    { 1, (short)30, 1, (short)7, "Dejan", "Krstevski", "39ff30b1-c444-4c68-87ee-cc2aab3ea621", null, "05/23/2019", false },
                    { 2, (short)43, 1, (short)7, "Marija", "Pavlova", "2ba87e71-1a1b-4457-9571-7d5603ffd5c9", null, "09/07/2018", false },
                    { 3, (short)29, 1, (short)3, "Marko", "Polo", "28ea30a1-fab2-46f4-90aa-46306cbae26d", null, "03/30/2019", false },
                    { 4, (short)53, 2, (short)14, "Kristijan", "Spasevski", "7260b77a-9d58-45f5-99f5-4cd1cac42899", null, "10/06/1998", false },
                    { 5, (short)46, 2, (short)15, "Asan", "Sandokan", "6488955b-26e0-4ca2-9093-4b1794b8caca", null, "11/29/2017", false },
                    { 6, (short)51, 3, (short)16, "Sergej", "Cvetkovic", "962eb826-0fc8-4037-bb01-056a90e84257", null, "01/12/2004", false },
                    { 7, (short)57, 3, (short)21, "Georgi", "Hristov", "cdf71027-ecb5-4f6d-ba03-f7beb357ca84", null, "03/22/2005", true },
                    { 8, (short)32, 3, (short)5, "Muarem", "Muarem", "c2033c8b-78f3-4084-bb44-baaba228d8f2", null, "01/12/2020", false },
                    { 9, (short)37, 3, (short)5, "Natasha", "Sazdova", "c720c512-2187-42ba-bc6b-61474a2d9fba", null, "07/27/2021", false },
                    { 10, (short)42, 4, (short)9, "Nomche", "Nestor", "ea6c9280-de1a-4022-915c-3cc7e6e5b59c", null, "04/19/2007", false },
                    { 11, (short)55, 4, (short)25, "Klime", "Kajcev", "1f999c4b-da54-412f-893d-8663e58c12a3", null, "11/21/2009", false }
                });

            migrationBuilder.InsertData(
                table: "MororsPerCity",
                columns: new[] { "CategoryAId", "MotorcycleId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 1, 2, 5 },
                    { 2, 2, 6 },
                    { 3, 2, 7 },
                    { 4, 2, 8 },
                    { 1, 3, 9 },
                    { 2, 3, 10 },
                    { 3, 3, 11 },
                    { 1, 4, 12 },
                    { 2, 4, 13 },
                    { 4, 4, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLessons_CategoryAId",
                table: "CategoryLessons",
                column: "CategoryAId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_CategoryAId",
                table: "Instructor",
                column: "CategoryAId");

            migrationBuilder.CreateIndex(
                name: "IX_MororsPerCity_CategoryAId",
                table: "MororsPerCity",
                column: "CategoryAId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryLessons");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "MororsPerCity");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "CategoryA");

            migrationBuilder.DropTable(
                name: "Motorcycle");
        }
    }
}
