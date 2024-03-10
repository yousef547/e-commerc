using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateTableProductSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_TbSizes_ColorId",
                table: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_ProductSize_ColorId",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ProductSize");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_SizeId",
                table: "ProductSize",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_TbSizes_SizeId",
                table: "ProductSize",
                column: "SizeId",
                principalTable: "TbSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_TbSizes_SizeId",
                table: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_ProductSize_SizeId",
                table: "ProductSize");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ProductSize",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ColorId",
                table: "ProductSize",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_TbSizes_ColorId",
                table: "ProductSize",
                column: "ColorId",
                principalTable: "TbSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
