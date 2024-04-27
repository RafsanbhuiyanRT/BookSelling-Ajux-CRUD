using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookSelling_E_Comerse.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "DisplayOreder", "Name" },
                values: new object[,]
                {
                    { 1, "5", "Action" },
                    { 2, "3", "Program" },
                    { 3, "2", "History" }
                });
        }
    }
}
