using Microsoft.EntityFrameworkCore.Migrations;

namespace frontend.Data.Migrations
{
    public partial class fix_column_usuarionotavinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "UsariosNotaVinho",
                newName: "Data");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "UsariosNotaVinho",
                newName: "MyProperty");
        }
    }
}
