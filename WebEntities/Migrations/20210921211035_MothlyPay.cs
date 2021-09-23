using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEntities.Migrations
{
    public partial class MothlyPay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyPass",
                table: "Trainings",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TrainingPayments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PayedEventPayments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CompetitionPayments",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthlyPass",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TrainingPayments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PayedEventPayments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CompetitionPayments");
        }
    }
}
