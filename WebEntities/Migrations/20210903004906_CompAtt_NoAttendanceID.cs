using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEntities.Migrations
{
    public partial class CompAtt_NoAttendanceID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionAttendances_Competitions_EventID",
                table: "CompetitionAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_PayedEventAttendances_PayedEvents_EventID",
                table: "PayedEventAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingAttendance_Trainings_EventID",
                table: "TrainingAttendance");

            migrationBuilder.DropIndex(
                name: "IX_TrainingAttendance_EventID",
                table: "TrainingAttendance");

            migrationBuilder.DropIndex(
                name: "IX_PayedEventAttendances_EventID",
                table: "PayedEventAttendances");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionAttendances_EventID",
                table: "CompetitionAttendances");

            migrationBuilder.DropColumn(
                name: "AttendanceID",
                table: "TrainingPayments");

            migrationBuilder.DropColumn(
                name: "AttendanceID",
                table: "PayedEventPayments");

            migrationBuilder.DropColumn(
                name: "AttendanceID",
                table: "CompetitionPayments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttendanceID",
                table: "TrainingPayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttendanceID",
                table: "PayedEventPayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttendanceID",
                table: "CompetitionPayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingAttendance_EventID",
                table: "TrainingAttendance",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_PayedEventAttendances_EventID",
                table: "PayedEventAttendances",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionAttendances_EventID",
                table: "CompetitionAttendances",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionAttendances_Competitions_EventID",
                table: "CompetitionAttendances",
                column: "EventID",
                principalTable: "Competitions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayedEventAttendances_PayedEvents_EventID",
                table: "PayedEventAttendances",
                column: "EventID",
                principalTable: "PayedEvents",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingAttendance_Trainings_EventID",
                table: "TrainingAttendance",
                column: "EventID",
                principalTable: "Trainings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
