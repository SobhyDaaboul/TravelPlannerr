using System.ComponentModel.DataAnnotations;
using TravelPlannerr.Models;

namespace TravelPlannerr.Models
{
    public class TripDestination
    {
        public int Id { get; set; }

        [Required]
        public int TripId { get; set; }

        public int? HotelId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Trip? Trip { get; set; }
        public virtual Hotel? Hotel { get; set; }
        public virtual Destination? Destination { get; set; }

        // Calculated properties
        public int Nights => (CheckOutDate - CheckInDate).Days;

        public decimal TotalHotelCost => Hotel != null ? Nights * Hotel.PricePerNight : 0;
    }
}