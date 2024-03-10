using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smartmei.Migrations
{
    public partial class D04TabelaEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjetoId = table.Column<int>(type: "int", nullable: false),
                    DataEventoInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEventoFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
