using Microsoft.EntityFrameworkCore.Migrations;

namespace CAPSPOL.API.Migrations
{
    public partial class AddColumnFlagToGrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Flag",
                table: "Grades",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flag",
                table: "Grades");
        }
    }
}
