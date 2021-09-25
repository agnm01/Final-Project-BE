using Microsoft.EntityFrameworkCore.Migrations;

namespace FE_FinalProject.Migrations
{
    public partial class addedSomeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "Profile",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Profile",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Profile",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Profile",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Profile");
        }
    }
}
