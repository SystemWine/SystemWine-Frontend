using Microsoft.EntityFrameworkCore.Migrations;

namespace frontend.Data.Migrations
{
    public partial class alter_relationship_type_from_user_wine_votes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "UsuariosNotaVinhos");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "UsuariosNotaVinhos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosNotaVinhos_UsuarioId",
                table: "UsuariosNotaVinhos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosNotaVinhos_AspNetUsers_UsuarioId",
                table: "UsuariosNotaVinhos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosNotaVinhos_AspNetUsers_UsuarioId",
                table: "UsuariosNotaVinhos");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosNotaVinhos_UsuarioId",
                table: "UsuariosNotaVinhos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "UsuariosNotaVinhos");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "UsuariosNotaVinhos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
