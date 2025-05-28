using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelPlannerr.Data;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace TravelPlanner.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;

        public LoginModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; } = string.Empty;

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            // Check if user exists
            var user = _context.Users.FirstOrDefault(u => u.Email == Input.Email);

            if (user == null)
            {
                // User doesn't exist - add error message
                ModelState.AddModelError(string.Empty, "User with this email does not exist.");
                return Page();
            }

            // Check if password matches
            string hashedInputPassword = HashPassword(Input.Password);
            if (user.Password != hashedInputPassword)
            {
                // Wrong password - add error message
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return Page();
            }

            // Login successful - redirect to home or dashboard
            // You might want to set authentication cookies here
            return RedirectToPage("/Index"); // or wherever you want to redirect
        }
        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
