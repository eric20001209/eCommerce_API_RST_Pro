using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_API_RST.Migrations.Freight
{
    public partial class CreateInitFreight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "freight_settings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    active = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    region = table.Column<string>(maxLength: 250, nullable: true),
                    freight = table.Column<decimal>(type: "money", nullable: false),
                    freeshipping_active_amount = table.Column<decimal>(type: "money", nullable: false),
                    FreightRangeStart1 = table.Column<decimal>(nullable: false),
                    FreightRangeStart2 = table.Column<decimal>(nullable: false),
                    FreightRangeStart3 = table.Column<decimal>(nullable: false),
                    FreightRangeEnd1 = table.Column<decimal>(nullable: false),
                    FreightRangeEnd2 = table.Column<decimal>(nullable: false),
                    FreightRangeEnd3 = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_freight_settings", x => x.id);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "freight_settings");

        }
    }
}
