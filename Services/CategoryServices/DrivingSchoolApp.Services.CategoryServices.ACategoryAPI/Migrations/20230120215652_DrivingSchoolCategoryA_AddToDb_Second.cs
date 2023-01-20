using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Migrations
{
    public partial class DrivingSchoolCategoryA_AddToDb_Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenceId",
                table: "Instructor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LicenceId",
                table: "Instructor",
                type: "nvarchar(1150)",
                maxLength: 1150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "LicenceId",
                value: "39ff30b1-c444-4c68-87ee-cc2aab3ea621");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "LicenceId",
                value: "2ba87e71-1a1b-4457-9571-7d5603ffd5c9");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "LicenceId",
                value: "28ea30a1-fab2-46f4-90aa-46306cbae26d");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "LicenceId",
                value: "7260b77a-9d58-45f5-99f5-4cd1cac42899");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "LicenceId",
                value: "6488955b-26e0-4ca2-9093-4b1794b8caca");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "LicenceId",
                value: "962eb826-0fc8-4037-bb01-056a90e84257");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "LicenceId",
                value: "cdf71027-ecb5-4f6d-ba03-f7beb357ca84");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "LicenceId",
                value: "c2033c8b-78f3-4084-bb44-baaba228d8f2");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "LicenceId",
                value: "c720c512-2187-42ba-bc6b-61474a2d9fba");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "LicenceId",
                value: "ea6c9280-de1a-4022-915c-3cc7e6e5b59c");

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "LicenceId",
                value: "1f999c4b-da54-412f-893d-8663e58c12a3");
        }
    }
}
