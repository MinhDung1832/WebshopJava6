using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT_POLY_CHSARP5.Data.Migrations
{
    public partial class FPOLY_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "FOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 18, 22, 28, 18, 369, DateTimeKind.Local).AddTicks(5150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 18, 21, 53, 4, 429, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.InsertData(
                table: "FCategories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[] { 1, true, null, 1, 1 });

            migrationBuilder.InsertData(
                table: "FProducts",
                columns: new[] { "Id", "DateCreated", "OriginalPrice", "Price", "SeoAlias", "Stock", "ViewCount" },
                values: new object[] { 1, new DateTime(2021, 5, 18, 22, 28, 18, 382, DateTimeKind.Local).AddTicks(2951), 30000m, 50000m, "Dungna1", 150, 500 });

            migrationBuilder.InsertData(
                table: "FProducts",
                columns: new[] { "Id", "DateCreated", "OriginalPrice", "Price", "SeoAlias", "Stock", "ViewCount" },
                values: new object[] { 2, new DateTime(2021, 5, 18, 22, 28, 18, 382, DateTimeKind.Local).AddTicks(3519), 50000m, 900000m, "Dungna2", 150, 600 });

            migrationBuilder.InsertData(
                table: "FProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "FProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "FOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 18, 21, 53, 4, 429, DateTimeKind.Local).AddTicks(6487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 18, 22, 28, 18, 369, DateTimeKind.Local).AddTicks(5150));
        }
    }
}
