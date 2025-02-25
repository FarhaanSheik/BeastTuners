using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeastTuners.Models
{
    public class PartSupplier
    {
        [Key]
        public int PartSuppliersID { get; set; }

        [ForeignKey("PartID")]
        public int PartID { get; set; }

        [ForeignKey("SuppierID")]
        public int SupplierID { get; set; }

        public Part Part { get; set; }
        public Supplier Supplier { get; set; }
    }
}
