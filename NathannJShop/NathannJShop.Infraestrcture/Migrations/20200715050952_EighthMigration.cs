using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class EighthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DevolucionId",
                table: "VentasXProductos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Devoluciones",
                columns: table => new
                {
                    DevolucionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Queja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devoluciones", x => x.DevolucionId);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    GastoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.GastoId);
                });

            migrationBuilder.CreateTable(
                name: "DevolucionesXProductos",
                columns: table => new
                {
                    DevolucionId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevolucionesXProductos", x => new { x.ProductoId, x.DevolucionId });
                    table.ForeignKey(
                        name: "FK_DevolucionesXProductos_Devoluciones_DevolucionId",
                        column: x => x.DevolucionId,
                        principalTable: "Devoluciones",
                        principalColumn: "DevolucionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevolucionesXProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GastosXProductos",
                columns: table => new
                {
                    GastoId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastosXProductos", x => new { x.ProductoId, x.GastoId });
                    table.ForeignKey(
                        name: "FK_GastosXProductos_Gastos_GastoId",
                        column: x => x.GastoId,
                        principalTable: "Gastos",
                        principalColumn: "GastoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GastosXProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentasXProductos_DevolucionId",
                table: "VentasXProductos",
                column: "DevolucionId");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucionesXProductos_DevolucionId",
                table: "DevolucionesXProductos",
                column: "DevolucionId");

            migrationBuilder.CreateIndex(
                name: "IX_GastosXProductos_GastoId",
                table: "GastosXProductos",
                column: "GastoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VentasXProductos_Devoluciones_DevolucionId",
                table: "VentasXProductos",
                column: "DevolucionId",
                principalTable: "Devoluciones",
                principalColumn: "DevolucionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VentasXProductos_Devoluciones_DevolucionId",
                table: "VentasXProductos");

            migrationBuilder.DropTable(
                name: "DevolucionesXProductos");

            migrationBuilder.DropTable(
                name: "GastosXProductos");

            migrationBuilder.DropTable(
                name: "Devoluciones");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_VentasXProductos_DevolucionId",
                table: "VentasXProductos");

            migrationBuilder.DropColumn(
                name: "DevolucionId",
                table: "VentasXProductos");
        }
    }
}
