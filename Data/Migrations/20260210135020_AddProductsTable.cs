using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyMvcAuthProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "CreatedDate", "Description", "IsActive", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Electronics", new DateTime(2026, 2, 10, 13, 50, 19, 438, DateTimeKind.Utc).AddTicks(5644), "High-performance laptop for development", true, "Laptop", 999.99m, 15 },
                    { 2, "Accessories", new DateTime(2026, 2, 10, 13, 50, 19, 438, DateTimeKind.Utc).AddTicks(5646), "Ergonomic wireless mouse", true, "Wireless Mouse", 29.99m, 50 },
                    { 3, "Cables", new DateTime(2026, 2, 10, 13, 50, 19, 438, DateTimeKind.Utc).AddTicks(5649), "High-speed USB-C charging cable", true, "USB-C Cable", 14.99m, 100 },
                    { 4, "Accessories", new DateTime(2026, 2, 10, 13, 50, 19, 438, DateTimeKind.Utc).AddTicks(5650), "RGB mechanical keyboard with switches", true, "Mechanical Keyboard", 129.99m, 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
