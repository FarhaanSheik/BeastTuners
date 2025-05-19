using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeastTuners.Migrations
{
    /// <inheritdoc />
    public partial class seededdatafororderanduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HireDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user1", 0, "1 Main Street", "7c2c62cf-4300-4649-bbf9-d5471dacef1b", "user1@example.com", true, "John", null, "Doe", false, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBe+MyCb2szsfjal2lqF6ETtVl+Xbt0C4QcPIjLtOXafwM/1VgRTv9X6qaqYcmqdZA==", "0210000001", false, null, "a2dabd68-7356-4fbc-87c9-cec8dc7cdba4", false, "user1@example.com", "Customer" },
                    { "user2", 0, "2 Oak Road", "01ecc855-5ef3-4ff8-b9e6-4a88f049b053", "user2@example.com", true, "Alice", null, "Smith", false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKT13HuBnNbQxteRUWq4dBRBNCbGanL3XRyPDWd1e//Safmmj9/twsmZteqiNwAvJA==", "0210000002", false, null, "bb58d0c3-bb7f-4025-aeca-c9049ed2610c", false, "user2@example.com", "Customer" },
                    { "user3", 0, "3 Beachside Ave", "1065d1b6-96c9-4006-92f8-2770a3e07960", "user3@example.com", true, "Ethan", null, "Williams", false, null, "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAELkcMPxiHTDJhzxTLRRQ1Ix+AsCGTJ6+yLmWiEMRcxp7o3NbL9psq/rf+TXxl/gISQ==", "0210000003", false, null, "793e6360-4da3-4a73-904e-f889a72da89c", false, "user3@example.com", "Customer" },
                    { "user4", 0, "4 Valley Rd", "63d351e2-f7e3-451d-9f54-9a506895735c", "user4@example.com", true, "Sarah", null, "Lee", false, null, "USER4@EXAMPLE.COM", "USER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIQM+niceX4AlYyVaT6OnfIU7OSXxsnOvdV2wXHFyYwmO4pSDqfny+mkQnBwu05P+Q==", "0210000004", false, null, "7b4fd13b-5624-411b-ad3e-224769693e12", false, "user4@example.com", "Customer" },
                    { "user5", 0, "5 Racecourse Rd", "bb05870f-c7e2-4857-bf0e-8d9346366507", "user5@example.com", true, "James", null, "Nguyen", false, null, "USER5@EXAMPLE.COM", "USER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAELaD22QLrHswz4mCjZkQnqIM1+Yfklf0CMrLKFQXoKgru0+HN5EvDwgEqzkBI0X8/w==", "0210000005", false, null, "c1a64717-f680-4136-b081-a8282033dcfc", false, "user5@example.com", "Customer" }
                });

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 1,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 27, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 2,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 30, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 3,
                column: "AdjustmentDate",
                value: new DateTime(2025, 5, 2, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 4,
                column: "AdjustmentDate",
                value: new DateTime(2025, 5, 4, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 5,
                column: "AdjustmentDate",
                value: new DateTime(2025, 5, 7, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 1,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 27, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 2,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 2, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 3,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 7, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 4,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 5, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 5,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 9, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 6,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 11, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 7,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 10, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 8,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 6, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 9,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 4, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 10,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 3, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.InsertData(
                table: "OrderResult",
                columns: new[] { "OrderID", "OrderDate", "Status", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 2, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(5178), "Completed", 495.00m, "user1" },
                    { 2, new DateTime(2025, 5, 3, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(5216), "Pending", 120.00m, "user2" },
                    { 3, new DateTime(2025, 5, 4, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(5222), "Completed", 450.00m, "user3" },
                    { 4, new DateTime(2025, 5, 5, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(5679), "Pending", 175.50m, "user4" },
                    { 5, new DateTime(2025, 5, 6, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(5749), "Cancelled", 220.00m, "user5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 2);

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5");

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 1,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 17, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 2,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 20, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 3,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 22, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 4,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 24, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 5,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 27, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 1,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 17, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 2,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 22, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 3,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 27, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 4,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 25, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 5,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 29, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 6,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 1, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 7,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 30, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 8,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 26, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 9,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 24, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 10,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 23, 10, 50, 44, 674, DateTimeKind.Local).AddTicks(2102));
        }
    }
}
