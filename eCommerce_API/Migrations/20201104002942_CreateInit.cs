using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_API_RST.Migrations
{
    public partial class CreateInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FreeDelivery",
                table: "code_relations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "cart",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "oversea",
                table: "card",
                nullable: false,
                defaultValueSql: "((1))");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "card",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "card",
                nullable: true);


            migrationBuilder.CreateTable(
                name: "message_board",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    subject = table.Column<string>(maxLength: 50, nullable: false),
                    content = table.Column<string>(maxLength: 1000, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message_board", x => x.id);
                });


            migrationBuilder.CreateTable(
                name: "ShippingInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    orderId = table.Column<int>(nullable: false),
                    sender = table.Column<string>(nullable: true),
                    sender_phone = table.Column<string>(nullable: true),
                    sender_address = table.Column<string>(nullable: true),
                    sender_city = table.Column<string>(nullable: true),
                    sender_country = table.Column<string>(nullable: true),
                    receiver = table.Column<string>(nullable: true),
                    receiver_company = table.Column<string>(nullable: true),
                    receiver_address1 = table.Column<string>(nullable: true),
                    receiver_address2 = table.Column<string>(nullable: true),
                    receiver_address3 = table.Column<string>(nullable: true),
                    receiver_city = table.Column<string>(nullable: true),
                    receiver_country = table.Column<string>(nullable: true),
                    receiver_phone = table.Column<string>(nullable: true),
                    zip = table.Column<string>(nullable: true),
                    receiver_contact = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShippingInfo_orders_orderId",
                        column: x => x.orderId,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingInfo_orderId",
                table: "ShippingInfo",
                column: "orderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dispatch");

            migrationBuilder.DropTable(
                name: "message_board");

            migrationBuilder.DropTable(
                name: "purchase");

            migrationBuilder.DropTable(
                name: "purchase_item");

            migrationBuilder.DropTable(
                name: "ShippingInfo");

            migrationBuilder.DropColumn(
                name: "FreeDelivery",
                table: "code_relations");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "cart");

            migrationBuilder.DropColumn(
                name: "oversea",
                table: "card");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "card");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "card");
        }
    }
}
