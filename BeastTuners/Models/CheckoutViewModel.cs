using System.ComponentModel.DataAnnotations;

namespace BeastTuners.Models
{
    public class CheckoutViewModel
    {
        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; } = "New Zealand";

        [Display(Name = "Shipping Method")]
        public string ShippingMethod { get; set; } = "Standard";

        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; } = "Credit Card";

        [Display(Name = "Order Notes (optional)")]
        public string OrderNotes { get; set; }

        public decimal Subtotal { get; set; }
        public decimal Shipping { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}