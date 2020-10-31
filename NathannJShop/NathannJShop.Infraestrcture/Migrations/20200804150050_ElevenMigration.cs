using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class ElevenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Ventas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ventas");
        }
    }
}
