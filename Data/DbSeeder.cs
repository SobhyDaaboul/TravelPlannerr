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


            // Hotels for Paris
            var parisDestination = destinations.First(d => d.City == "Paris");
            hotels.AddRange(new[]
            {
                new Hotel
                {
                    Name = "Hotel Plaza Athénée",
                    Description = "Nestled on the prestigious Avenue Montaigne in Paris, Hotel Plaza Athénée offers a luxurious stay with elegant decor, fine dining, and world-class service, perfect for travelers seeking true Parisian sophistication.",
                    PricePerNight = 850.00m,
                    Rating = 4.8m,
                    Address = "25 Avenue Montaigne, 75008 Paris",
                    DestinationId = parisDestination.Id,
                    ImagePath = "/images/hotels/paris_1",
                },
                new Hotel
                {
                    Name = "Le Meurice",
                    Description = "Located opposite the Tuileries Garden, Le Meurice is a refined hotel that combines 18th-century opulence with contemporary comfort, offering a rich cultural experience in the heart of Paris.",
                    PricePerNight = 720.00m,
                    Rating = 4.7m,
                    Address = "228 Rue de Rivoli, 75001 Paris",
                    DestinationId = parisDestination.Id,
                    ImagePath = "/images/hotels/paris_2",
                },
                new Hotel
                {
                    Name = "Hotel Malte Opera",
                    Description = "A charming boutique hotel located in the 2nd arrondissement of Paris, Hotel Malte Opera offers cozy rooms and excellent access to major attractions, perfect for tourists and business travelers alike.",
                    PricePerNight = 180.00m,
                    Rating = 4.2m,
                    Address = "63 Rue de Richelieu, 75002 Paris",
                    DestinationId = parisDestination.Id,
                    ImagePath = "/images/hotels/paris_3",
                }
            });

                        // Hotels for Santorini
                var santoriniDestination = destinations.First(d => d.City == "Santorini");
                hotels.AddRange(new[]
                        {
                new Hotel
                {
                    Name = "Canaves Oia Epitome",
                    Description = "Set on the edge of a cliff with sweeping views of the Aegean Sea, Canaves Oia Epitome offers luxurious suites, infinity pools, and a serene atmosphere for a romantic Santorini escape.",
                    PricePerNight = 950.00m,
                    Rating = 4.9m,
                    Address = "Oia, Santorini 84702",
                    DestinationId = santoriniDestination.Id,
                    ImagePath = "/images/hotels/santorini_1",
                },
                new Hotel
                {
                    Name = "Grace Hotel Santorini",
                    Description = "Perched on a cliff in Imerovigli, Grace Hotel boasts breathtaking views, minimalist Cycladic architecture, and world-renowned hospitality for a truly unforgettable Santorini experience.",
                    PricePerNight = 680.00m,
                    Rating = 4.8m,
                    Address = "Imerovigli, Santorini 84700",
                    DestinationId = santoriniDestination.Id,
                    ImagePath = "/images/hotels/santorini_2",
                },
                new Hotel
                {
                    Name = "Villa Renos",
                    Description = "Located in Firostefani, Villa Renos combines traditional Greek charm with modern comfort, offering guests incredible caldera views, warm hospitality, and easy access to Santorini's best sights.",
                    PricePerNight = 220.00m,
                    Rating = 4.4m,
                    Address = "Firostefani, Santorini 84700",
                    DestinationId = santoriniDestination.Id,
                    ImagePath = "/images/hotels/santorini_3",
                }
            });

                        // Hotels for Tokyo
                var tokyoDestination = destinations.First(d => d.City == "Tokyo");
                hotels.AddRange(new[]
                        {
                new Hotel
                {
                    Name = "The Peninsula Tokyo",
                    Description = "Situated near the Imperial Palace, The Peninsula Tokyo offers modern luxury with traditional Japanese touches, spacious rooms, and exceptional service in the bustling city center.",
                    PricePerNight = 650.00m,
                    Rating = 4.8m,
                    Address = "1-8-1 Yurakucho, Chiyoda City, Tokyo",
                    DestinationId = tokyoDestination.Id,
                    ImagePath = "/images/hotels/tokyo_1",
                },
                new Hotel
                {
                    Name = "Park Hyatt Tokyo",
                    Description = "Famous for its appearance in films, Park Hyatt Tokyo offers panoramic views of Mount Fuji, luxurious suites, and a peaceful ambiance in the heart of Shinjuku's vibrant district.",
                    PricePerNight = 580.00m,
                    Rating = 4.7m,
                    Address = "3-7-1-2 Nishi Shinjuku, Shinjuku City, Tokyo",
                    DestinationId = tokyoDestination.Id,
                    ImagePath ="/images/hotels/tokyo_2",
                },
                new Hotel
                {
                    Name = "Shibuya Excel Hotel Tokyu",
                    Description = "Perfectly located above Shibuya Station, this modern hotel offers stylish rooms with unbeatable access to Tokyo’s trendiest neighborhood and famous Scramble Crossing views.",
                    PricePerNight = 280.00m,
                    Rating = 4.3m,
                    Address = "1-12-2 Dogenzaka, Shibuya City, Tokyo",
                    DestinationId = tokyoDestination.Id,
                    ImagePath = "/images/hotels/tokyo_3",
                }
            });

                        // Hotels for Dubai
                var dubaiDestination = destinations.First(d => d.City == "Dubai");
                hotels.AddRange(new[]
                        {
                new Hotel
                {
                    Name = "Armani Hotel Dubai",
                    Description = "Designed by Giorgio Armani and located in the iconic Burj Khalifa, this hotel offers refined luxury, sleek design, and premium amenities in the heart of Downtown Dubai.",
                    PricePerNight = 750.00m,
                    Rating = 4.8m,
                    Address = "Burj Khalifa, Downtown Dubai",
                    DestinationId = dubaiDestination.Id,
                    ImagePath = "/images/hotels/dubai_1",
                },
                new Hotel
                {
                    Name = "Address Downtown",
                    Description = "A contemporary five-star hotel overlooking the Dubai Fountain and Burj Khalifa, featuring elegant accommodations, rooftop views, and seamless access to Dubai Mall.",
                    PricePerNight = 420.00m,
                    Rating = 4.6m,
                    Address = "Mohammed Bin Rashid Blvd, Downtown Dubai",
                    DestinationId = dubaiDestination.Id,
                    ImagePath = "/images/hotels/dubai_2",
                },
                new Hotel
                {
                    Name = "Rove Downtown",
                    Description = "Offering an affordable and stylish stay, Rove Downtown features quirky interiors, excellent location near Burj Khalifa, and a relaxed, youthful atmosphere ideal for urban explorers.",
                    PricePerNight = 150.00m,
                    Rating = 4.2m,
                    Address = "Sheikh Mohammed bin Rashid Blvd, Downtown Dubai",
                    DestinationId = dubaiDestination.Id,
                    ImagePath ="/images/hotels/dubai_3",
                }
            });

                        // Hotels for Rome
                var romeDestination = destinations.First(d => d.City == "Rome");
                hotels.AddRange(new[]
                        {
                new Hotel
                {
                    Name = "Hotel de Russie",
                    Description = "Hotel de Russie is a historic luxury retreat between Piazza del Popolo and the Spanish Steps, offering elegant gardens, tranquil spa experiences, and artistic flair in Rome’s city center.",
                    PricePerNight = 590.00m,
                    Rating = 4.7m,
                    Address = "Via del Babuino, 9, 00187 Roma",
                    DestinationId = romeDestination.Id,
                    ImagePath = "/images/hotels/rome_1",
                },
                new Hotel
                {
                    Name = "The First Roma Dolce",
                    Description = "Blending modern design with Roman heritage, The First Roma Dolce offers boutique luxury with gourmet dining, art-inspired rooms, and a quiet retreat steps from major landmarks.",
                    PricePerNight = 380.00m,
                    Rating = 4.5m,
                    Address = "Via di Ripetta, 231, 00186 Roma",
                    DestinationId = romeDestination.Id,
                    ImagePath = "/images/hotels/rome_2",
                },
                new Hotel
                {
                    Name = "Hotel Artemide",
                    Description = "Hotel Artemide combines classic elegance with modern comfort, offering beautifully appointed rooms, a full-service spa, and a rooftop restaurant overlooking the Eternal City.",
                    PricePerNight = 190.00m,
                    Rating = 4.3m,
                    Address = "Via Nazionale, 22, 00184 Roma",
                    DestinationId = romeDestination.Id,
                    ImagePath = "/images/hotels/rome_3",
                }
          });

            // Hotels for China    
            var chinaDestination = destinations.First(d => d.City == "Beijing");
                hotels.AddRange(new[]
                {
                new Hotel
                {
                    Name = "The Peninsula Beijing",
                    Description = "Located in the heart of Beijing, The Peninsula offers a seamless blend of traditional Chinese artistry and modern luxury, providing guests with spacious suites and exceptional service just steps from the Forbidden City.",
                    PricePerNight = 450.00m,
                    Rating = 4.7m,
                    Address = "8 Goldfish Lane, Wangfujing, Beijing",
                    DestinationId = chinaDestination.Id,
                    ImagePath ="/images/hotels/china_1",
                },
                new Hotel
                {
                    Name = "Rosewood Beijing",
                    Description = "Rosewood Beijing is a five-star urban sanctuary that combines elegant interiors, tranquil spa facilities, and world-class cuisine, perfect for travelers seeking refinement and relaxation near the CBD.",
                    PricePerNight = 390.00m,
                    Rating = 4.6m,
                    Address = "Jing Guang Centre, Hujialou, Beijing",
                    DestinationId = chinaDestination.Id,
                    ImagePath ="/images/hotels/china_2",
                },
                new Hotel
                {
                    Name = "Park Plaza Beijing Wangfujing",
                    Description = "Conveniently located near Tiananmen Square, this modern hotel offers a balance of comfort, affordability, and quick access to Beijing's cultural landmarks, making it ideal for both tourists and business travelers.",
                    PricePerNight = 140.00m,
                    Rating = 4.2m,
                    Address = "97 Jinbao Street, Dongcheng, Beijing",
                    DestinationId = chinaDestination.Id,
                    ImagePath = "/images/hotels/china_3",
                }
            });


            var cuscoDestination = destinations.First(d => d.City == "Cusco");
            hotels.AddRange(new[]
                    {
            new Hotel
            {
                Name = "Belmond Hotel Monasterio",
                Description = "Set in a former monastery built in 1592, this iconic hotel offers guests a unique mix of colonial architecture, rich Peruvian heritage, and five-star luxury in the heart of Cusco’s historic center.",
                PricePerNight = 520.00m,
                Rating = 4.8m,
                Address = "Calle Palacio 136, Cusco 08002",
                DestinationId = cuscoDestination.Id,
                ImagePath = "/images/hotels/cusco_1",
            },
            new Hotel
            {
                Name = "Palacio del Inka, a Luxury Collection Hotel",
                Description = "Palacio del Inka places guests steps away from Qoricancha Temple and offers elegant rooms decorated with authentic Andean details, full spa services, and a fine-dining restaurant with local cuisine.",
                PricePerNight = 410.00m,
                Rating = 4.7m,
                Address = "Plazoleta Santo Domingo 259, Cusco 08002",
                DestinationId = cuscoDestination.Id,
                ImagePath = "/images/hotels/cusco_2",
            },
            new Hotel
            {
                Name = "Antigua Casona San Blas",
                Description = "This boutique hotel combines rustic charm with modern comfort, offering beautifully restored rooms, a peaceful courtyard, and personal service in the artistic San Blas district of Cusco.",
                PricePerNight = 160.00m,
                Rating = 4.5m,
                Address = "Calle Carmen Bajo 243, Cusco 08003",
                DestinationId = cuscoDestination.Id,
                ImagePath = "/images/hotels/cusco_3",
            }
        });

            var newYorkDestination = destinations.First(d => d.City == "New York");
            hotels.AddRange(new[]
                    {
            new Hotel
            {
                Name = "The Plaza Hotel",
                Description = "An iconic luxury hotel overlooking Central Park, The Plaza offers timeless elegance, opulent rooms, world-class dining, and a rich history that has welcomed royalty, celebrities, and dignitaries for over a century.",
                PricePerNight = 720.00m,
                Rating = 4.8m,
                Address = "768 5th Ave, New York, NY 10019",
                DestinationId = newYorkDestination.Id,
                ImagePath = "/images/hotels/newyork_1",
            },
            new Hotel
            {
                Name = "The Langham, New York, Fifth Avenue",
                Description = "Situated between Bryant Park and the Empire State Building, The Langham features spacious rooms with skyline views, fine Italian dining, and personalized service tailored to both leisure and business travelers.",
                PricePerNight = 510.00m,
                Rating = 4.7m,
                Address = "400 5th Ave, New York, NY 10018",
                DestinationId = newYorkDestination.Id,
                ImagePath ="/images/hotels/newyork_2",
            },
            new Hotel
            {
                Name = "Arlo NoMad",
                Description = "A stylish and modern boutique hotel with compact yet beautifully designed rooms, Arlo NoMad is perfect for adventurers looking to explore Midtown Manhattan, offering rooftop views and a vibrant social atmosphere.",
                PricePerNight = 220.00m,
                Rating = 4.3m,
                Address = "11 E 31st St, New York, NY 10016",
                DestinationId = newYorkDestination.Id,
                ImagePath = "/images/hotels/newyork_3",
            }
        });

            // Add hotels to context
            await context.Hotels.AddRangeAsync(hotels);
            await context.SaveChangesAsync();

            Console.WriteLine("Database seeded successfully!");
        }
    }
}