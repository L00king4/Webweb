using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEntities.Migrations
{
    public partial class BirthDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Trainees");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Trainees",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Trainees");

            migrationBuilder.AddColumn<byte>(
                name: "Age",
                table: "Trainees",
                type: "smallint",
                nullable: true);
        }
    }
}
