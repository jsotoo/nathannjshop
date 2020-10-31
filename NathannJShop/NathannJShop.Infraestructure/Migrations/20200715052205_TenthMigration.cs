using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class TenthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Solicitudes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Solicitudes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
