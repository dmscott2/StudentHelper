using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentHelper.Migrations
{
    public partial class Updated13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignmentDesc",
                table: "StudentAssignments",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentDesc",
                table: "StudentAssignments");
        }
    }
}
