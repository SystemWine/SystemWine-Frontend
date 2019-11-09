using Microsoft.EntityFrameworkCore.Migrations;

namespace frontend.Data.Migrations
{
    public partial class alter_vinho_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Vinhos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoOcasiao",
                table: "Vinhos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoVinho",
                table: "Vinhos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Vinhos");

            migrationBuilder.DropColumn(
                name: "TipoOcasiao",
                table: "Vinhos");

            migrationBuilder.DropColumn(
                name: "TipoVinho",
                table: "Vinhos");
        }
    }
}
