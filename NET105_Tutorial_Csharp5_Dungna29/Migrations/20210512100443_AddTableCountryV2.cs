using Microsoft.EntityFrameworkCore.Migrations;

namespace NET105_Tutorial_Csharp5_Dungna29.Migrations
{
    public partial class AddTableCountryV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Country_CountryProductId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Product",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "CountryProductId",
                table: "Product",
                newName: "CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CountryProductId",
                table: "Product",
                newName: "IX_Product_CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Country_CountryID",
                table: "Product",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Country_CountryID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Product",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "Product",
                newName: "CountryProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CountryID",
                table: "Product",
                newName: "IX_Product_CountryProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Country_CountryProductId",
                table: "Product",
                column: "CountryProductId",
                principalTable: "Country",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
