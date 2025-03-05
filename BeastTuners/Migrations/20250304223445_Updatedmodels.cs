using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeastTuners.Migrations
{
    /// <inheritdoc />
    public partial class Updatedmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Part",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Part",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Part");
        }
    }
}
