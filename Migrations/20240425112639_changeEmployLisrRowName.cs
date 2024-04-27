using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookSelling_E_Comerse.Migrations
{
    /// <inheritdoc />
    public partial class changeEmployLisrRowName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "EmployList",
                newName: "Nmae");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "EmployList",
                newName: "EmployId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployList",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nmae",
                table: "EmployList",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "EmployId",
                table: "EmployList",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EmployList",
                newName: "EmployeeId");
        }
    }
}
