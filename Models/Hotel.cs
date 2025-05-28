using System.ComponentModel.DataAnnotations;
using TravelPlannerr.Models;

namespace TravelPlannerr.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0, 10000)]
        [Display(Name = "Price Per Night")]
        public decimal PricePerNight { get; set; }

        [Range(0, 5)]
        public decimal? Rating { get; set; }

        [Display(Name = "Image")]
        public string? ImagePath { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Amenities { get; set; } // e.g., "WiFi,Pool,Gym,Spa"

        public bool IsAvailable { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign key
        [Display(Name = "Destination")]
        public int DestinationId { get; set; }

        // Navigation properties
        public virtual Destination Destination { get; set; } = null!;
        public virtual ICollection<TripDestination> TripDestinations { get; set; } = new List<TripDestination>();
    }
}
