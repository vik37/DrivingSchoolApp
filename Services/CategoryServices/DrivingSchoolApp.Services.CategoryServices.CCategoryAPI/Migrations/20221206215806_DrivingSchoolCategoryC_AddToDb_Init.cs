using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Migrations
{
    public partial class DrivingSchoolCategoryC_AddToDb_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryC",
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
                    table.PrimaryKey("PK_CategoryC", x => x.Id);
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
                name: "Truck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckNumber = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Power = table.Column<short>(type: "smallint", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: false),
                    CylinderCapacity = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    AvailableTruck = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.Id);
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
                    TotalWorkExperience = table.Column<short>(type: "smallint", nullable: false),
                    DriveExperience = table.Column<short>(type: "smallint", nullable: false),
                    TruckDriveExperience = table.Column<short>(type: "smallint", nullable: false),
                    InstructorAcademy = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    isBooked = table.Column<bool>(type: "bit", nullable: false),
                    CategoryCId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_CategoryC_CategoryCId",
                        column: x => x.CategoryCId,
                        principalTable: "CategoryC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryLesson",
                columns: table => new
                {
                    CategoryCId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryLesson", x => new { x.LessonId, x.CategoryCId });
                    table.ForeignKey(
                        name: "FK_CategoryLesson_CategoryC_CategoryCId",
                        column: x => x.CategoryCId,
                        principalTable: "CategoryC",
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
                name: "TruckPerCity",
                columns: table => new
                {
                    CategoryCId = table.Column<int>(type: "int", nullable: false),
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckPerCity", x => new { x.TruckId, x.CategoryCId });
                    table.ForeignKey(
                        name: "FK_TruckPerCity_CategoryC_CategoryCId",
                        column: x => x.CategoryCId,
                        principalTable: "CategoryC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckPerCity_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorCategoryLicence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryType = table.Column<byte>(type: "tinyint", nullable: false),
                    ÌnstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorCategoryLicence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstructorCategoryLicence_Instructor_ÌnstructorId",
                        column: x => x.ÌnstructorId,
                        principalTable: "Instructor",
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
                    TypeOfWorkExperience = table.Column<byte>(type: "tinyint", nullable: false),
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
                table: "CategoryC",
                columns: new[] { "Id", "Address", "City", "Phone" },
                values: new object[,]
                {
                    { 1, "bul. ASNOM 12/A", "Skopje", "+389 01 222 110" },
                    { 2, "bul. JNA 120", "Stip", "+389 01 554 2290" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "Id", "Description", "Discount", "Duration", "LicenceDescription", "Price", "TestPrice", "Type", "VirtualPracticePrice" },
                values: new object[,]
                {
                    { 1, "First and foremost, before practical driving has theoretical knowledge. That's why we offer 30 hours of classroom theory with excellent instructors. The price is $89.95 including 3 possible tests. If you don't pass these 3 tests, you will be charged $15 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card or passport is required, you must be over 21 years old, medical certificate for \"C\" category. It's also mandatory to have previously taken \"B\" category.", null, 40, null, 89.95m, 15m, (byte)0, null },
                    { 2, "You can continue with driving lessons on Polygon if you have successfully passed or previously passed the theory test. The price is $141.55$, you get 60 practical lessons at the polygon with a highly qualified and experienced instructor that you choose yourself. Also truck of your choice. The price includes the right to take the test 3 times, and then it is $25 each. If you want, you can use a virtual 3D drive-car simulator way of training just for 24.5. Currently, Only in Skopje and Shtip we have the opportunity for C category training.", (short)15, 60, null, 141.55m, 25m, (byte)1, 24.5m },
                    { 3, "The last classes before the opportunity to apply for a license are city driving classes and the test. The price is $170.00, you get 70 practical lessons with a highly qualified and experienced instructor that you choose yourself. Also truck of your choice. The price includes the right to take the test 3 times, and then it is $35 each.", (short)20, 70, "Drivers of this category of vehicles tend to do more local deliveries than large vehicles.  A category C license allows drivers to drive vehicles over 3.5 tonnes, but must not exceed 32 tonnes. Category C (or Class 2 as they are otherwise known) licences typically cover a vehicle with a cab and trailer fixed permanently together. In other words, what we would consider a ‘standard lorry’ or a rigid vehicle.", 170m, 35m, (byte)2, null }
                });

            migrationBuilder.InsertData(
                table: "Truck",
                columns: new[] { "Id", "AvailableTruck", "Color", "CylinderCapacity", "Fuel", "Model", "Photo", "Power", "Transmission", "TruckNumber", "Type", "Year" },
                values: new object[,]
                {
                    { 1, (byte)7, "White", 4249, "Diesel", "Mercedes-Benz", "mercedes-benz", (short)180, "Manual Gearbox - 6", 7011, "Atego 818", 2007 },
                    { 2, (byte)4, "Metallic", 12777, "Diesel", "Volvo", "volvo-hp", (short)600, "Splitter and Range with automated gearchanging - 12 speed", 53112, "FH", 2011 }
                });

            migrationBuilder.InsertData(
                table: "CategoryLesson",
                columns: new[] { "CategoryCId", "LessonId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 },
                    { 1, 2, 2 },
                    { 2, 2, 5 },
                    { 1, 3, 3 },
                    { 2, 3, 6 }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "Age", "CategoryCId", "Firstname", "InstructorAcademy", "Lastname", "LicenceId", "Photo", "StartedDay", "DriveExperience", "TotalWorkExperience", "TruckDriveExperience", "isBooked" },
                values: new object[,]
                {
                    { 1, (short)40, 1, "Sasko", "AMSM", "Savevski", "bdb105d4-7680-48be-95bc-ae08e8f98d69", null, "05/26/2018", (short)21, (short)10, (short)10, false },
                    { 2, (short)44, 1, "Krste", "AMSM", "Panvov", "766b3746-3388-424b-a8bb-51361ad92968", null, "04/19/2017", (short)22, (short)16, (short)17, false },
                    { 3, (short)47, 2, "Tasko", "AMSM", "Karanfilovski", "73b9547e-c1bb-4dff-b420-428756f5da01", null, "11/07/2018", (short)24, (short)16, (short)17, false }
                });

            migrationBuilder.InsertData(
                table: "TruckPerCity",
                columns: new[] { "CategoryCId", "TruckId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 3 },
                    { 1, 2, 2 },
                    { 2, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "InstructorCategoryLicence",
                columns: new[] { "Id", "CategoryType", "ÌnstructorId" },
                values: new object[,]
                {
                    { 1, (byte)1, 1 },
                    { 2, (byte)2, 1 },
                    { 3, (byte)0, 2 },
                    { 4, (byte)1, 2 },
                    { 5, (byte)2, 2 },
                    { 6, (byte)3, 2 },
                    { 7, (byte)1, 3 },
                    { 8, (byte)2, 3 }
                });

            migrationBuilder.InsertData(
                table: "WorkExperience",
                columns: new[] { "Id", "Company", "Experience", "InstructorId", "TypeOfWorkExperience" },
                values: new object[,]
                {
                    { 1, "Voznja Kumanovo", 2, 3, (byte)1 },
                    { 2, "Scania Skopje", 4, 1, (byte)1 },
                    { 3, "Vardar Express Negotino", 7, 2, (byte)1 },
                    { 4, "Polog Tetovo", 4, 2, (byte)0 },
                    { 5, "Vardar Express Negotino", 2, 3, (byte)1 },
                    { 6, "Polog Tetovo", 5, 3, (byte)1 },
                    { 7, "AAK Drive School Stip", 5, 3, (byte)0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLesson_CategoryCId",
                table: "CategoryLesson",
                column: "CategoryCId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_CategoryCId",
                table: "Instructor",
                column: "CategoryCId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCategoryLicence_ÌnstructorId",
                table: "InstructorCategoryLicence",
                column: "ÌnstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckPerCity_CategoryCId",
                table: "TruckPerCity",
                column: "CategoryCId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_InstructorId",
                table: "WorkExperience",
                column: "InstructorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryLesson");

            migrationBuilder.DropTable(
                name: "InstructorCategoryLicence");

            migrationBuilder.DropTable(
                name: "TruckPerCity");

            migrationBuilder.DropTable(
                name: "WorkExperience");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Truck");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "CategoryC");
        }
    }
}
