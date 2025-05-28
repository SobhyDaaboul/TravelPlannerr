using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlannerr.Migrations
{
    /// <inheritdoc />
    public partial class AddTripPOPup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Trips",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_HotelId",
                table: "Trips",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Hotels_HotelId",
                table: "Trips",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Hotels_HotelId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_HotelId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Trips");
        }
    }
}
