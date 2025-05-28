using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TravelPlannerr.Data;
using TravelPlannerr.Models;

namespace TravelPlannerr.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Destination> Destinations { get; set; } = new List<Destination>();

        public async Task OnGetAsync()
        {
            // Get destinations from database with their hotels
            Destinations = await _context.Destinations
                .Include(d => d.Hotels)
                .Take(6)
                .ToListAsync();
        }
    }
}






