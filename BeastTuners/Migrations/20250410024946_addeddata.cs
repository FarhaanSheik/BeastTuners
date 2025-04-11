using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeastTuners.Migrations
{
    /// <inheritdoc />
    public partial class addeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Main St", "John", "Doe", "0212345678" },
                    { 2, "456 Elm St", "Jane", "Smith", "0276543210" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "FirstName", "HireDate", "LastName", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 1, "Alice", new DateTime(2025, 4, 10, 14, 49, 44, 646, DateTimeKind.Local).AddTicks(7938), "Johnson", "0229988776", 0 },
                    { 2, "Bob", new DateTime(2025, 3, 11, 14, 49, 44, 646, DateTimeKind.Local).AddTicks(8022), "Williams", "0211234987", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
