using Microsoft.EntityFrameworkCore.Migrations;

namespace VueShopApi.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                schema: "ps",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Sizes",
                schema: "ps",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sizes",
                schema: "ps",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                schema: "ps",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
