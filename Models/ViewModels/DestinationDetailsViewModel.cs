namespace TravelPlannerr.Models.ViewModels
{
    public class DestinationDetailsViewModel
    {
        public Destination Destination { get; set; } = null!;
        public List<Hotel> Hotels { get; set; } = new();
        public List<Hotel> FeaturedHotels { get; set; } = new();
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal AveragePrice { get; set; }

        // For trip planning from destination page
        public bool AddToTrip { get; set; }
        public int? ExistingTripId { get; set; }
        public List<Trip> UserTrips { get; set; } = new();
    }
}
