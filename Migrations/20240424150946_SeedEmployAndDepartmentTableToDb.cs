using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookSelling_E_Comerse.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployAndDepartmentTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpDepartment", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "EmployList",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroup = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false),
                    EmpDepartmentDepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployList", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_EmployList_EmpDepartment_EmpDepartmentDepartmentId",
                        column: x => x.EmpDepartmentDepartmentId,
                        principalTable: "EmpDepartment",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployList_EmpDepartmentDepartmentId",
                table: "EmployList",
                column: "EmpDepartmentDepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployList");

            migrationBuilder.DropTable(
                name: "EmpDepartment");
        }
    }
}
