using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class ThrdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Promocion_PromocionId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitud_Productos_ProductoId",
                table: "Solicitud");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitud_SolicitudTipo_TipoId",
                table: "Solicitud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SolicitudTipo",
                table: "SolicitudTipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitud",
                table: "Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_Solicitud_TipoId",
                table: "Solicitud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promocion",
                table: "Promocion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "SolicitudTipo",
                newName: "SolicitudesTipos");

            migrationBuilder.RenameTable(
                name: "Solicitud",
                newName: "Solicitudes");

            migrationBuilder.RenameTable(
                name: "Promocion",
                newName: "Promociones");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitud_ProductoId",
                table: "Solicitudes",
                newName: "IX_Solicitudes_ProductoId");

            migrationBuilder.AddColumn<int>(
                name: "SolicitudTipoId",
                table: "Solicitudes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolicitudesTipos",
                table: "SolicitudesTipos",
                column: "SolicitudTipoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitudes",
                table: "Solicitudes",
                column: "SolicitudId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promociones",
                table: "Promociones",
                column: "PromocionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.CreateTable(
                name: "EstadosSolicitudes",
                columns: table => new
                {
                    EstadoSolicitudId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudId = table.Column<int>(nullable: false),
                    NombreEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosSolicitudes", x => x.EstadoSolicitudId);
                    table.ForeignKey(
                        name: "FK_EstadosSolicitudes_Solicitudes_SolicitudId",
                        column: x => x.SolicitudId,
                        principalTable: "Solicitudes",
                        principalColumn: "SolicitudId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    TotalVenta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ventas", x => x.VentaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_SolicitudTipoId",
                table: "Solicitudes",
                column: "SolicitudTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosSolicitudes_SolicitudId",
                table: "EstadosSolicitudes",
                column: "SolicitudId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Promociones_PromocionId",
                table: "Productos",
                column: "PromocionId",
                principalTable: "Promociones",
                principalColumn: "PromocionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Productos_ProductoId",
                table: "Solicitudes",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_SolicitudTipoId",
                table: "Solicitudes",
                column: "SolicitudTipoId",
                principalTable: "SolicitudesTipos",
                principalColumn: "SolicitudTipoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Promociones_PromocionId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Productos_ProductoId",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.DropTable(
                name: "EstadosSolicitudes");

            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SolicitudesTipos",
                table: "SolicitudesTipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitudes",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promociones",
                table: "Promociones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.RenameTable(
                name: "SolicitudesTipos",
                newName: "SolicitudTipo");

            migrationBuilder.RenameTable(
                name: "Solicitudes",
                newName: "Solicitud");

            migrationBuilder.RenameTable(
                name: "Promociones",
                newName: "Promocion");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitudes_ProductoId",
                table: "Solicitud",
                newName: "IX_Solicitud_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolicitudTipo",
                table: "SolicitudTipo",
                column: "SolicitudTipoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitud",
                table: "Solicitud",
                column: "SolicitudId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promocion",
                table: "Promocion",
                column: "PromocionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_TipoId",
                table: "Solicitud",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Promocion_PromocionId",
                table: "Productos",
                column: "PromocionId",
                principalTable: "Promocion",
                principalColumn: "PromocionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitud_Productos_ProductoId",
                table: "Solicitud",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitud_SolicitudTipo_TipoId",
                table: "Solicitud",
                column: "TipoId",
                principalTable: "SolicitudTipo",
                principalColumn: "SolicitudTipoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
