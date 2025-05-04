using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BeastTuners.Models;
using Microsoft.AspNetCore.Identity;

namespace BeastTuners.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BeastTunersUser class
public class BeastTunersUser : IdentityUser
{
    [Required]
    [StringLength(50)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [StringLength(255)]
    public string Address { get; set; }

    public string UserType { get; set; } // "Customer" or "Employee"

    public Role? Role { get; set; } // Nullable so Customers don’t need it

    public DateTime? HireDate { get; set; } // Optional for Employees only
}

