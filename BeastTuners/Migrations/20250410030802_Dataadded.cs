using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeastTuners.Migrations
{
    /// <inheritdoc />
    public partial class Dataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 3, "789 Park Ave", "Mike", "Brown", "0214455667" },
                    { 4, "321 Ocean Rd", "Sara", "Lee", "0229988776" },
                    { 5, "160 River St", "Chris", "Taylor", "0271122334" }
                });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 4, 10, 15, 8, 1, 880, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 4, 10, 15, 8, 1, 880, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "FirstName", "HireDate", "LastName", "PhoneNumber", "Role" },
                values: new object[] { 3, "Ethan", new DateTime(2024, 6, 10, 15, 8, 1, 880, DateTimeKind.Local).AddTicks(1375), "Wilson", "0204567890", 0 });

            migrationBuilder.InsertData(
                table: "OrderResult",
                columns: new[] { "OrderID", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Shipped", 99.98m },
                    { 2, 2, new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Pending", 19.99m }
                });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "PartID", "Category", "Description", "ImagePath", "PartName", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Brakes", "High performance", null, "Brake Pad", 49.99m, 30 },
                    { 2, "Engine", "Synthetic", null, "Oil Filter", 19.99m, 50 },
                    { 3, "Engine", "Complete set", null, "Clutch Kit", 199.99m, 10 }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierID", "Address", "PhoneNumber", "SupplierName" },
                values: new object[,]
                {
                    { 1, "88 Workshop Lane", "0800123456", "AutoParts NZ" },
                    { 2, "42 Mechanics Rd", "0800456789", "GearCo" }
                });

            migrationBuilder.InsertData(
                table: "InventoryAdjustment",
                columns: new[] { "AdjustmentID", "AdjustmentDate", "AdjustmentType", "PartID", "Quantity", "Reason" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), "Restock", 1, 10, "Monthly restock" },
                    { 2, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Damaged", 2, -2, "Warehouse damage" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "OrderID", "PartID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, 49.99m },
                    { 2, 2, 2, 1, 19.99m }
                });

            migrationBuilder.InsertData(
                table: "PartSupplier",
                columns: new[] { "PartSuppliersID", "PartID", "SupplierID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "SuppliersDelivery",
                columns: new[] { "SupplierDeliveryID", "DeliveryTime", "PartID", "SupplierID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, 1 },
                    { 2, new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PartSupplier",
                keyColumn: "PartSuppliersID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "PartID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 4, 10, 14, 49, 44, 646, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2025, 3, 11, 14, 49, 44, 646, DateTimeKind.Local).AddTicks(8022));
        }
    }
}
