using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPlannerr.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public int DestinationId { get; set; }

        public Destination? Destination { get; set; }

        public int? HotelId { get; set; } // Nullable hotel

        public Hotel? Hotel { get; set; }

        public string? Notes { get; set; }

        public string? Status { get; set; }

        public string? UserId { get; set; }

        [NotMapped]
        public int TotalDays => (EndDate - StartDate).Days + 1;
    }
}
