using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RP.DataAccess.EFCore.Migrations
{
    public partial class AddKeysAndShortenEmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Developers",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Developers",
                newName: "EmployeeID");
        }
    }
}
