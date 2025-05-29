using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlannerr.Migrations
{
    /// <inheritdoc />
    public partial class lastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Destinations_DestinationId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_TripDestinations_Destinations_DestinationId",
                table: "TripDestinations");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Trips");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Trips",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DestinationId1",
                table: "Trips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Trips",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "TripDestinations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DestinationId1",
                table: "TripDestinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelId1",
                table: "TripDestinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripId1",
                table: "TripDestinations",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Hotels",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerNight",
                table: "Hotels",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "ImagePath",
                keyValue: null,
                column: "ImagePath",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Destinations",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Destinations",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BestTimeToVisit",
                table: "Destinations",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "AverageRating",
                table: "Destinations",
                type: "decimal(3,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DestinationId1",
                table: "Trips",
                column: "DestinationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_HotelId",
                table: "Trips",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_TripDestinations_DestinationId1",
                table: "TripDestinations",
                column: "DestinationId1");

            migrationBuilder.CreateIndex(
                name: "IX_TripDestinations_HotelId1",
                table: "TripDestinations",
                column: "HotelId1");

            migrationBuilder.CreateIndex(
                name: "IX_TripDestinations_TripId1",
                table: "TripDestinations",
                column: "TripId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Destinations_DestinationId",
                table: "Hotels",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripDestinations_Destinations_DestinationId",
                table: "TripDestinations",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TripDestinations_Destinations_DestinationId1",
                table: "TripDestinations",
                column: "DestinationId1",
                principalTable: "Destinations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TripDestinations_Hotels_HotelId1",
                table: "TripDestinations",
                column: "HotelId1",
                principalTable: "Hotels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TripDestinations_Trips_TripId1",
                table: "TripDestinations",
                column: "TripId1",
                principalTable: "Trips",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Destinations_DestinationId1",
                table: "Trips",
                column: "DestinationId1",
                principalTable: "Destinations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Hotels_HotelId",
                table: "Trips",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Destinations_DestinationId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_TripDestinations_Destinations_DestinationId",
                table: "TripDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_TripDestinations_Destinations_DestinationId1",
                table: "TripDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_TripDestinations_Hotels_HotelId1",
                table: "TripDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_TripDestinations_Trips_TripId1",
                table: "TripDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Destinations_DestinationId1",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Hotels_HotelId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_DestinationId1",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_HotelId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_TripDestinations_DestinationId1",
                table: "TripDestinations");

            migrationBuilder.DropIndex(
                name: "IX_TripDestinations_HotelId1",
                table: "TripDestinations");

            migrationBuilder.DropIndex(
                name: "IX_TripDestinations_TripId1",
                table: "TripDestinations");

            migrationBuilder.DropColumn(
                name: "DestinationId1",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "DestinationId1",
                table: "TripDestinations");

            migrationBuilder.DropColumn(
                name: "HotelId1",
                table: "TripDestinations");

            migrationBuilder.DropColumn(
                name: "TripId1",
                table: "TripDestinations");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Trips",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "Budget",
                table: "Trips",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "TripDestinations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Hotels",
                type: "decimal(3,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerNight",
                table: "Hotels",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Destinations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Destinations",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BestTimeToVisit",
                table: "Destinations",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "AverageRating",
                table: "Destinations",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Destinations_DestinationId",
                table: "Hotels",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TripDestinations_Destinations_DestinationId",
                table: "TripDestinations",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id");
        }
    }
}
