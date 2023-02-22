using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsole.Migrations
{
    /// <inheritdoc />
    public partial class Db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBatchs_Products_ProductID",
                table: "ProductBatchs");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductBatchs",
                newName: "ProductFK");

            migrationBuilder.RenameIndex(
                name: "IX_ProductBatchs_ProductID",
                table: "ProductBatchs",
                newName: "IX_ProductBatchs_ProductFK");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBatchs_Products_ProductFK",
                table: "ProductBatchs",
                column: "ProductFK",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBatchs_Products_ProductFK",
                table: "ProductBatchs");

            migrationBuilder.RenameColumn(
                name: "ProductFK",
                table: "ProductBatchs",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductBatchs_ProductFK",
                table: "ProductBatchs",
                newName: "IX_ProductBatchs_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBatchs_Products_ProductID",
                table: "ProductBatchs",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
