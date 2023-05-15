using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinamentoWebAPI.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "poder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    habilidade = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_poder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "super_heroi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    identidade_secreta = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    data_aparicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    poder_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_super_heroi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_super_heroi_poder_poder_id",
                        column: x => x.poder_id,
                        principalTable: "poder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_poder_habilidade",
                table: "poder",
                column: "habilidade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_super_heroi_nome",
                table: "super_heroi",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_super_heroi_poder_id",
                table: "super_heroi",
                column: "poder_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "super_heroi");

            migrationBuilder.DropTable(
                name: "poder");
        }
    }
}
