using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.Migrations
{
    /// <inheritdoc />
    public partial class addActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TbProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TbCatageries",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TbProducts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TbCatageries");
        }
    }
}
