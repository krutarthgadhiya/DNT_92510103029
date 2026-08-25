using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PR_4.Models;

namespace PR_4.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Registration Registration { get; set; } = new Registration();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["Name"] = Registration.FullName;
            TempData["Email"] = Registration.Email;
            TempData["Phone"] = Registration.Phone;
            TempData["TicketType"] = Registration.TicketType;
            TempData["Tickets"] = Registration.NumberOfTickets.ToString();
            TempData["Seating"] = Registration.Seating;
            TempData["TotalPrice"] = Registration.CalculateTotalPrice().ToString("C0", new System.Globalization.CultureInfo("en-IN"));
            TempData["BookingRef"] = "SN2026-" + Random.Shared.Next(10000, 99999);

            return RedirectToPage("Success");
        }
    }
}
