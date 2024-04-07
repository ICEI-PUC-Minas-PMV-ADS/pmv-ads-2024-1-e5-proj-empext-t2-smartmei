using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smartmei.Migrations
{
    public partial class D01TabelaFaturamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faturamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    ValorBruto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustoMensal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorLiquidoMensal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MeiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturamento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faturamento");
        }
    }
}
