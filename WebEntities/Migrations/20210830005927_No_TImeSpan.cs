using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEntities.Migrations
{
    public partial class No_TImeSpan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimePayed",
                table: "TrainingPayments");

            migrationBuilder.AddColumn<DateTime>(
                name: "SpanPayedEnd",
                table: "TrainingPayments",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpanPayedEnd",
                table: "TrainingPayments");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimePayed",
                table: "TrainingPayments",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
