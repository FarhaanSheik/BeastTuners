using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeastTuners.Models
{
    public class InventoryAdjustment
    {
        [Key]
        public int AdjustmentID { get; set; }

        [ForeignKey("Part")]
        public int PartID { get; set; }

        [Required]
        [StringLength(20)]
        public string AdjustmentType { get; set; } 

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AdjustmentDate { get; set; }

        [StringLength(200)]
        public string Reason { get; set; }

        public Part Part { get; set; }
    }
}
