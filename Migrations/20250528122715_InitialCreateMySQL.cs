using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelPlannerr.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateMySQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BestTimeToVisit = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AverageRating = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ReviewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PricePerNight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ImagePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "AverageRating", "BestTimeToVisit", "City", "Country", "Description", "ImagePath", "Name", "ReviewCount" },
                values: new object[,]
                {
                    { 1, 4.8m, "Apr-Jun, Sep-Oct", "Paris", "France", "The City of Light offers iconic landmarks like the Eiffel Tower, world-class museums, charming cafés, and romantic Seine river cruises.", "https://images.unsplash.com/photo-1502602898536-47ad22581b52?w=800&h=600&fit=crop", "Paris", 2156 },
                    { 2, 4.9m, "Mar-May, Sep-Nov", "Tokyo", "Japan", "A vibrant metropolis blending ancient traditions with cutting-edge technology, featuring incredible cuisine, temples, and modern skyscrapers.", "https://images.unsplash.com/photo-1540959733332-eab4deabeeaf?w=800&h=600&fit=crop", "Tokyo", 1843 },
                    { 3, 4.7m, "Apr-Jun, Sep-Nov", "New York", "USA", "The city that never sleeps offers Broadway shows, world-famous museums, Central Park, and the iconic Statue of Liberty.", "https://images.unsplash.com/photo-1496442226666-8d4d0e62e6e9?w=800&h=600&fit=crop", "New York", 3241 },
                    { 4, 4.6m, "Nov-Apr", "Dubai", "UAE", "A luxury destination with stunning architecture, world-class shopping, desert adventures, and pristine beaches.", "https://images.unsplash.com/photo-1512453979798-5ea266f8880c?w=800&h=600&fit=crop", "Dubai", 1567 },
                    { 5, 4.8m, "Apr-Jun, Sep-Oct", "Rome", "Italy", "The Eternal City showcases ancient history with the Colosseum, Vatican City, incredible cuisine, and Renaissance art.", "https://images.unsplash.com/photo-1552832230-c0197dd311b5?w=800&h=600&fit=crop", "Rome", 2890 },
                    { 6, 4.9m, "Apr-Oct", "Denpasar", "Indonesia", "Tropical paradise with stunning beaches, ancient temples, lush rice terraces, and vibrant culture perfect for relaxation.", "https://images.unsplash.com/photo-1537953773345-d172ccf13cf1?w=800&h=600&fit=crop", "Bali", 1234 }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Description", "DestinationId", "ImagePath", "Name", "PricePerNight", "Rating" },
                values: new object[,]
                {
                    { 1, "228 Rue de Rivoli, Paris", "Luxury hotel near Louvre", 1, "https://images.unsplash.com/photo-1564501049412-61c2a3083791?w=400&h=300&fit=crop", "Hotel Le Meurice", 450m, 4.8m },
                    { 2, "17 Boulevard Poissonnière, Paris", "Boutique hotel in historic district", 1, "https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=400&h=300&fit=crop", "Hotel des Grands Boulevards", 220m, 4.5m },
                    { 3, "3-7-1-2 Nishi Shinjuku, Tokyo", "Luxury hotel with city views", 2, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=400&h=300&fit=crop", "Park Hyatt Tokyo", 380m, 4.9m },
                    { 4, "1-12-2 Dogenzaka, Shibuya, Tokyo", "Modern hotel in Shibuya", 2, "https://images.unsplash.com/photo-1578662996442-48f60103fc96?w=400&h=300&fit=crop", "Shibuya Excel Hotel Tokyu", 180m, 4.3m },
                    { 5, "768 5th Ave, New York", "Iconic luxury hotel", 3, "https://images.unsplash.com/photo-1542314831-068cd1dbfeeb?w=400&h=300&fit=crop", "The Plaza", 520m, 4.7m },
                    { 6, "230 E 51st St, New York", "Modern budget-friendly option", 3, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=400&h=300&fit=crop", "Pod Hotels", 120m, 4.2m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_DestinationId",
                table: "Hotels",
                column: "DestinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
