using BeastTuners.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BeastTuners.Models;
using Microsoft.AspNetCore.Identity;

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

        var hasher = new PasswordHasher<BeastTunersUser>();

        builder.Entity<BeastTunersUser>().HasData(
            new BeastTunersUser
            {
                Id = "user1",
                UserName = "John@gmail.com",
                NormalizedUserName = "JOHN@GMAIL.COM",
                Email = "John@gmail.com",
                NormalizedEmail = "JOHN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "0210000001",
                FirstName = "John",
                LastName = "Doe",
                Address = "1 Main Street",
                UserType = "Customer",
                PasswordHash = hasher.HashPassword(null!, "Password@123"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new BeastTunersUser
            {
                Id = "user2",
                UserName = "Alice@yahoo.com",
                NormalizedUserName = "ALICE@YAHOO.COM",
                Email = "Alice@yahoo.com",
                NormalizedEmail = "ALICE@YAHOO.COM",
                EmailConfirmed = true,
                PhoneNumber = "0210000002",
                FirstName = "Alice",
                LastName = "Smith",
                Address = "2 Oak Road",
                UserType = "Customer",
                PasswordHash = hasher.HashPassword(null!, "Password@123"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new BeastTunersUser
            {
                Id = "user3",
                UserName = "Ethan@gmail.com",
                NormalizedUserName = "ETHAN@GMAIL.COM",
                Email = "Ethan@gmail.com",
                NormalizedEmail = "ETHAN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "0210000003",
                FirstName = "Ethan",
                LastName = "Williams",
                Address = "3 Beachside Ave",
                UserType = "Customer",
                PasswordHash = hasher.HashPassword(null!, "Password@123"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new BeastTunersUser
            {
                Id = "user4",
                UserName = "Sarah@gmail.com",
                NormalizedUserName = "SARAH@GMAIL.COM",
                Email = "Sarah@gmail.com",
                NormalizedEmail = "SARAH@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "0210000004",
                FirstName = "Sarah",
                LastName = "Lee",
                Address = "4 Valley Rd",
                UserType = "Customer",
                PasswordHash = hasher.HashPassword(null!, "Password@123"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new BeastTunersUser
            {
                Id = "user5",
                UserName = "James@gmail.com",
                NormalizedUserName = "JAMES@GMAIL.COM",
                Email = "James@gmail.com",
                NormalizedEmail = "JAMES@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "0210000005",
                FirstName = "James",
                LastName = "Nguyen",
                Address = "5 Racecourse Rd",
                UserType = "Customer",
                PasswordHash = hasher.HashPassword(null!, "Password@123"),
                SecurityStamp = Guid.NewGuid().ToString()
            }
        );


        builder.Entity<Part>().HasData(
            new Part { PartID = 1, PartName = "Performance Brake Pads", Category = "Brakes", Price = 120.00m, StockQuantity = 50, Description = "High-performance brake pads for sports cars", ImagePath = "/images/performanceBrakePad.jpg" },
            new Part { PartID = 2, PartName = "Alloy Wheels 17\"", Category = "Wheels", Price = 480.00m, StockQuantity = 20, Description = "Stylish and durable alloy wheels", ImagePath = "/images/wheels19'.jpg" },
            new Part { PartID = 3, PartName = "V8 Engine Block", Category = "Engine", Price = 2500.00m, StockQuantity = 5, Description = "Powerful V8 engine block for muscle cars", ImagePath = "/images/v8Engine.jpg" },
            new Part { PartID = 4, PartName = "Cold Air Intake", Category = "Engine", Price = 200.00m, StockQuantity = 15, Description = "Improves airflow and boosts horsepower", ImagePath = "/images/Intake.jpg" },
            new Part { PartID = 5, PartName = "Carbon Fiber Hood", Category = "Exterior", Price = 950.00m, StockQuantity = 3, Description = "Lightweight and aerodynamic hood", ImagePath = "/images/Hood.jpg" },
            new Part { PartID = 6, PartName = "Coilover Suspension Kit", Category = "Suspension", Price = 850.00m, StockQuantity = 8, Description = "Adjustable ride height and improved handling", ImagePath = "/images/coilsuspension.jpg" },
            new Part { PartID = 7, PartName = "High Flow Exhaust", Category = "Exhaust", Price = 499.99m, StockQuantity = 10, Description = "Enhances engine performance and sound", ImagePath = "/images/Subi exhaust.jpg" },
            new Part { PartID = 8, PartName = "Bucket Racing Seats", Category = "Interior", Price = 750.00m, StockQuantity = 6, Description = "Lightweight and secure racing seats", ImagePath = "/images/Seats.jpg" },
            new Part { PartID = 9, PartName = "Touchscreen Dash Display", Category = "Interior", Price = 300.00m, StockQuantity = 12, Description = "Smart infotainment system for modern cars", ImagePath = "/images/Display.jpg" },
            new Part { PartID = 10, PartName = "Slotted Rotors", Category = "Brakes", Price = 180.00m, StockQuantity = 25, Description = "Enhanced cooling and stopping power", ImagePath = "/images/Rotor.jpg" }
        );


        // --- Suppliers ---
        builder.Entity<Supplier>().HasData(
            new Supplier { SupplierID = 1, SupplierName = "AutoParts NZ", PhoneNumber = "0800123456", Address = "88 Workshop Lane" },
            new Supplier { SupplierID = 2, SupplierName = "GearCo", PhoneNumber = "0800456789", Address = "42 Mechanics Rd" },
            new Supplier { SupplierID = 3, SupplierName = "AutoZone Supplies", PhoneNumber = "0211112222", Address = "12 Industrial Rd" },
            new Supplier { SupplierID = 4, SupplierName = "SpeedParts NZ", PhoneNumber = "0213334444", Address = "88 Speedway Ave" },
            new Supplier { SupplierID = 5, SupplierName = "MotorTech Ltd", PhoneNumber = "0215556666", Address = "5 Workshop Lane" }
        );

        // --- Inventory Adjustments ---
        builder.Entity<InventoryAdjustment>().HasData(
     new InventoryAdjustment { AdjustmentID = 1, PartID = 1, AdjustmentType = "Restock", Quantity = 20, AdjustmentDate = DateTime.Now.AddDays(-15), Reason = "Monthly replenishment" },
     new InventoryAdjustment { AdjustmentID = 2, PartID = 2, AdjustmentType = "Damaged", Quantity = -3, AdjustmentDate = DateTime.Now.AddDays(-12), Reason = "Damaged in delivery" },
     new InventoryAdjustment { AdjustmentID = 3, PartID = 3, AdjustmentType = "Restock", Quantity = 10, AdjustmentDate = DateTime.Now.AddDays(-10), Reason = "Supplier delivery" },
     new InventoryAdjustment { AdjustmentID = 4, PartID = 4, AdjustmentType = "Manual Correction", Quantity = 5, AdjustmentDate = DateTime.Now.AddDays(-8), Reason = "Stock correction" },
     new InventoryAdjustment { AdjustmentID = 5, PartID = 5, AdjustmentType = "Restock", Quantity = 12, AdjustmentDate = DateTime.Now.AddDays(-5), Reason = "New shipment" }
 );




        // --- Order Details ---
        builder.Entity<OrderDetail>().HasData(
     new OrderDetail { OrderDetailID = 1, OrderID = 1, PartID = 1, Quantity = 2, UnitPrice = 75.00m },
     new OrderDetail { OrderDetailID = 2, OrderID = 1, PartID = 2, Quantity = 1, UnitPrice = 300.00m },
     new OrderDetail { OrderDetailID = 3, OrderID = 2, PartID = 3, Quantity = 2, UnitPrice = 60.00m },
     new OrderDetail { OrderDetailID = 4, OrderID = 3, PartID = 1, Quantity = 4, UnitPrice = 75.00m },
     new OrderDetail { OrderDetailID = 5, OrderID = 3, PartID = 4, Quantity = 1, UnitPrice = 150.00m },
     new OrderDetail { OrderDetailID = 6, OrderID = 4, PartID = 5, Quantity = 2, UnitPrice = 87.75m },
     new OrderDetail { OrderDetailID = 7, OrderID = 5, PartID = 2, Quantity = 1, UnitPrice = 220.00m }
 );

        // --- Order Results ---
        builder.Entity<OrderResult>().HasData(
            new OrderResult { OrderID = 1, UserID = "user1", OrderDate = DateTime.Now.AddDays(-10), TotalAmount = 495.00m, Status = "Completed" },
            new OrderResult { OrderID = 2, UserID = "user2", OrderDate = DateTime.Now.AddDays(-9), TotalAmount = 120.00m, Status = "Pending" },
            new OrderResult { OrderID = 3, UserID = "user3", OrderDate = DateTime.Now.AddDays(-8), TotalAmount = 450.00m, Status = "Completed" },
            new OrderResult { OrderID = 4, UserID = "user4", OrderDate = DateTime.Now.AddDays(-7), TotalAmount = 175.50m, Status = "Pending" },
            new OrderResult { OrderID = 5, UserID = "user5", OrderDate = DateTime.Now.AddDays(-6), TotalAmount = 220.00m, Status = "Cancelled" }
        );

        // --- PartSuppliers ---
        builder.Entity<PartSupplier>().HasData(
            new PartSupplier { PartSuppliersID = 1, PartID = 1, SupplierID = 1 },
            new PartSupplier { PartSuppliersID = 2, PartID = 2, SupplierID = 2 },
            new PartSupplier { PartSuppliersID = 3, PartID = 3, SupplierID = 3 },
            new PartSupplier { PartSuppliersID = 4, PartID = 4, SupplierID = 4 },
            new PartSupplier { PartSuppliersID = 5, PartID = 5, SupplierID = 5 },
            new PartSupplier { PartSuppliersID = 6, PartID = 1, SupplierID = 2 },
            new PartSupplier { PartSuppliersID = 7, PartID = 2, SupplierID = 3 },
            new PartSupplier { PartSuppliersID = 8, PartID = 3, SupplierID = 4 },
            new PartSupplier { PartSuppliersID = 9, PartID = 4, SupplierID = 5 },
            new PartSupplier { PartSuppliersID = 10, PartID = 5, SupplierID = 1 }
        );



        // --- SuppliersDelivery ---
        builder.Entity<SuppliersDelivery>().HasData(
            new SuppliersDelivery { SupplierDeliveryID = 1, SupplierID = 1, PartID = 1, DeliveryTime = DateTime.Now.AddDays(-15) },
            new SuppliersDelivery { SupplierDeliveryID = 2, SupplierID = 2, PartID = 2, DeliveryTime = DateTime.Now.AddDays(-10) },
            new SuppliersDelivery { SupplierDeliveryID = 3, SupplierID = 3, PartID = 3, DeliveryTime = DateTime.Now.AddDays(-5) },
            new SuppliersDelivery { SupplierDeliveryID = 4, SupplierID = 4, PartID = 4, DeliveryTime = DateTime.Now.AddDays(-7) },
            new SuppliersDelivery { SupplierDeliveryID = 5, SupplierID = 5, PartID = 5, DeliveryTime = DateTime.Now.AddDays(-3) },
            new SuppliersDelivery { SupplierDeliveryID = 6, SupplierID = 1, PartID = 2, DeliveryTime = DateTime.Now.AddDays(-1) },
            new SuppliersDelivery { SupplierDeliveryID = 7, SupplierID = 2, PartID = 3, DeliveryTime = DateTime.Now.AddDays(-2) },
            new SuppliersDelivery { SupplierDeliveryID = 8, SupplierID = 3, PartID = 4, DeliveryTime = DateTime.Now.AddDays(-6) },
            new SuppliersDelivery { SupplierDeliveryID = 9, SupplierID = 4, PartID = 5, DeliveryTime = DateTime.Now.AddDays(-8) },
            new SuppliersDelivery { SupplierDeliveryID = 10, SupplierID = 5, PartID = 1, DeliveryTime = DateTime.Now.AddDays(-9) }
        );

    }

   
    public DbSet<InventoryAdjustment> InventoryAdjustment { get; set; } = default!;
    public DbSet<OrderDetail> OrderDetail { get; set; } = default!;
    public DbSet<OrderResult> OrderResult { get; set; } = default!;
    public DbSet<Part> Part { get; set; } = default!;
    public DbSet<PartSupplier> PartSupplier { get; set; } = default!;
    public DbSet<Supplier> Supplier { get; set; } = default!;
    public DbSet<SuppliersDelivery> SuppliersDelivery { get; set; } = default!;

public DbSet<BeastTuners.Models.CartItem> CartItem { get; set; } = default!;
}
