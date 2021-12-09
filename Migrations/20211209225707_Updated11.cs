using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentHelper.Migrations
{
    public partial class Updated11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AssignmentDueDate",
                table: "StudentAssignments",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentDueDate",
                table: "StudentAssignments");
        }
    }
}
