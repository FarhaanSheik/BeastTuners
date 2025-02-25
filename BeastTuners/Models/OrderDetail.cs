using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeastTuners.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        [ForeignKey("OrderResult")]
        public int OrderID { get; set; }

        [ForeignKey("Part")]
        public int PartID { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [Range(0, 99999.99)]
        public decimal UnitPrice { get; set; }

        public OrderResult OrderResult { get; set; }
        public Part Part { get; set; }
    }
}
