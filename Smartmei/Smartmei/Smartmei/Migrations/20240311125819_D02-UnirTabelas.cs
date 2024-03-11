using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smartmei.Migrations
{
    public partial class D02UnirTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Projetos_ClienteId",
                table: "Projetos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_ProjetoId",
                table: "Eventos",
                column: "ProjetoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Projetos_ProjetoId",
                table: "Eventos",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Clientes_ClienteId",
                table: "Projetos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Projetos_ProjetoId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Clientes_ClienteId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_ClienteId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_ProjetoId",
                table: "Eventos");
        }
    }
}
