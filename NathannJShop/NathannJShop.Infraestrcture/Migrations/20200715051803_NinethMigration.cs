using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class NinethMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VentasXProductos_Devoluciones_DevolucionId",
                table: "VentasXProductos");

            migrationBuilder.DropIndex(
                name: "IX_VentasXProductos_DevolucionId",
                table: "VentasXProductos");

            migrationBuilder.DropColumn(
                name: "DevolucionId",
                table: "VentasXProductos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DevolucionId",
                table: "VentasXProductos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VentasXProductos_DevolucionId",
                table: "VentasXProductos",
                column: "DevolucionId");

            migrationBuilder.AddForeignKey(
                name: "FK_VentasXProductos_Devoluciones_DevolucionId",
                table: "VentasXProductos",
                column: "DevolucionId",
                principalTable: "Devoluciones",
                principalColumn: "DevolucionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
