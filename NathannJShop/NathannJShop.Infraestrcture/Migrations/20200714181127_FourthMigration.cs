using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "SolicitudTipoId",
                table: "Solicitudes");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_TipoId",
                table: "Solicitudes",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_TipoId",
                table: "Solicitudes",
                column: "TipoId",
                principalTable: "SolicitudesTipos",
                principalColumn: "SolicitudTipoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_TipoId",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_TipoId",
                table: "Solicitudes");

            migrationBuilder.AddColumn<int>(
                name: "SolicitudTipoId",
                table: "Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_SolicitudTipoId",
                table: "Solicitudes",
                column: "SolicitudTipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_SolicitudesTipos_SolicitudTipoId",
                table: "Solicitudes",
                column: "SolicitudTipoId",
                principalTable: "SolicitudesTipos",
                principalColumn: "SolicitudTipoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
