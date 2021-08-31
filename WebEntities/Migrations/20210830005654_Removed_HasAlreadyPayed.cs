using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEntities.Migrations
{
    public partial class Removed_HasAlreadyPayed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionAttendances_Trainees_TraineeID",
                table: "CompetitionAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionPayments_CompetitionAttendances_AttendanceID",
                table: "CompetitionPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionPayments_Competitions_EventID",
                table: "CompetitionPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionPayments_Trainees_TraineeID",
                table: "CompetitionPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_PayedEventAttendances_Trainees_TraineeID",
                table: "PayedEventAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_PayedEventPayments_PayedEventAttendances_AttendanceID",
                table: "PayedEventPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_PayedEventPayments_PayedEvents_EventID",
                table: "PayedEventPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_PayedEventPayments_Trainees_TraineeID",
                table: "PayedEventPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingAttendance_Trainees_TraineeID",
                table: "TrainingAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPayments_Trainees_TraineeID",
                table: "TrainingPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPayments_TrainingAttendance_AttendanceID",
                table: "TrainingPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPayments_Trainings_EventID",
                table: "TrainingPayments");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPayments_AttendanceID",
                table: "TrainingPayments");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPayments_EventID",
                table: "TrainingPayments");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPayments_TraineeID",
                table: "TrainingPayments");

            migrationBuilder.DropIndex(
                name: "IX_TrainingAttendance_TraineeID",
                table: "TrainingAttendance");

            migrationBuilder.DropIndex(
                name: "IX_PayedEventPayments_AttendanceID",
                table: "PayedEventPayments");

            migrationBuilder.DropIndex(
                name: "IX_PayedEventPayments_EventID",
                table: "PayedEventPayments");

            migrationBuilder.DropIndex(
                name: "IX_PayedEventPayments_TraineeID",
                table: "PayedEventPayments");

            migrationBuilder.DropIndex(
                name: "IX_PayedEventAttendances_TraineeID",
                table: "PayedEventAttendances");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionPayments_AttendanceID",
                table: "CompetitionPayments");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionPayments_EventID",
                table: "CompetitionPayments");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionPayments_TraineeID",
                table: "CompetitionPayments");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionAttendances_TraineeID",
                table: "CompetitionAttendances");

            migrationBuilder.DropColumn(
                name: "HasPayedBool",
                table: "TrainingAttendance");

            migrationBuilder.DropColumn(
                name: "HasPayedBool",
                table: "PayedEventAttendances");

            migrationBuilder.DropColumn(
                name: "HasPayedBool",
                table: "CompetitionAttendances");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasPayedBool",
                table: "TrainingAttendance",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPayedBool",
                table: "PayedEventAttendances",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPayedBool",
                table: "CompetitionAttendances",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPayments_AttendanceID",
                table: "TrainingPayments",
                column: "AttendanceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPayments_EventID",
                table: "TrainingPayments",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPayments_TraineeID",
                table: "TrainingPayments",
                column: "TraineeID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingAttendance_TraineeID",
                table: "TrainingAttendance",
                column: "TraineeID");

            migrationBuilder.CreateIndex(
                name: "IX_PayedEventPayments_AttendanceID",
                table: "PayedEventPayments",
                column: "AttendanceID");

            migrationBuilder.CreateIndex(
                name: "IX_PayedEventPayments_EventID",
                table: "PayedEventPayments",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_PayedEventPayments_TraineeID",
                table: "PayedEventPayments",
                column: "TraineeID");

            migrationBuilder.CreateIndex(
                name: "IX_PayedEventAttendances_TraineeID",
                table: "PayedEventAttendances",
                column: "TraineeID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionPayments_AttendanceID",
                table: "CompetitionPayments",
                column: "AttendanceID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionPayments_EventID",
                table: "CompetitionPayments",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionPayments_TraineeID",
                table: "CompetitionPayments",
                column: "TraineeID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionAttendances_TraineeID",
                table: "CompetitionAttendances",
                column: "TraineeID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionAttendances_Trainees_TraineeID",
                table: "CompetitionAttendances",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionPayments_CompetitionAttendances_AttendanceID",
                table: "CompetitionPayments",
                column: "AttendanceID",
                principalTable: "CompetitionAttendances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionPayments_Competitions_EventID",
                table: "CompetitionPayments",
                column: "EventID",
                principalTable: "Competitions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionPayments_Trainees_TraineeID",
                table: "CompetitionPayments",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayedEventAttendances_Trainees_TraineeID",
                table: "PayedEventAttendances",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayedEventPayments_PayedEventAttendances_AttendanceID",
                table: "PayedEventPayments",
                column: "AttendanceID",
                principalTable: "PayedEventAttendances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayedEventPayments_PayedEvents_EventID",
                table: "PayedEventPayments",
                column: "EventID",
                principalTable: "PayedEvents",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayedEventPayments_Trainees_TraineeID",
                table: "PayedEventPayments",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingAttendance_Trainees_TraineeID",
                table: "TrainingAttendance",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPayments_Trainees_TraineeID",
                table: "TrainingPayments",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPayments_TrainingAttendance_AttendanceID",
                table: "TrainingPayments",
                column: "AttendanceID",
                principalTable: "TrainingAttendance",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPayments_Trainings_EventID",
                table: "TrainingPayments",
                column: "EventID",
                principalTable: "Trainings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
