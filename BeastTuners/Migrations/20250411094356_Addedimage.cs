using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeastTuners.Migrations
{
    /// <inheritdoc />
    public partial class Addedimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "FirstName", "LastName" },
                values: new object[] { "123 Main St, New Lynn", "Zoheba", "Ali" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "Address",
                value: "456 Elm St, Avondale");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "Address",
                value: "789 Park Ave, Avondale");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                column: "Address",
                value: "321 Ocean Rd, Manukau");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                column: "Address",
                value: "160 River St, New Lynn");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 6, "212 Rosebank Rd, Avondale", "Mujahid", "Raza", "0226538745" },
                    { 7, "160 Riverton Dr, Papatoetoe", "Falisha", "Umaynah", "0271187334" },
                    { 8, "56 Ash St, Avondael", "Yashween", "Singh", "0271137334" }
                });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Sheik", new DateTime(2023, 4, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3871), "Farhaan" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 4, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "FirstName", "HireDate", "LastName", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 4, "Mia", new DateTime(2024, 8, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3968), "Thompson", "0276543211", 0 },
                    { 5, "Noah", new DateTime(2024, 10, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3970), "Taylor", "0287654321", 0 },
                    { 6, "Olivia", new DateTime(2024, 11, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3973), "Brown", "0209988776", 0 },
                    { 7, "Liam", new DateTime(2024, 12, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3976), "Anderson", "0291234567", 0 },
                    { 8, "Sophia", new DateTime(2025, 1, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3978), "Clark", "0218765432", 0 },
                    { 9, "James", new DateTime(2025, 2, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3981), "Lee", "0223456789", 0 },
                    { 10, "Emma", new DateTime(2025, 3, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3983), "Davis", "0234567890", 0 }
                });

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 1,
                columns: new[] { "AdjustmentDate", "Quantity", "Reason" },
                values: new object[] { new DateTime(2025, 3, 27, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4126), 20, "Monthly replenishment" });

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 2,
                columns: new[] { "AdjustmentDate", "Quantity", "Reason" },
                values: new object[] { new DateTime(2025, 3, 30, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4131), -3, "Damaged in delivery" });

            migrationBuilder.InsertData(
                table: "InventoryAdjustment",
                columns: new[] { "AdjustmentID", "AdjustmentDate", "AdjustmentType", "PartID", "Quantity", "Reason" },
                values: new object[] { 3, new DateTime(2025, 4, 1, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4134), "Restock", 3, 10, "Supplier delivery" });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "UnitPrice",
                value: 75.00m);

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "OrderID", "UnitPrice" },
                values: new object[] { 1, 300.00m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "OrderID", "PartID", "Quantity", "UnitPrice" },
                values: new object[] { 3, 2, 3, 2, 60.00m });

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2025, 4, 1, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4225), 450.00m });

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "OrderDate", "Status", "TotalAmount" },
                values: new object[] { new DateTime(2025, 4, 3, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4229), "Delivered", 120.00m });

            migrationBuilder.InsertData(
                table: "OrderResult",
                columns: new[] { "OrderID", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2025, 4, 6, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4232), "Processing", 300.00m },
                    { 4, 4, new DateTime(2025, 4, 8, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4235), "Cancelled", 175.50m },
                    { 5, 5, new DateTime(2025, 4, 10, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4238), "Pending", 220.00m }
                });

            migrationBuilder.UpdateData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 1,
                columns: new[] { "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[] { "High-performance brake pads for sports cars", "/images/performanceBrakePad.jpg", "Performance Brake Pads", 120.00m, 50 });

            migrationBuilder.UpdateData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 2,
                columns: new[] { "Category", "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[] { "Wheels", "Stylish and durable alloy wheels", "/images/wheels19'.jpg", "Alloy Wheels 17\"", 480.00m, 20 });

            migrationBuilder.UpdateData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 3,
                columns: new[] { "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[] { "Powerful V8 engine block for muscle cars", "/images/v8Engine.jpg", "V8 Engine Block", 2500.00m, 5 });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "PartID", "Category", "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 4, "Engine", "Improves airflow and boosts horsepower", "/images/Intake.jpg", "Cold Air Intake", 200.00m, 15 },
                    { 5, "Exterior", "Lightweight and aerodynamic hood", "/images/Hood.jpg", "Carbon Fiber Hood", 950.00m, 3 },
                    { 6, "Suspension", "Adjustable ride height and improved handling", "/images/coilsuspension.jpg", "Coilover Suspension Kit", 850.00m, 8 },
                    { 7, "Exhaust", "Enhances engine performance and sound", "/images/Subi exhaust.jpg", "High Flow Exhaust", 499.99m, 10 },
                    { 8, "Interior", "Lightweight and secure racing seats", "/images/Seats.jpg", "Bucket Racing Seats", 750.00m, 6 },
                    { 9, "Interior", "Smart infotainment system for modern cars", "/images/Display.jpg", "Touchscreen Dash Display", 300.00m, 12 },
                    { 10, "Brakes", "Enhanced cooling and stopping power", "/images/Rotor.jpg", "Slotted Rotors", 180.00m, 25 }
                });

            migrationBuilder.InsertData(
                table: "PartSupplier",
                columns: new[] { "PartSuppliersID", "PartID", "SupplierID" },
                values: new object[] { 6, 1, 2 });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierID", "Address", "PhoneNumber", "SupplierName" },
                values: new object[,]
                {
                    { 3, "12 Industrial Rd", "0211112222", "AutoZone Supplies" },
                    { 4, "88 Speedway Ave", "0213334444", "SpeedParts NZ" },
                    { 5, "5 Workshop Lane", "0215556666", "MotorTech Ltd" }
                });

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 1,
                column: "DeliveryTime",
                value: new DateTime(2025, 3, 27, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 2,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 1, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.InsertData(
                table: "SuppliersDelivery",
                columns: new[] { "SupplierDeliveryID", "DeliveryTime", "PartID", "SupplierID" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 4, 10, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4379), 2, 1 },
                    { 7, new DateTime(2025, 4, 9, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4382), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "InventoryAdjustment",
                columns: new[] { "AdjustmentID", "AdjustmentDate", "AdjustmentType", "PartID", "Quantity", "Reason" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 4, 3, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4137), "Manual Correction", 4, 5, "Stock correction" },
                    { 5, new DateTime(2025, 4, 6, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4140), "Restock", 5, 12, "New shipment" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "OrderID", "PartID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 4, 3, 1, 4, 75.00m },
                    { 5, 3, 4, 1, 150.00m },
                    { 6, 4, 5, 2, 87.75m },
                    { 7, 5, 2, 1, 220.00m }
                });

            migrationBuilder.InsertData(
                table: "PartSupplier",
                columns: new[] { "PartSuppliersID", "PartID", "SupplierID" },
                values: new object[,]
                {
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 7, 2, 3 },
                    { 8, 3, 4 },
                    { 9, 4, 5 },
                    { 10, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "SuppliersDelivery",
                columns: new[] { "SupplierDeliveryID", "DeliveryTime", "PartID", "SupplierID" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 4, 6, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4371), 3, 3 },
                    { 4, new DateTime(2025, 4, 4, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4374), 4, 4 },
                    { 5, new DateTime(2025, 4, 8, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4377), 5, 5 },
                    { 8, new DateTime(2025, 4, 5, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4384), 4, 3 },
                    { 9, new DateTime(2025, 4, 3, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4388), 5, 4 },
                    { 10, new DateTime(2025, 4, 2, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4390), 1, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "FirstName", "LastName" },
                values: new object[] { "123 Main St", "John", "Doe" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "Address",
                value: "456 Elm St");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "Address",
                value: "789 Park Ave");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                column: "Address",
                value: "321 Ocean Rd");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                column: "Address",
                value: "160 River St");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Alice", new DateTime(2023, 4, 10, 15, 8, 1, 880, DateTimeKind.Local).AddTicks(1269), "Johnson" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 4, 10, 15, 8, 1, 880, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 10, 15, 8, 1, 880, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 1,
                columns: new[] { "AdjustmentDate", "Quantity", "Reason" },
                values: new object[] { new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 10, "Monthly restock" });

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 2,
                columns: new[] { "AdjustmentDate", "Quantity", "Reason" },
                values: new object[] { new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), -2, "Warehouse damage" });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "UnitPrice",
                value: 49.99m);

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "OrderID", "UnitPrice" },
                values: new object[] { 2, 19.99m });

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 99.98m });

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "OrderDate", "Status", "TotalAmount" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Pending", 19.99m });

            migrationBuilder.UpdateData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 1,
                columns: new[] { "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[] { "High performance", null, "Brake Pad", 49.99m, 30 });

            migrationBuilder.UpdateData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 2,
                columns: new[] { "Category", "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[] { "Engine", "Synthetic", null, "Oil Filter", 19.99m, 50 });

            migrationBuilder.UpdateData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 3,
                columns: new[] { "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[] { "Complete set", null, "Clutch Kit", 199.99m, 10 });

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 1,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 2,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
