using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeastTuners.Migrations
{
    /// <inheritdoc />
    public partial class updateduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9c553535-34f5-46cb-828a-9b67a0319a3f", "John@gmail.com", "JOHN@GMAIL.COM", "JOHN@GMAIL.COM", "AQAAAAIAAYagAAAAEKKHT3VDBNT0x35QtK05rS/E+/bT01AcJDHFut+r1oS7VJw6l874rbFPEsKnbGoinA==", "beb34d8c-ac72-4fb4-8f62-84818a4b4363", "John@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3bb82cfb-c816-4813-82e4-99dd48d2a84e", "Alice@yahoo.com", "ALICE@YAHOO.COM", "ALICE@YAHOO.COM", "AQAAAAIAAYagAAAAEEvy6Y70nx8yR9Tb5s58TjevzzEbhKDbrF0yfIKKEr7AwV6OyD1LKFkj/vM5t+jGXg==", "72b39505-b374-467d-824f-b24a287cdb87", "Alice@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3c5e1d31-fde0-4a5f-bdc7-bfc187e52745", "Ethan@gmail.com", "ETHAN@GMAIL.COM", "ETHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEM0HU4njZGtFZImYJTjbxfWiMKrchmQzIYtoowmwyxCPfIlFhbNW6YAwxteQVtsvow==", "9d52a478-9d4b-49d8-a2c5-b14235b6ea9a", "Ethan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "37f1ad40-fa76-498c-9f7e-543b28c5c690", "Sarah@gmail.com", "SARAH@GMAIL.COM", "SARAH@GMAIL.COM", "AQAAAAIAAYagAAAAEMRcSoKEPnJE5Tvw5SUY+ltEmB89iPAAT9c0W8FUxyRGLxLfrcMcoghWD4NlKL9vlQ==", "7ea6bc65-2833-49fd-af98-1b46419048ab", "Sarah@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "32049e19-0837-4679-bd99-9edae55955ff", "James@gmail.com", "JAMES@GMAIL.COM", "JAMES@GMAIL.COM", "AQAAAAIAAYagAAAAEHRjqebH2vpjiv1sHRXmtoO0qjvBZeHznH+YSOjoJ1QPioLKaDZmsIIiFECs+jfF8g==", "5e5c3225-35ab-4600-bdc6-a5b22eca0afe", "James@gmail.com" });

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 1,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 28, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 2,
                column: "AdjustmentDate",
                value: new DateTime(2025, 5, 1, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 3,
                column: "AdjustmentDate",
                value: new DateTime(2025, 5, 3, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 4,
                column: "AdjustmentDate",
                value: new DateTime(2025, 5, 5, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 5,
                column: "AdjustmentDate",
                value: new DateTime(2025, 5, 8, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 3, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 4, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 5, 5, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 5, 6, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 5, 7, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 1,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 28, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 2,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 3, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 3,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 8, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 4,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 6, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 5,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 10, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 6,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 12, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 7,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 11, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 8,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 7, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 9,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 5, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 10,
                column: "DeliveryTime",
                value: new DateTime(2025, 5, 4, 10, 33, 58, 809, DateTimeKind.Local).AddTicks(3326));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7c2c62cf-4300-4649-bbf9-d5471dacef1b", "user1@example.com", "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBe+MyCb2szsfjal2lqF6ETtVl+Xbt0C4QcPIjLtOXafwM/1VgRTv9X6qaqYcmqdZA==", "a2dabd68-7356-4fbc-87c9-cec8dc7cdba4", "user1@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "01ecc855-5ef3-4ff8-b9e6-4a88f049b053", "user2@example.com", "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKT13HuBnNbQxteRUWq4dBRBNCbGanL3XRyPDWd1e//Safmmj9/twsmZteqiNwAvJA==", "bb58d0c3-bb7f-4025-aeca-c9049ed2610c", "user2@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1065d1b6-96c9-4006-92f8-2770a3e07960", "user3@example.com", "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAELkcMPxiHTDJhzxTLRRQ1Ix+AsCGTJ6+yLmWiEMRcxp7o3NbL9psq/rf+TXxl/gISQ==", "793e6360-4da3-4a73-904e-f889a72da89c", "user3@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "63d351e2-f7e3-451d-9f54-9a506895735c", "user4@example.com", "USER4@EXAMPLE.COM", "USER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIQM+niceX4AlYyVaT6OnfIU7OSXxsnOvdV2wXHFyYwmO4pSDqfny+mkQnBwu05P+Q==", "7b4fd13b-5624-411b-ad3e-224769693e12", "user4@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bb05870f-c7e2-4857-bf0e-8d9346366507", "user5@example.com", "USER5@EXAMPLE.COM", "USER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAELaD22QLrHswz4mCjZkQnqIM1+Yfklf0CMrLKFQXoKgru0+HN5EvDwgEqzkBI0X8/w==", "c1a64717-f680-4136-b081-a8282033dcfc", "user5@example.com" });

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
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 2, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 3, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 5, 4, 11, 54, 6, 35, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 5, 5, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "OrderResult",
                keyColumn: "OrderID",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 5, 6, 11, 54, 6, 36, DateTimeKind.Local).AddTicks(5749));

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
        }
    }
}
