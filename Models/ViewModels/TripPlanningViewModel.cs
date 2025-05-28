using System.ComponentModel.DataAnnotations;

namespace TravelPlannerr.Models.ViewModels
{
    public class TripPlanningViewModel
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Trip Name")]
        public string TripName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Today.AddDays(1);

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(7);

        [Range(0, 1000000)]
        [Display(Name = "Budget ($)")]
        public decimal Budget { get; set; }

        [StringLength(1000)]
        public string? Notes { get; set; }

        // Selected destinations with details
        public List<TripDestinationViewModel> SelectedDestinations { get; set; } = new();

        // Available destinations for selection
        public List<Destination> AvailableDestinations { get; set; } = new();
    }

    public class TripDestinationViewModel
    {
        public int DestinationId { get; set; }
        public string DestinationName { get; set; } = string.Empty;

        [Range(1, 365)]
        [Display(Name = "Days")]
        public int Days { get; set; } = 1;

        [Display(Name = "Hotel")]
        public int? HotelId { get; set; }

        public List<Hotel> AvailableHotels { get; set; } = new();

        [StringLength(500)]
        public string? Notes { get; set; }
    }
}