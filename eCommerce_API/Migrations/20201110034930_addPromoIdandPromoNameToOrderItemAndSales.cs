using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_API_RST.Migrations
{
    public partial class addPromoIdandPromoNameToOrderItemAndSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "promo_id",
                table: "sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "promo_name",
                table: "sales",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "promo_id",
                table: "order_item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "promo_name",
                table: "order_item",
                maxLength: 128,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "promo_id",
                table: "sales");

            migrationBuilder.DropColumn(
                name: "promo_name",
                table: "sales");

            migrationBuilder.DropColumn(
                name: "promo_id",
                table: "order_item");

            migrationBuilder.DropColumn(
                name: "promo_name",
                table: "order_item");
        }
    }
}
