using System.ComponentModel.DataAnnotations;

namespace PR_4.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please enter a valid 10-digit mobile number")]
        [Display(Name = "Mobile Number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please select a ticket tier")]
        [Display(Name = "Ticket Tier")]
        public string? TicketType { get; set; }

        [Required(ErrorMessage = "Please specify ticket count")]
        [Range(1, 10, ErrorMessage = "You can book between 1 and 10 tickets per registration")]
        [Display(Name = "Number of Passes")]
        public int NumberOfTickets { get; set; } = 1;

        [Required(ErrorMessage = "Please select your preferred seating area")]
        [Display(Name = "Seating Zone")]
        public string? Seating { get; set; }

        [Display(Name = "Terms Agreement")]
        [PR_4.Models.Validation.MustBeTrue]
        public bool AgreeTerms { get; set; }

        public decimal CalculateTotalPrice()
        {
            decimal basePrice = TicketType switch
            {
                "VIP" => 2499m,
                "General" => 999m,
                "Student" => 499m,
                _ => 0m
            };

            return basePrice * NumberOfTickets;
        }
    }
}

