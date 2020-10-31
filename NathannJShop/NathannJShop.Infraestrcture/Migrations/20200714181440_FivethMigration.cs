using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class FivethMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_TipoId",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_TipoId",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_EstadosSolicitudes_SolicitudId",
                table: "EstadosSolicitudes");

            migrationBuilder.AddColumn<int>(
                name: "SolicitudTipoId",
                table: "Solicitudes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_SolicitudTipoId",
                table: "Solicitudes",
                column: "SolicitudTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosSolicitudes_SolicitudId",
                table: "EstadosSolicitudes",
                column: "SolicitudId",
                unique: true);

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
                name: "FK_Solicitudes_SolicitudesTipos_SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_EstadosSolicitudes_SolicitudId",
                table: "EstadosSolicitudes");

            migrationBuilder.DropColumn(
                name: "SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_TipoId",
                table: "Solicitudes",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosSolicitudes_SolicitudId",
                table: "EstadosSolicitudes",
                column: "SolicitudId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_TipoId",
                table: "Solicitudes",
                column: "TipoId",
                principalTable: "SolicitudesTipos",
                principalColumn: "SolicitudTipoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
