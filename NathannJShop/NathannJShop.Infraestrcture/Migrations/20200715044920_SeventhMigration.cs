using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ventas",
                table: "ventas");

            migrationBuilder.RenameTable(
                name: "ventas",
                newName: "Ventas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas",
                column: "VentaId");

            migrationBuilder.CreateTable(
                name: "VentasXProductos",
                columns: table => new
                {
                    VentaId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasXProductos", x => new { x.ProductoId, x.VentaId });
                    table.ForeignKey(
                        name: "FK_VentasXProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VentasXProductos_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentasXProductos_VentaId",
                table: "VentasXProductos",
                column: "VentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentasXProductos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas");

            migrationBuilder.RenameTable(
                name: "Ventas",
                newName: "ventas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ventas",
                table: "ventas",
                column: "VentaId");
        }
    }
}
