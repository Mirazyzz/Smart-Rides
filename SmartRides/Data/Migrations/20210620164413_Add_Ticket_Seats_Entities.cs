using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class Add_Ticket_Seats_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscountReason",
                columns: table => new
                {
                    DiscountReasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountReason", x => x.DiscountReasonId);
                });

            migrationBuilder.CreateTable(
                name: "Displaying",
                columns: table => new
                {
                    DisplayingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RideScheduleId = table.Column<int>(type: "int", nullable: false),
                    IsDeparted = table.Column<bool>(type: "bit", nullable: false),
                    AvailableSeatsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displaying", x => x.DisplayingId);
                });

            migrationBuilder.CreateTable(
                name: "TicketClassAttribute",
                columns: table => new
                {
                    TicketClassAttributeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketClassAttribute", x => x.TicketClassAttributeId);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TicketClassAttributeId = table.Column<int>(type: "int", nullable: false),
                    DiscountReasonId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DisplayingId = table.Column<int>(type: "int", nullable: false),
                    TicketStatus = table.Column<int>(type: "int", nullable: false),
                    TicketType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "Customer_FK",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "DiscountReason_FK",
                        column: x => x.DiscountReasonId,
                        principalTable: "DiscountReason",
                        principalColumn: "DiscountReasonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Displaying_FK",
                        column: x => x.DisplayingId,
                        principalTable: "Displaying",
                        principalColumn: "DisplayingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "TicketClassAttribute_FK",
                        column: x => x.TicketClassAttributeId,
                        principalTable: "TicketClassAttribute",
                        principalColumn: "TicketClassAttributeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketSeat",
                columns: table => new
                {
                    TicketSeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketSeat", x => x.TicketSeatId);
                    table.ForeignKey(
                        name: "FK_TicketSeat_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketSeat_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CustomerId",
                table: "Ticket",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_DiscountReasonId",
                table: "Ticket",
                column: "DiscountReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_DisplayingId",
                table: "Ticket",
                column: "DisplayingId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketClassAttributeId",
                table: "Ticket",
                column: "TicketClassAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSeat_SeatId",
                table: "TicketSeat",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSeat_TicketId",
                table: "TicketSeat",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketSeat");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "DiscountReason");

            migrationBuilder.DropTable(
                name: "Displaying");

            migrationBuilder.DropTable(
                name: "TicketClassAttribute");
        }
    }
}
