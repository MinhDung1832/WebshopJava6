using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NET105_Tutorial_Csharp5_Dungna29.Migrations
{
    public partial class dungnav9999 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "FOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 27, 12, 45, 16, 608, DateTimeKind.Local).AddTicks(8179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 17, 0, 35, 52, 654, DateTimeKind.Local).AddTicks(6120));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "FOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 17, 0, 35, 52, 654, DateTimeKind.Local).AddTicks(6120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 27, 12, 45, 16, 608, DateTimeKind.Local).AddTicks(8179));
        }
    }
}
