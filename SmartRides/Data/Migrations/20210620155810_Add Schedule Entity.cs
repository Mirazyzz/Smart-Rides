using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class AddScheduleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "RideSchedule");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "RideSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RideSchedule_ScheduleId",
                table: "RideSchedule",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "Schedule_FK",
                table: "RideSchedule",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Schedule_FK",
                table: "RideSchedule");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_RideSchedule_ScheduleId",
                table: "RideSchedule");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "RideSchedule");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "RideSchedule",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
