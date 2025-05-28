// Pages/Trips/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelPlannerr.Models;
using TravelPlannerr.Data;
using Microsoft.EntityFrameworkCore;

namespace TravelPlannerr.Pages.Trips { 
public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public List<Trip> Trips { get; set; }

    public async Task OnGetAsync()
    {
        Trips = await _context.Trips
            .Include(t => t.TripDestinations)
            .ThenInclude(td => td.Destination)
            .Where(t => t.UserId == User.Identity.Name)
            .ToListAsync();
    }
}
}