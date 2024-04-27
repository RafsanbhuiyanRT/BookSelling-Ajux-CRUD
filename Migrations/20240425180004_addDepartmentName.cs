using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookSelling_E_Comerse.Migrations
{
    /// <inheritdoc />
    public partial class addDepartmentName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Nmae",
                table: "EmployList",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "EmpDepartment",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Sales" },
                    { 2, "Marketing" },
                    { 3, "Finance" },
                    { 4, "Human Resources" },
                    { 5, "Information Technology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmpDepartment",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmpDepartment",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmpDepartment",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmpDepartment",
                keyColumn: "DepartmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmpDepartment",
                keyColumn: "DepartmentId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EmployList",
                newName: "Nmae");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "City", "Department", "Email", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1, "Comilla", "Science", "aer@gmail.com", "Rafsan", "1213" },
                    { 2, "Dhaka", "Science", "ery@gmail.com", "Rakib", "5213" },
                    { 3, "Fani", "Bisness", "xvn@gmail.com", "Asif", "8213" }
                });
        }
    }
}
