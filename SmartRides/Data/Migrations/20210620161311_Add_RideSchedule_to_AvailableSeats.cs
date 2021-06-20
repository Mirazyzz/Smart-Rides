using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class Add_RideSchedule_to_AvailableSeats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableSeat_RideSchedule_RideScheduleId",
                table: "AvailableSeat");

            migrationBuilder.AddForeignKey(
                name: "AvailableSeat_FK",
                table: "AvailableSeat",
                column: "RideScheduleId",
                principalTable: "RideSchedule",
                principalColumn: "RideScheduleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "AvailableSeat_FK",
                table: "AvailableSeat");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableSeat_RideSchedule_RideScheduleId",
                table: "AvailableSeat",
                column: "RideScheduleId",
                principalTable: "RideSchedule",
                principalColumn: "RideScheduleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
