using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class DropDisplaying : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Displaying_FK",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Displaying");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_DisplayingId",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "DisplayingId",
                table: "RideSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayingId",
                table: "RideSchedule");

            migrationBuilder.CreateTable(
                name: "Displaying",
                columns: table => new
                {
                    DisplayingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableSeatsCount = table.Column<int>(type: "int", nullable: false),
                    IsDeparted = table.Column<bool>(type: "bit", nullable: false),
                    RideScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displaying", x => x.DisplayingId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_DisplayingId",
                table: "Ticket",
                column: "DisplayingId");

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
