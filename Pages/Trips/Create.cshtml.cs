using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using TravelPlannerr.Models;
using TravelPlannerr.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace TravelPlannerr.Pages.Trips
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Trip Trip { get; set; }

        public List<Destination> Destinations { get; set; }

        public Dictionary<int, List<Hotel>> HotelsByDestination { get; set; }

        public async Task OnGetAsync()
        {
            Destinations = await _context.Destinations.ToListAsync();

            HotelsByDestination = await _context.Hotels
            .GroupBy(h => h.DestinationId)
            .ToDictionaryAsync(g => g.Key, g => g.ToList());

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Destinations = await _context.Destinations.ToListAsync();
                return Page();
            }

            // Associate with current user if using Identity
            Trip.UserId = User.Identity.Name;

            _context.Trips.Add(Trip);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}