using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeastTuners.Migrations
{
    /// <inheritdoc />
    public partial class useradded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderResult_Customer_CustomerID",
                table: "OrderResult");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_OrderResult_CustomerID",
                table: "OrderResult");

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

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "OrderResult");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "OrderResult",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "int",
                nullable: true);


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

            migrationBuilder.CreateIndex(
                name: "IX_OrderResult_UserID",
                table: "OrderResult",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderResult_AspNetUsers_UserID",
                table: "OrderResult",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderResult_AspNetUsers_UserID",
                table: "OrderResult");

            migrationBuilder.DropIndex(
                name: "IX_OrderResult_UserID",
                table: "OrderResult");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "OrderResult");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "OrderResult",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Main St, New Lynn", "Zoheba", "Ali", "0212345678" },
                    { 2, "456 Elm St, Avondale", "Jane", "Smith", "0276543210" },
                    { 3, "789 Park Ave, Avondale", "Mike", "Brown", "0214455667" },
                    { 4, "321 Ocean Rd, Manukau", "Sara", "Lee", "0229988776" },
                    { 5, "160 River St, New Lynn", "Chris", "Taylor", "0271122334" },
                    { 6, "212 Rosebank Rd, Avondale", "Mujahid", "Raza", "0226538745" },
                    { 7, "160 Riverton Dr, Papatoetoe", "Falisha", "Umaynah", "0271187334" },
                    { 8, "56 Ash St, Avondael", "Yashween", "Singh", "0271137334" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "FirstName", "HireDate", "LastName", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 1, "Sheik", new DateTime(2023, 4, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3871), "Farhaan", "0229988776", 0 },
                    { 2, "Bob", new DateTime(2024, 4, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3954), "Williams", "0211234987", 0 },
                    { 3, "Ethan", new DateTime(2024, 6, 11, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(3957), "Wilson", "0204567890", 0 },
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
                column: "AdjustmentDate",
                value: new DateTime(2025, 3, 27, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 2,
                column: "AdjustmentDate",
                value: new DateTime(2025, 3, 30, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 3,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 1, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 4,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 3, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "InventoryAdjustment",
                keyColumn: "AdjustmentID",
                keyValue: 5,
                column: "AdjustmentDate",
                value: new DateTime(2025, 4, 6, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4140));

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

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 3,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 6, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 4,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 4, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 5,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 8, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 6,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 10, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 7,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 9, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 8,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 5, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 9,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 3, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "SuppliersDelivery",
                keyColumn: "SupplierDeliveryID",
                keyValue: 10,
                column: "DeliveryTime",
                value: new DateTime(2025, 4, 2, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.InsertData(
                table: "OrderResult",
                columns: new[] { "OrderID", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 1, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4225), "Shipped", 450.00m },
                    { 2, 2, new DateTime(2025, 4, 3, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4229), "Delivered", 120.00m },
                    { 3, 3, new DateTime(2025, 4, 6, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4232), "Processing", 300.00m },
                    { 4, 4, new DateTime(2025, 4, 8, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4235), "Cancelled", 175.50m },
                    { 5, 5, new DateTime(2025, 4, 10, 21, 43, 54, 894, DateTimeKind.Local).AddTicks(4238), "Pending", 220.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderResult_CustomerID",
                table: "OrderResult",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderResult_Customer_CustomerID",
                table: "OrderResult",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
