using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TravelPlannerr.Data;
using TravelPlannerr.Models;


namespace TravelPlanner.Pages.Destinations
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Destination> Destinations { get; set; } = new List<Destination>();

        public async Task OnGetAsync()
        {
            Destinations = await _context.Destinations
                .Include(d => d.Hotels)
                .Include(d => d.Trips)
                .Include(d => d.TripDestinations)
                .OrderByDescending(d => d.CreatedAt)
                .ToListAsync();
        }
    }
}

