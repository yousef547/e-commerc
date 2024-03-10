using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.Migrations
{
    /// <inheritdoc />
    public partial class CreateEcommerce : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbCatageries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCatageries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TbCatageryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbProducts_TbCatageries_TbCatageryId",
                        column: x => x.TbCatageryId,
                        principalTable: "TbCatageries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TbColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TbProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbColors_TbProducts_TbProductId",
                        column: x => x.TbProductId,
                        principalTable: "TbProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TbSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TbProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbSizes_TbProducts_TbProductId",
                        column: x => x.TbProductId,
                        principalTable: "TbProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbColors_TbProductId",
                table: "TbColors",
                column: "TbProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TbProducts_TbCatageryId",
                table: "TbProducts",
                column: "TbCatageryId");

            migrationBuilder.CreateIndex(
                name: "IX_TbSizes_TbProductId",
                table: "TbSizes",
                column: "TbProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbColors");

            migrationBuilder.DropTable(
                name: "TbSizes");

            migrationBuilder.DropTable(
                name: "TbProducts");

            migrationBuilder.DropTable(
                name: "TbCatageries");
        }
    }
}
