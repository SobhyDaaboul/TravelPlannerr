using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace TravelPlannerr.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string ImagePath { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string BestTimeToVisit { get; set; } = string.Empty;

        [Column(TypeName = "decimal(3,1)")]
        public decimal AverageRating { get; set; }

        public int ReviewCount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Trip> Trips { get; set; } = new List<Trip>();

        public ICollection<TripDestination> TripDestinations { get; set; } = new List<TripDestination>();
    }
}
