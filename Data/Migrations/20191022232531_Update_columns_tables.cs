using Microsoft.EntityFrameworkCore.Migrations;

namespace frontend.Data.Migrations
{
    public partial class Update_columns_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsariosNotaVinho",
                table: "UsariosNotaVinho");

            migrationBuilder.RenameTable(
                name: "UsariosNotaVinho",
                newName: "UsuariosNotaVinhos");

            migrationBuilder.RenameColumn(
                name: "TipoVinho",
                table: "Vinhos",
                newName: "IdTipoVinho");

            migrationBuilder.RenameColumn(
                name: "TipoOcasiao",
                table: "Vinhos",
                newName: "IdTipoOcasiao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuariosNotaVinhos",
                table: "UsuariosNotaVinhos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuariosNotaVinhos",
                table: "UsuariosNotaVinhos");

            migrationBuilder.RenameTable(
                name: "UsuariosNotaVinhos",
                newName: "UsariosNotaVinho");

            migrationBuilder.RenameColumn(
                name: "IdTipoVinho",
                table: "Vinhos",
                newName: "TipoVinho");

            migrationBuilder.RenameColumn(
                name: "IdTipoOcasiao",
                table: "Vinhos",
                newName: "TipoOcasiao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsariosNotaVinho",
                table: "UsariosNotaVinho",
                column: "Id");
        }
    }
}
