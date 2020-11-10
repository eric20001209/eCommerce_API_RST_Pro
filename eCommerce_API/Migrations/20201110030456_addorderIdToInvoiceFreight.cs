using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_API_RST.Migrations
{
    public partial class addorderIdToInvoiceFreight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "invoice_freight",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "tax_rate",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((0.15))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((0.15))");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_freight_orderId",
                table: "invoice_freight",
                column: "orderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_invoice_freight_orderId",
                table: "invoice_freight");

            migrationBuilder.AlterColumn<int>(
                name: "orderId",
                table: "invoice_freight",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "tax_rate",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((0.15))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((0.15))");
        }
    }
}
