using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jewelry_Web_Api.Migrations
{
    /// <inheritdoc />
    public partial class removedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Rings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Rings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
