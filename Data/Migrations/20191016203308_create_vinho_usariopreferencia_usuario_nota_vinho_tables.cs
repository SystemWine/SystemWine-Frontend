using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace frontend.Data.Migrations
{
    public partial class create_vinho_usariopreferencia_usuario_nota_vinho_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsariosNotaVinho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    IdVinho = table.Column<int>(nullable: false),
                    Nota = table.Column<double>(nullable: false),
                    MyProperty = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsariosNotaVinho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosPreferencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    IdTipoUva = table.Column<int>(nullable: false),
                    IdPais = table.Column<int>(nullable: false),
                    IdRegiao = table.Column<int>(nullable: false),
                    ValorMax = table.Column<double>(nullable: false),
                    ValorMin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosPreferencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vinhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    IdRegiao = table.Column<int>(nullable: false),
                    IdPais = table.Column<int>(nullable: false),
                    IdTipoUva = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinhos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsariosNotaVinho");

            migrationBuilder.DropTable(
                name: "UsuariosPreferencia");

            migrationBuilder.DropTable(
                name: "Vinhos");
        }
    }
}
