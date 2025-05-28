using Microsoft.EntityFrameworkCore;
using TravelPlannerr.Models;



namespace TravelPlannerr.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            // Ensure database is created
            await context.Database.EnsureCreatedAsync();

            // Check if data already exists
            if (await context.Destinations.AnyAsync())
            {
                return; // Database has been seeded
            }

            // Sample Destinations
            var destinations = new List<Destination>
            {
                new Destination
                {
                    Name = "Eiffel Tower",
                    City = "Paris",
                    Country = "France",
                    Description = "The iconic iron lattice tower built in 1889, offering breathtaking views of Paris. A symbol of romance and French culture, perfect for couples and photography enthusiasts.",
                    ImagePath = "/images/destinations/eiffel-tower.jpg",
                    BestTimeToVisit = "Apr-Jun, Sep-Oct",
                    AverageRating = 4.6m,
                    ReviewCount = 15420
                },
                new Destination
                {
                    Name = "Santorini",
                    City = "Santorini",
                    Country = "Greece",
                    Description = "A stunning volcanic island known for its white-washed buildings, blue domes, and spectacular sunsets. Famous for its romantic atmosphere and unique architecture.",
                    ImagePath = "/images/destinations/santorini.jpg",
                    BestTimeToVisit = "Apr-Jun, Sep-Oct",
                    AverageRating = 4.8m,
                    ReviewCount = 12350
                },
                new Destination
                {
                    Name = "Machu Picchu",
                    City = "Cusco",
                    Country = "Peru",
                    Description = "An ancient Inca citadel set high in the Andes Mountains. A UNESCO World Heritage site offering incredible history and mountain views.",
                    ImagePath = "/images/destinations/machu-picchu.jpg",
                    BestTimeToVisit = "May-Sep",
                    AverageRating = 4.9m,
                    ReviewCount = 8750
                },
                new Destination
                {
                    Name = "Tokyo Skytree",
                    City = "Tokyo",
                    Country = "Japan",
                    Description = "The world's second tallest structure offering panoramic views of Tokyo. Experience modern Japanese culture and amazing city landscapes.",
                    ImagePath = "/images/destinations/tokyo-skytree.jpg",
                    BestTimeToVisit = "Mar-May, Sep-Nov",
                    AverageRating = 4.5m,
                    ReviewCount = 9840
                },
                new Destination
                {
                    Name = "Great Wall of China",
                    City = "Beijing",
                    Country = "China",
                    Description = "One of the most famous landmarks in the world, this ancient fortification stretches over 13,000 miles through Chinese countryside.",
                    ImagePath = "/images/destinations/great-wall.jpg",
                    BestTimeToVisit = "Apr-Jun, Sep-Oct",
                    AverageRating = 4.7m,
                    ReviewCount = 11200
                },
                new Destination
                {
                    Name = "Burj Khalifa",
                    City = "Dubai",
                    Country = "UAE",
                    Description = "The world's tallest building standing at 828 meters. Experience luxury shopping, fine dining, and breathtaking views of Dubai's skyline.",
                    ImagePath = "/images/destinations/burj-khalifa.jpg",
                    BestTimeToVisit = "Nov-Mar",
                    AverageRating = 4.4m,
                    ReviewCount = 7650
                },
                new Destination
                {
                    Name = "Colosseum",
                    City = "Rome",
                    Country = "Italy",
                    Description = "An ancient amphitheater and one of the most iconic symbols of Imperial Rome. Experience gladiator history and Roman architecture.",
                    ImagePath = "/images/destinations/colosseum.jpg",
                    BestTimeToVisit = "Apr-Jun, Sep-Oct",
                    AverageRating = 4.5m,
                    ReviewCount = 13580
                },
                new Destination
                {
                    Name = "Statue of Liberty",
                    City = "New York",
                    Country = "USA",
                    Description = "A symbol of freedom and democracy, this iconic statue welcomes visitors to New York Harbor with stunning views of Manhattan.",
                    ImagePath = "/images/destinations/statue-liberty.jpg",
                    BestTimeToVisit = "May-Oct",
                    AverageRating = 4.3m,
                    ReviewCount = 9920
                }
            };

            // Add destinations to context
            await context.Destinations.AddRangeAsync(destinations);
            await context.SaveChangesAsync();

            // Sample Hotels for each destination
            var hotels = new List<Hotel>();

            // Hotels for Paris (Eiffel Tower)
            // Hotels for Paris
            // Hotels for Paris
        var parisDestination = destinations.First(d => d.City == "Paris");
        hotels.AddRange(new[]
                {
        new Hotel
        {
            Name = "Hotel Plaza Athénée",
            PricePerNight = 850.00m,
            Rating = 4.8m,
            Address = "25 Avenue Montaigne, 75008 Paris",
            DestinationId = parisDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1582719478190-ef42f1a6e2e8?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Le Meurice",
            PricePerNight = 720.00m,
            Rating = 4.7m,
            Address = "228 Rue de Rivoli, 75001 Paris",
            DestinationId = parisDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1566073771259-6a8506099945?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Hotel Malte Opera",
            PricePerNight = 180.00m,
            Rating = 4.2m,
            Address = "63 Rue de Richelieu, 75002 Paris",
            DestinationId = parisDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1582719369562-2c93f7c6e3ab?auto=format&fit=crop&w=800&q=80",
        }
    });

                // Hotels for Santorini
        var santoriniDestination = destinations.First(d => d.City == "Santorini");
        hotels.AddRange(new[]
                {
        new Hotel
        {
            Name = "Canaves Oia Epitome",
            PricePerNight = 950.00m,
            Rating = 4.9m,
            Address = "Oia, Santorini 84702",
            DestinationId = santoriniDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1501117716987-c8e1ecb210ca?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Grace Hotel Santorini",
            PricePerNight = 680.00m,
            Rating = 4.8m,
            Address = "Imerovigli, Santorini 84700",
            DestinationId = santoriniDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1505691938895-1758d7feb511?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Villa Renos",
            PricePerNight = 220.00m,
            Rating = 4.4m,
            Address = "Firostefani, Santorini 84700",
            DestinationId = santoriniDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?auto=format&fit=crop&w=800&q=80",
        }
    });

                // Hotels for Tokyo
        var tokyoDestination = destinations.First(d => d.City == "Tokyo");
        hotels.AddRange(new[]
                {
        new Hotel
        {
            Name = "The Peninsula Tokyo",
            PricePerNight = 650.00m,
            Rating = 4.8m,
            Address = "1-8-1 Yurakucho, Chiyoda City, Tokyo",
            DestinationId = tokyoDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1551776235-dde6d4829807?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Park Hyatt Tokyo",
            PricePerNight = 580.00m,
            Rating = 4.7m,
            Address = "3-7-1-2 Nishi Shinjuku, Shinjuku City, Tokyo",
            DestinationId = tokyoDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1618773928121-c048dcae40a5?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Shibuya Excel Hotel Tokyu",
            PricePerNight = 280.00m,
            Rating = 4.3m,
            Address = "1-12-2 Dogenzaka, Shibuya City, Tokyo",
            DestinationId = tokyoDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1589987601712-fd0de30d7e48?auto=format&fit=crop&w=800&q=80",
        }
    });

                // Hotels for Dubai
        var dubaiDestination = destinations.First(d => d.City == "Dubai");
        hotels.AddRange(new[]
                {
        new Hotel
        {
            Name = "Armani Hotel Dubai",
            PricePerNight = 750.00m,
            Rating = 4.8m,
            Address = "Burj Khalifa, Downtown Dubai",
            DestinationId = dubaiDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1590490350331-992d116b207e?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Address Downtown",
            PricePerNight = 420.00m,
            Rating = 4.6m,
            Address = "Mohammed Bin Rashid Blvd, Downtown Dubai",
            DestinationId = dubaiDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1505245208761-ba872912fac0?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Rove Downtown",
            PricePerNight = 150.00m,
            Rating = 4.2m,
            Address = "Sheikh Mohammed bin Rashid Blvd, Downtown Dubai",
            DestinationId = dubaiDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267?auto=format&fit=crop&w=800&q=80",
        }
    });

                // Hotels for Rome
         var romeDestination = destinations.First(d => d.City == "Rome");
         hotels.AddRange(new[]
                {
        new Hotel
        {
            Name = "Hotel de Russie",
            PricePerNight = 590.00m,
            Rating = 4.7m,
            Address = "Via del Babuino, 9, 00187 Roma",
            DestinationId = romeDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1542314831-068cd1dbfeeb?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "The First Roma Dolce",
            PricePerNight = 380.00m,
            Rating = 4.5m,
            Address = "Via di Ripetta, 231, 00186 Roma",
            DestinationId = romeDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1551776235-dde6d4829807?auto=format&fit=crop&w=800&q=80",
        },
        new Hotel
        {
            Name = "Hotel Artemide",
            PricePerNight = 190.00m,
            Rating = 4.3m,
            Address = "Via Nazionale, 22, 00184 Roma",
            DestinationId = romeDestination.Id,
            ImagePath = "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267?auto=format&fit=crop&w=800&q=80",
        }
    });



            // Add hotels to context
            await context.Hotels.AddRangeAsync(hotels);
            await context.SaveChangesAsync();

            Console.WriteLine("Database seeded successfully!");
        }
    }
}