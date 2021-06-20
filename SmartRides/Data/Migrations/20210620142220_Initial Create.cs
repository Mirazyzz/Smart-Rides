using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRides.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Ride",
                columns: table => new
                {
                    RideId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartPointId = table.Column<int>(type: "int", nullable: false),
                    DestinationPointId = table.Column<int>(type: "int", nullable: false),
                    TotalHours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ride", x => x.RideId);
                    table.ForeignKey(
                        name: "DestinationPoint_FK",
                        column: x => x.DestinationPointId,
                        principalTable: "Location",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "StartPoint_FK",
                        column: x => x.StartPointId,
                        principalTable: "Location",
                        principalColumn: "LocationId");
                });

            migrationBuilder.CreateTable(
                name: "RideStop",
                columns: table => new
                {
                    RideStopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RideId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RideStop", x => x.RideStopId);
                    table.ForeignKey(
                        name: "Location_FK",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "Ride_FK",
                        column: x => x.RideId,
                        principalTable: "Ride",
                        principalColumn: "RideId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ride_DestinationPointId",
                table: "Ride",
                column: "DestinationPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Ride_StartPointId",
                table: "Ride",
                column: "StartPointId");

            migrationBuilder.CreateIndex(
                name: "IX_RideStop_LocationId",
                table: "RideStop",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RideStop_RideId",
                table: "RideStop",
                column: "RideId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RideStop");

            migrationBuilder.DropTable(
                name: "Ride");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
