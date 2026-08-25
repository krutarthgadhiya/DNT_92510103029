using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PR_4.Pages
{
    public class SuccessModel : PageModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? TicketType { get; set; }
        public string? NumberOfTickets { get; set; }
        public string? Seating { get; set; }
        public string? TotalPrice { get; set; }
        public string? BookingRef { get; set; }

        public void OnGet()
        {
            Name = TempData["Name"] as string ?? "Valued Guest";
            Email = TempData["Email"] as string ?? "N/A";
            Phone = TempData["Phone"] as string ?? "N/A";
            TicketType = TempData["TicketType"] as string ?? "General Pass";
            NumberOfTickets = TempData["Tickets"] as string ?? "1";
            Seating = TempData["Seating"] as string ?? "Front Enclosure";
            TotalPrice = TempData["TotalPrice"] as string ?? "₹999";
            BookingRef = TempData["BookingRef"] as string ?? ("SN2026-" + Random.Shared.Next(10000, 99999));
        }
    }
}

