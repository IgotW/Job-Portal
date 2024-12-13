using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_System.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Companies",
                newName: "CompanyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Candidates",
                newName: "CandidateID");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Candidates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Companies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CandidateID",
                table: "Candidates",
                newName: "Id");
        }
    }
}
