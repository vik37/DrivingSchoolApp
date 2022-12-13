using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Migrations
{
    public partial class DrivingSchoolCategoryD_AddToDb_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "CategoryD",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    BusPhoto = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                schema: "dbo",
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
                name: "Instructor",
                schema: "dbo",
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
                    BusDriveExperience = table.Column<short>(type: "smallint", nullable: false),
                    InstructorAcademy = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    isBooked = table.Column<bool>(type: "bit", nullable: false),
                    CategoryDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_CategoryD_CategoryDId",
                        column: x => x.CategoryDId,
                        principalSchema: "dbo",
                        principalTable: "CategoryD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryLesson",
                schema: "dbo",
                columns: table => new
                {
                    CategoryDId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryLesson", x => new { x.LessonId, x.CategoryDId });
                    table.ForeignKey(
                        name: "FK_CategoryLesson_CategoryD_CategoryDId",
                        column: x => x.CategoryDId,
                        principalSchema: "dbo",
                        principalTable: "CategoryD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryLesson_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "dbo",
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorCategoryLicence",
                schema: "dbo",
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
                        principalSchema: "dbo",
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperience",
                schema: "dbo",
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
                        principalSchema: "dbo",
                        principalTable: "Instructor",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CategoryD",
                columns: new[] { "Id", "Address", "BusPhoto", "City", "Phone" },
                values: new object[,]
                {
                    { 1, "bul. ASNOM 12/A", "skopje-bus", "Skopje", "+389 01 222 110" },
                    { 2, "ul. Mirche Acev", "bitola-bus", "Bitola", "+389 21 334 667" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Lesson",
                columns: new[] { "Id", "Description", "Discount", "Duration", "LicenceDescription", "Price", "TestPrice", "Type", "VirtualPracticePrice" },
                values: new object[,]
                {
                    { 1, "First and foremost, before practical driving has theoretical knowledge. That's why we offer 50 hours of classroom theory with excellent instructors. The price is $110.45 including 3 possible tests. If you don't pass these 3 tests, you will be charged $20 each. If you have knowledge of theory or have passed theory, you can take tests directly. An ID card or passport is required, you must be over 21 years old, medical certificate for \"D\" category. It's also mandatory to have previously taken \"C\" category.", null, 50, null, 110.45m, 20m, (byte)0, null },
                    { 2, "In addition to as part of a medical examination where there is always a psychological test, an additional 15 hours of psychological training have been introduced on our part because we consider it a big responsibility to transport passengers by motor vehicle, i.e. bus. The minimum price is $5, and the test after 4 trials is charged $1 each. This class and test is mandatory before proceeding further with a polygon.", null, 15, null, 5m, 1m, (byte)1, null },
                    { 3, "You can continue with driving lessons on Polygon if you have successfully passed or previously passed the theory test. The price is $179.45$, you get 70 practical lessons at the polygon with a highly qualified and experienced instructor that you choose yourself. The price includes the right to take the test 3 times, and then it is $35 each. If you want, you can use a virtual 3D drive-car simulator way of training just for 24.5. Currently, Only in Skopje and Bitola we have the opportunity for D category training.", (short)15, 70, null, 179.45m, 35m, (byte)2, 24.5m },
                    { 4, "The last classes before the opportunity to apply for a license are city driving classes and the test. The price is $215.95, you get 90 practical lessons with a highly qualified and experienced instructor that you choose yourself. The price includes the right to take the test 3 times, and then it is $45 each.", (short)20, 90, "Different driver's licenses can be used to operate different classes of vehicles. The most common is the passenger (Class D) license, which allows you to legally operate a passenger vehicle. Motor vehicles which are constructed and designed for the carriage of more than 8 passengers in addition to the driver, with or without a trailer with a maximum authorized mass not exceeding 750 kg.", 215.95m, 45m, (byte)3, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CategoryLesson",
                columns: new[] { "CategoryDId", "LessonId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 5 },
                    { 1, 2, 2 },
                    { 2, 2, 6 },
                    { 1, 3, 3 },
                    { 2, 3, 7 },
                    { 1, 4, 4 },
                    { 2, 4, 8 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Instructor",
                columns: new[] { "Id", "Age", "BusDriveExperience", "CategoryDId", "Firstname", "InstructorAcademy", "Lastname", "LicenceId", "Photo", "StartedDay", "DriveExperience", "TotalWorkExperience", "isBooked" },
                values: new object[,]
                {
                    { 1, (short)51, (short)21, 1, "Nikola", "AMSM", "Savov", "ad618ebc-b5f2-46c2-bec6-1d130e6428ab", null, "19/11/2017", (short)28, (short)19, true },
                    { 2, (short)47, (short)18, 1, "Ramazan", "AMSM", "Serbezovski", "e364ea17-318e-42ce-b02d-bc396c2f1c78", null, "09/10/2019", (short)28, (short)17, false },
                    { 3, (short)54, (short)29, 2, "Risto", "AMSM", "Shihkov", "14eafc97-8a48-4bd0-988b-2478ea3db2a4", null, "25/04/2014", (short)35, (short)29, false },
                    { 4, (short)39, (short)9, 2, "Aleksandar", "Asvalt Bitola", "Temelkov", "7cf56071-de16-4323-82f9-f50602b02578", null, "05/02/2021", (short)21, (short)8, false }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "InstructorCategoryLicence",
                columns: new[] { "Id", "CategoryType", "ÌnstructorId" },
                values: new object[,]
                {
                    { 1, (byte)0, 1 },
                    { 2, (byte)1, 1 },
                    { 3, (byte)2, 1 },
                    { 4, (byte)3, 1 },
                    { 5, (byte)1, 2 },
                    { 6, (byte)2, 2 },
                    { 7, (byte)3, 2 },
                    { 8, (byte)1, 3 },
                    { 9, (byte)2, 3 },
                    { 10, (byte)3, 3 },
                    { 11, (byte)0, 4 },
                    { 12, (byte)1, 4 },
                    { 13, (byte)2, 4 },
                    { 14, (byte)3, 4 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "WorkExperience",
                columns: new[] { "Id", "Company", "Experience", "InstructorId", "TypeOfWorkExperience" },
                values: new object[,]
                {
                    { 1, "Avast Tourist Skopje", 2, 1, (byte)1 },
                    { 2, "JSP Skopje", 5, 1, (byte)2 },
                    { 3, "Apollo Crid", 7, 1, (byte)0 },
                    { 4, "Fabula Travel Kicevo", 1, 2, (byte)1 },
                    { 5, "Fabula Travel Kicevo", 10, 2, (byte)2 },
                    { 6, "Febro Transit Skopje", 3, 2, (byte)2 },
                    { 7, "JUGO Transport Prilep", 4, 3, (byte)1 },
                    { 8, "Prespa Turist Resen", 7, 3, (byte)2 },
                    { 9, "Vardar Travel Skopje", 2, 3, (byte)2 },
                    { 10, "Drive School Skopje", 8, 3, (byte)0 },
                    { 11, "Stoby Travel Negotino", 1, 4, (byte)1 },
                    { 12, "Nekoj Travel Bitola", 6, 4, (byte)2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLesson_CategoryDId",
                schema: "dbo",
                table: "CategoryLesson",
                column: "CategoryDId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_CategoryDId",
                schema: "dbo",
                table: "Instructor",
                column: "CategoryDId");

            migrationBuilder.CreateIndex(
                name: "XI_LicenceId",
                schema: "dbo",
                table: "Instructor",
                column: "LicenceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCategoryLicence_ÌnstructorId",
                schema: "dbo",
                table: "InstructorCategoryLicence",
                column: "ÌnstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_InstructorId",
                schema: "dbo",
                table: "WorkExperience",
                column: "InstructorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryLesson",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "InstructorCategoryLicence",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WorkExperience",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Lesson",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Instructor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CategoryD",
                schema: "dbo");
        }
    }
}
