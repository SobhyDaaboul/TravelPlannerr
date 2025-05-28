using Microsoft.EntityFrameworkCore;
using TravelPlannerr.Models;




namespace TravelPlannerr.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<TripDestination> TripDestinations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

