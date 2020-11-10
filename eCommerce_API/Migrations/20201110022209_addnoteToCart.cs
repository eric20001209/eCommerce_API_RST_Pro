using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_API_RST.Migrations
{
    public partial class addnoteToCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "unit",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((1))",
                oldClrType: typeof(int),
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<decimal>(
                name: "rrp",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<int>(
                name: "redeem_point",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "real_stock",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<double>(
                name: "rate",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((1.1))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((1.1))");

            migrationBuilder.AlterColumn<double>(
                name: "qty_break_discount1",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "qty_break1",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((5))",
                oldClrType: typeof(int),
                oldDefaultValueSql: "((5))");

            migrationBuilder.AlterColumn<int>(
                name: "qpos_qty_break",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "price_system",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price9",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price8",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price7",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price6",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price5",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price4",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price3",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price2",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "price1",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<bool>(
                name: "pick_date",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<decimal>(
                name: "nzd_freight",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<bool>(
                name: "no_discount",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "new_item",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<float>(
                name: "moq",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((1))",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<double>(
                name: "manual_exchange_rate",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((1))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<decimal>(
                name: "manual_cost_nzd",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "manual_cost_frd",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<int>(
                name: "low_stock",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "line2_font",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((9))",
                oldClrType: typeof(int),
                oldDefaultValueSql: "((9))");

            migrationBuilder.AlterColumn<int>(
                name: "line1_font",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((9))",
                oldClrType: typeof(int),
                oldDefaultValueSql: "((9))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate6",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((78))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((78))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate5",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((80))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((80))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate4",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((85))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((85))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate3",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((90))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((90))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate2",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((95))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((95))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate1",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((100))",
                oldClrType: typeof(double),
                oldDefaultValueSql: "((100))");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price9",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price8",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price7",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price6",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price5",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price4",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price3",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price2",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price1",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price0",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<bool>(
                name: "is_website_item",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "is_void_discount",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "is_special",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "is_service",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "is_member_only",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "is_id_check",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "is_barcodeprice",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "inner_pack",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "hidden",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "has_scale",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "do_not_rounddown",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "disappeared",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "date_range",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "currency",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((1))",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<int>(
                name: "costofsales_account",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((5111))",
                oldClrType: typeof(int),
                oldDefaultValueSql: "((5111))");

            migrationBuilder.AlterColumn<bool>(
                name: "core_range",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<double>(
                name: "commission_rate",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<bool>(
                name: "avoid_point",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<decimal>(
                name: "average_cost",
                table: "code_relations",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<int>(
                name: "allocated_stock",
                table: "code_relations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "note",
                table: "cart",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "note",
                table: "cart");

            migrationBuilder.AlterColumn<int>(
                name: "unit",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<decimal>(
                name: "rrp",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "redeem_point",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "real_stock",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "rate",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((1.1))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((1.1))");

            migrationBuilder.AlterColumn<double>(
                name: "qty_break_discount1",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "qty_break1",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((5))",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((5))");

            migrationBuilder.AlterColumn<int>(
                name: "qpos_qty_break",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price_system",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price9",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price8",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price7",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price6",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price5",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price4",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price3",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price2",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price1",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "pick_date",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "nzd_freight",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "no_discount",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "new_item",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "moq",
                table: "code_relations",
                nullable: true,
                defaultValueSql: "((1))",
                oldClrType: typeof(float),
                oldNullable: true,
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<double>(
                name: "manual_exchange_rate",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<decimal>(
                name: "manual_cost_nzd",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "manual_cost_frd",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "low_stock",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "line2_font",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((9))",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((9))");

            migrationBuilder.AlterColumn<int>(
                name: "line1_font",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((9))",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((9))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate6",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((78))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((78))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate5",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((80))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((80))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate4",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((85))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((85))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate3",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((90))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((90))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate2",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((95))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((95))");

            migrationBuilder.AlterColumn<double>(
                name: "level_rate1",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((100))",
                oldClrType: typeof(double),
                oldNullable: true,
                oldDefaultValueSql: "((100))");

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price9",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price8",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price7",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price6",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price5",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price4",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price3",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price2",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price1",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "level_price0",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_website_item",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_void_discount",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_special",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_service",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_member_only",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_id_check",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_barcodeprice",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "inner_pack",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "hidden",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "has_scale",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "do_not_rounddown",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "disappeared",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "date_range",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "currency",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<int>(
                name: "costofsales_account",
                table: "code_relations",
                nullable: false,
                defaultValueSql: "((5111))",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((5111))");

            migrationBuilder.AlterColumn<bool>(
                name: "core_range",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "commission_rate",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "avoid_point",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "average_cost",
                table: "code_relations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "allocated_stock",
                table: "code_relations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
