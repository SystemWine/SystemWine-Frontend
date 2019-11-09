using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace frontend.Data.Migrations
{
    public partial class add_tipo_vindo_add_fk_vinho_tipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTipoVinho",
                table: "Vinhos");

            migrationBuilder.AddColumn<int>(
                name: "TipoVinhoId",
                table: "Vinhos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoVinho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVinho", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vinhos_TipoVinhoId",
                table: "Vinhos",
                column: "TipoVinhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinhos_TipoVinho_TipoVinhoId",
                table: "Vinhos",
                column: "TipoVinhoId",
                principalTable: "TipoVinho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinhos_TipoVinho_TipoVinhoId",
                table: "Vinhos");

            migrationBuilder.DropTable(
                name: "TipoVinho");

            migrationBuilder.DropIndex(
                name: "IX_Vinhos_TipoVinhoId",
                table: "Vinhos");

            migrationBuilder.DropColumn(
                name: "TipoVinhoId",
                table: "Vinhos");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoVinho",
                table: "Vinhos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
