using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreBasics.Migrations
{
    /// <inheritdoc />
    public partial class updateproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Project_ProjectId",
                table: "EmployeeProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectId",
                table: "EmployeeProject",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectId",
                table: "EmployeeProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Project_ProjectId",
                table: "EmployeeProject",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
