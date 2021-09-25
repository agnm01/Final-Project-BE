using Microsoft.EntityFrameworkCore.Migrations;

namespace FE_FinalProject.Migrations
{
    public partial class addedSchoolPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SchoolPeriod",
                table: "School",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolPeriod",
                table: "School");
        }
    }
}
