using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BeastTuners.Areas.Identity.Data;

namespace BeastTuners.Models
{
    public class OrderResult
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customer")]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0, 999999.99)]
        public decimal TotalAmount { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } // e.g., "Pending", "Completed", "Cancelled"

        public BeastTunersUser User { get; set; }
    }
}
