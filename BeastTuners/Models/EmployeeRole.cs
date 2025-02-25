using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeastTuners.Models
{
    public class EmployeeRole
    {
        [Key]
        public int EmployeeRoleID { get; set; }  // Primary key

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        public Employee Employee { get; set; }
    }
}
