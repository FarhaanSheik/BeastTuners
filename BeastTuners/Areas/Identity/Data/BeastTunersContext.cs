using BeastTuners.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BeastTuners.Models;

namespace BeastTuners.Data;

public class BeastTunersContext : IdentityDbContext<BeastTunersUser>
{
    public BeastTunersContext(DbContextOptions<BeastTunersContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<BeastTuners.Models.Customer> Customer { get; set; } = default!;

public DbSet<BeastTuners.Models.Employee> Employee { get; set; } = default!;

public DbSet<BeastTuners.Models.EmployeeRole> EmployeeRole { get; set; } = default!;

public DbSet<BeastTuners.Models.InventoryAdjustment> InventoryAdjustment { get; set; } = default!;

public DbSet<BeastTuners.Models.OrderDetail> OrderDetail { get; set; } = default!;

public DbSet<BeastTuners.Models.OrderResult> OrderResult { get; set; } = default!;

public DbSet<BeastTuners.Models.Part> Part { get; set; } = default!;

public DbSet<BeastTuners.Models.PartSupplier> PartSupplier { get; set; } = default!;

public DbSet<BeastTuners.Models.Supplier> Supplier { get; set; } = default!;

public DbSet<BeastTuners.Models.SuppliersDelivery> SuppliersDelivery { get; set; } = default!;
}
