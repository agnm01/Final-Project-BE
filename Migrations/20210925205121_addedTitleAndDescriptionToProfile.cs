using Microsoft.EntityFrameworkCore.Migrations;

namespace FE_FinalProject.Migrations
{
    public partial class addedTitleAndDescriptionToProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Profile",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Profile",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Profile");
        }
    }
}
