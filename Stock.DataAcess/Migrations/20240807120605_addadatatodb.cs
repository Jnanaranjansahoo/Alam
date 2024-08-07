using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Stock.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addadatatodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 101, 1001, "it is a good pen", "", "Pen", 50m },
                    { 102, 1002, "it is a good pen", "", "Pensil", 50m },
                    { 103, 1001, "it is a good pen", "", "Pepshi", 50m },
                    { 104, 1002, "it is a good pen", "", "banana", 50m },
                    { 105, 1003, "it is a good pen", "", "mango", 50m },
                    { 106, 1003, "it is a good pen", "", "applr", 50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1001, "it is a good pen", "", "Pen", 50m },
                    { 2, 1002, "it is a good pen", "", "Pensil", 50m },
                    { 3, 1001, "it is a good pen", "", "Pepshi", 50m },
                    { 4, 1002, "it is a good pen", "", "banana", 50m },
                    { 5, 1003, "it is a good pen", "", "mango", 50m },
                    { 6, 1003, "it is a good pen", "", "applr", 50m }
                });
        }
    }
}
