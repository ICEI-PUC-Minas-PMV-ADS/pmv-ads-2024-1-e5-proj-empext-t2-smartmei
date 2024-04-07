using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smartmei.Migrations
{
    public partial class D03TabelaMei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Projetos_MeiId",
                table: "Projetos",
                column: "MeiId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturamento_MeiId",
                table: "Faturamento",
                column: "MeiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faturamento_Mei_MeiId",
                table: "Faturamento",
                column: "MeiId",
                principalTable: "Mei",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Mei_MeiId",
                table: "Projetos",
                column: "MeiId",
                principalTable: "Mei",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturamento_Mei_MeiId",
                table: "Faturamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Mei_MeiId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_MeiId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Faturamento_MeiId",
                table: "Faturamento");
        }
    }
}
