using System.ComponentModel.DataAnnotations;

namespace BeastTuners.Models
{
    public class Part
    {
        [Key]
        public int PartID { get; set; }

        [Required]
        [StringLength(100)]
        public string PartName { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [Range(0, 99999.99)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        public string? ImagePath { get; set; }


        [Required]
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }




        public ICollection<PartSupplier> PartSuppliers { get; set; }
    }
}
