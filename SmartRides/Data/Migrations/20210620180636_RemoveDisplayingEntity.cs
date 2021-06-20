using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class RemoveDisplayingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Displaying_FK",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Displaying");

            migrationBuilder.RenameColumn(
                name: "DisplayingId",
                table: "Ticket",
                newName: "RideScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_DisplayingId",
                table: "Ticket",
                newName: "IX_Ticket_RideScheduleId");

            migrationBuilder.AddForeignKey(
                name: "RideSchedule_FK",
                table: "Ticket",
                column: "RideScheduleId",
                principalTable: "RideSchedule",
                principalColumn: "RideScheduleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "RideSchedule_FK",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "RideScheduleId",
                table: "Ticket",
                newName: "DisplayingId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_RideScheduleId",
                table: "Ticket",
                newName: "IX_Ticket_DisplayingId");

            migrationBuilder.CreateTable(
                name: "Displaying",
                columns: table => new
                {
                    DisplayingId = table.Column<int>(type: "int", nullable: false),
                    AvailableSeatsCount = table.Column<int>(type: "int", nullable: false),
                    IsDeparted = table.Column<bool>(type: "bit", nullable: false),
                    StandardPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displaying", x => x.DisplayingId);
                    table.ForeignKey(
                        name: "FK_Displaying_RideSchedule_DisplayingId",
                        column: x => x.DisplayingId,
                        principalTable: "RideSchedule",
                        principalColumn: "RideScheduleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddForeignKey(
                name: "Displaying_FK",
                table: "Ticket",
                column: "DisplayingId",
                principalTable: "Displaying",
                principalColumn: "DisplayingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
