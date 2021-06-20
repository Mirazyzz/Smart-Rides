using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class Change_Relationship_Between_Seat_Bus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusSeat");

            migrationBuilder.CreateTable(
                name: "AvailableSeat",
                columns: table => new
                {
                    AvailableSeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    RideScheduleId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableSeat", x => x.AvailableSeatId);
                    table.ForeignKey(
                        name: "Bus_FK",
                        column: x => x.BusId,
                        principalTable: "Bus",
                        principalColumn: "BusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableSeat_RideSchedule_RideScheduleId",
                        column: x => x.RideScheduleId,
                        principalTable: "RideSchedule",
                        principalColumn: "RideScheduleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Seat_FK",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableSeat_BusId",
                table: "AvailableSeat",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableSeat_RideScheduleId",
                table: "AvailableSeat",
                column: "RideScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableSeat_SeatId",
                table: "AvailableSeat",
                column: "SeatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailableSeat");

            migrationBuilder.CreateTable(
                name: "BusSeat",
                columns: table => new
                {
                    BusSeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusSeat", x => x.BusSeatId);
                    table.ForeignKey(
                        name: "Bus_FK",
                        column: x => x.BusId,
                        principalTable: "Bus",
                        principalColumn: "BusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Seat_FK",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusSeat_BusId",
                table: "BusSeat",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusSeat_SeatId",
                table: "BusSeat",
                column: "SeatId");
        }
    }
}
