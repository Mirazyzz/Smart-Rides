using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class Change_Displaying_RideSchedule_Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Displaying",
                columns: table => new
                {
                    DisplayingId = table.Column<int>(type: "int", nullable: false),
                    IsDeparted = table.Column<bool>(type: "bit", nullable: false),
                    AvailableSeatsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displaying", x => x.DisplayingId);
                    table.ForeignKey(
                        name: "FK_Displaying_RideSchedule_DisplayingId",
                        column: x => x.DisplayingId,
                        principalTable: "RideSchedule",
                        principalColumn: "RideScheduleId",
                        onDelete: ReferentialAction.Cascade);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Displaying_FK",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Displaying");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_DisplayingId",
                table: "Ticket");
        }
    }
}
