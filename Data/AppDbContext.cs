// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using TravelPlannerr.Models;

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
        base.OnModelCreating(modelBuilder);

        // Destination - Hotel (1-to-many)
        modelBuilder.Entity<Hotel>()
            .HasOne(h => h.Destination)
            .WithMany(d => d.Hotels)
            .HasForeignKey(h => h.DestinationId)
            .OnDelete(DeleteBehavior.Cascade);

        // Trip - Destination (1-to-1 or many-to-1)
        modelBuilder.Entity<Trip>()
            .HasOne(t => t.Destination)
            .WithMany() // no navigation back from Destination to Trip
            .HasForeignKey(t => t.DestinationId)
            .OnDelete(DeleteBehavior.Restrict);

        // Trip - Hotel (optional 1-to-1 or many-to-1)
        modelBuilder.Entity<Trip>()
            .HasOne(t => t.Hotel)
            .WithMany() // no navigation from Hotel to Trip
            .HasForeignKey(t => t.HotelId)
            .OnDelete(DeleteBehavior.SetNull);

        // TripDestination - Trip (many-to-1)
        modelBuilder.Entity<TripDestination>()
            .HasOne(td => td.Trip)
            .WithMany()
            .HasForeignKey(td => td.TripId)
            .OnDelete(DeleteBehavior.Cascade);

        // TripDestination - Hotel (optional many-to-1)
        modelBuilder.Entity<TripDestination>()
            .HasOne(td => td.Hotel)
            .WithMany()
            .HasForeignKey(td => td.HotelId)
            .OnDelete(DeleteBehavior.SetNull);

        // TripDestination - Destination (many-to-1)
        modelBuilder.Entity<TripDestination>()
            .HasOne(td => td.Destination)
            .WithMany()
            .HasForeignKey(td => td.DestinationId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}