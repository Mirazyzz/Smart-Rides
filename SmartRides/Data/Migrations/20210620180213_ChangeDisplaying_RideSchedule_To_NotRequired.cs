using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class ChangeDisplaying_RideSchedule_To_NotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Displaying_RideSchedule_DisplayingId",
                table: "Displaying");

            migrationBuilder.AddForeignKey(
                name: "FK_Displaying_RideSchedule_DisplayingId",
                table: "Displaying",
                column: "DisplayingId",
                principalTable: "RideSchedule",
                principalColumn: "RideScheduleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Displaying_RideSchedule_DisplayingId",
                table: "Displaying");

            migrationBuilder.AddForeignKey(
                name: "FK_Displaying_RideSchedule_DisplayingId",
                table: "Displaying",
                column: "DisplayingId",
                principalTable: "RideSchedule",
                principalColumn: "RideScheduleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
