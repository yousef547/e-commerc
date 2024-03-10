using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.Migrations
{
    /// <inheritdoc />
    public partial class addRelationMenyToMeny : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbColors_TbProducts_TbProductId",
                table: "TbColors");

            migrationBuilder.DropForeignKey(
                name: "FK_TbSizes_TbProducts_TbProductId",
                table: "TbSizes");

            migrationBuilder.DropIndex(
                name: "IX_TbSizes_TbProductId",
                table: "TbSizes");

            migrationBuilder.DropIndex(
                name: "IX_TbColors_TbProductId",
                table: "TbColors");

            migrationBuilder.DropColumn(
                name: "TbProductId",
                table: "TbSizes");

            migrationBuilder.DropColumn(
                name: "TbProductId",
                table: "TbColors");

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColor_TbColors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "TbColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColor_TbProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TbProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSize_TbProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TbProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_TbSizes_ColorId",
                        column: x => x.ColorId,
                        principalTable: "TbSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_ColorId",
                table: "ProductColor",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_ProductId",
                table: "ProductColor",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ColorId",
                table: "ProductSize",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductId",
                table: "ProductSize",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.AddColumn<int>(
                name: "TbProductId",
                table: "TbSizes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TbProductId",
                table: "TbColors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbSizes_TbProductId",
                table: "TbSizes",
                column: "TbProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TbColors_TbProductId",
                table: "TbColors",
                column: "TbProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbColors_TbProducts_TbProductId",
                table: "TbColors",
                column: "TbProductId",
                principalTable: "TbProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbSizes_TbProducts_TbProductId",
                table: "TbSizes",
                column: "TbProductId",
                principalTable: "TbProducts",
                principalColumn: "Id");
        }
    }
}
