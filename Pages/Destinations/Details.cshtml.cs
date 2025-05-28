using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TravelPlannerr.Models;
using TravelPlannerr.Data;

namespace TravelPlannerr.Pages.Destinations
{
    public class DetailsModel : PageModel
    {

        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Destination Destination { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Destination = await _context.Destinations
                .Include(d => d.Hotels)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (Destination == null)
            {
                return NotFound();
            }

            return Page();
        }
       
    }
}
