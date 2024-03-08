using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smartmei.Migrations
{
    public partial class D01TabelaProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    DataInicioProjeto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFimProjeto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuantidadeTelas = table.Column<int>(type: "int", nullable: false),
                    ValorTela = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotalProjeto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrazoPagamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmissaoNF = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPagamentoNF = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Acompanhamento = table.Column<int>(type: "int", nullable: false),
                    Diaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataInicioEvento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFimEvento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkDrive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
