using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbProducts_TbCatageries_TbCatageryId",
                table: "TbProducts");

            migrationBuilder.DropIndex(
                name: "IX_TbProducts_TbCatageryId",
                table: "TbProducts");

            migrationBuilder.DropColumn(
                name: "TbCatageryId",
                table: "TbProducts");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "TbProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbProducts_CategoryId",
                table: "TbProducts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbProducts_TbCatageries_CategoryId",
                table: "TbProducts",
                column: "CategoryId",
                principalTable: "TbCatageries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbProducts_TbCatageries_CategoryId",
                table: "TbProducts");

            migrationBuilder.DropIndex(
                name: "IX_TbProducts_CategoryId",
                table: "TbProducts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "TbProducts");

            migrationBuilder.AddColumn<int>(
                name: "TbCatageryId",
                table: "TbProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbProducts_TbCatageryId",
                table: "TbProducts",
                column: "TbCatageryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbProducts_TbCatageries_TbCatageryId",
                table: "TbProducts",
                column: "TbCatageryId",
                principalTable: "TbCatageries",
                principalColumn: "Id");
        }
    }
}
