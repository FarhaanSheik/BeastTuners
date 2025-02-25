using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeastTuners.Models
{
    public class SuppliersDelivery
    {
        [Key]
        public int SupplierDeliveryID { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        [ForeignKey("Part")]
        public int PartID { get; set; }

        [Required]
        public DateTime DeliveryTime { get; set; }

        public Supplier Supplier { get; set; }
        public Part Part { get; set; }
    }
}
