using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class AddDriverBusEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bus",
                columns: table => new
                {
                    BusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatCount = table.Column<int>(type: "int", nullable: false),
                    FloorCount = table.Column<int>(type: "int", nullable: false),
                    HasAirCondition = table.Column<bool>(type: "bit", nullable: false),
                    HasCharger = table.Column<bool>(type: "bit", nullable: false),
                    HasBuffet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus", x => x.BusId);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                    table.ForeignKey(
                        name: "Driver_FK",
                        column: x => x.BusId,
                        principalTable: "Bus",
                        principalColumn: "BusId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Driver_BusId",
                table: "Driver",
                column: "BusId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Bus");
        }
    }
}
