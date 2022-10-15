using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RP.DataAccess.EFCore.Migrations
{
    public partial class SeedingEmpployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Gender", "Name", "Salary" },
                values: new object[] { 1, "Male", "Adam", null });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Gender", "Name", "Salary" },
                values: new object[] { 2, "Female", "Alice", null });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Gender", "Name", "Salary" },
                values: new object[] { 3, "Male", "John", null });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Gender", "Name", "Salary" },
                values: new object[] { 4, "Female", "Jane", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
