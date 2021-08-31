using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebEntities.Migrations
{
    public partial class Int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ToPay = table.Column<decimal>(type: "numeric", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PayedEvents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ToPay = table.Column<decimal>(type: "numeric", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayedEvents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fullname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Age = table.Column<byte>(type: "smallint", nullable: true),
                    AgeGroup = table.Column<byte>(type: "smallint", nullable: false),
                    BeltColor = table.Column<byte>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AgeGroup = table.Column<byte>(type: "smallint", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ToPay = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionAttendances",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HasPayedBool = table.Column<bool>(type: "boolean", nullable: false),
                    TraineeID = table.Column<int>(type: "integer", nullable: false),
                    EventID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionAttendances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompetitionAttendances_Competitions_EventID",
                        column: x => x.EventID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionAttendances_Trainees_TraineeID",
                        column: x => x.TraineeID,
                        principalTable: "Trainees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayedEventAttendances",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HasPayedBool = table.Column<bool>(type: "boolean", nullable: false),
                    TraineeID = table.Column<int>(type: "integer", nullable: false),
                    EventID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayedEventAttendances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PayedEventAttendances_PayedEvents_EventID",
                        column: x => x.EventID,
                        principalTable: "PayedEvents",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayedEventAttendances_Trainees_TraineeID",
                        column: x => x.TraineeID,
                        principalTable: "Trainees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingAttendance",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HasPayedBool = table.Column<bool>(type: "boolean", nullable: false),
                    TraineeID = table.Column<int>(type: "integer", nullable: false),
                    EventID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingAttendance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrainingAttendance_Trainees_TraineeID",
                        column: x => x.TraineeID,
                        principalTable: "Trainees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingAttendance_Trainings_EventID",
                        column: x => x.EventID,
                        principalTable: "Trainings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionPayments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PayedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    AttendanceID = table.Column<int>(type: "integer", nullable: false),
                    TraineeID = table.Column<int>(type: "integer", nullable: false),
                    EventID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionPayments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompetitionPayments_CompetitionAttendances_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "CompetitionAttendances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionPayments_Competitions_EventID",
                        column: x => x.EventID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionPayments_Trainees_TraineeID",
                        column: x => x.TraineeID,
                        principalTable: "Trainees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayedEventPayments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PayedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    AttendanceID = table.Column<int>(type: "integer", nullable: false),
                    TraineeID = table.Column<int>(type: "integer", nullable: false),
                    EventID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayedEventPayments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PayedEventPayments_PayedEventAttendances_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "PayedEventAttendances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayedEventPayments_PayedEvents_EventID",
                        column: x => x.EventID,
                        principalTable: "PayedEvents",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayedEventPayments_Trainees_TraineeID",
                        column: x => x.TraineeID,
                        principalTable: "Trainees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPayments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTimePayed = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TimePayed = table.Column<TimeSpan>(type: "interval", nullable: false),
                    PayedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    AttendanceID = table.Column<int>(type: "integer", nullable: false),
                    TraineeID = table.Column<int>(type: "integer", nullable: false),
                    EventID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPayments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrainingPayments_Trainees_TraineeID",
                        column: x => x.TraineeID,
                        principalTable: "Trainees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPayments_TrainingAttendance_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "TrainingAttendance",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPayments_Trainings_EventID",
                        column: x => x.EventID,
                        principalTable: "Trainings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionAttendances_EventID",
                table: "CompetitionAttendances",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionAttendances_TraineeID",
                table: "CompetitionAttendances",
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
                name: "IX_PayedEventAttendances_EventID",
                table: "PayedEventAttendances",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_PayedEventAttendances_TraineeID",
                table: "PayedEventAttendances",
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
                name: "IX_TrainingAttendance_EventID",
                table: "TrainingAttendance",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingAttendance_TraineeID",
                table: "TrainingAttendance",
                column: "TraineeID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetitionPayments");

            migrationBuilder.DropTable(
                name: "PayedEventPayments");

            migrationBuilder.DropTable(
                name: "TrainingPayments");

            migrationBuilder.DropTable(
                name: "CompetitionAttendances");

            migrationBuilder.DropTable(
                name: "PayedEventAttendances");

            migrationBuilder.DropTable(
                name: "TrainingAttendance");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "PayedEvents");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Trainings");
        }
    }
}
