using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class Add_RideDate_RideSchedule_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RideDate",
                columns: table => new
                {
                    RideDateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RideId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RideDate", x => x.RideDateId);
                    table.ForeignKey(
                        name: "RideDate_Ride_FK",
                        column: x => x.RideId,
                        principalTable: "Ride",
                        principalColumn: "RideId");
                });

            migrationBuilder.CreateTable(
                name: "RideSchedule",
                columns: table => new
                {
                    RideScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RideDateId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RideSchedule", x => x.RideScheduleId);
                    table.ForeignKey(
                        name: "RideDate_FK",
                        column: x => x.RideDateId,
                        principalTable: "RideDate",
                        principalColumn: "RideDateId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RideDate_RideId",
                table: "RideDate",
                column: "RideId");

            migrationBuilder.CreateIndex(
                name: "IX_RideSchedule_RideDateId",
                table: "RideSchedule",
                column: "RideDateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RideSchedule");

            migrationBuilder.DropTable(
                name: "RideDate");
        }
    }
}
