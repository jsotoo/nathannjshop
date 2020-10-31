using Microsoft.EntityFrameworkCore.Migrations;

namespace NathannJShop.Infraestructure.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Promocion_PromocionId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitud",
                table: "Solicitud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promocion",
                table: "Promocion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Solicitud");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Promocion");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categoria");

            migrationBuilder.AddColumn<int>(
                name: "SolicitudId",
                table: "Solicitud",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PromocionId",
                table: "Promocion",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Categoria",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Promocion_PromocionId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitud",
                table: "Solicitud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promocion",
                table: "Promocion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "SolicitudId",
                table: "Solicitud");

            migrationBuilder.DropColumn(
                name: "PromocionId",
                table: "Promocion");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Categoria");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Solicitud",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Promocion",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitud",
                table: "Solicitud",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promocion",
                table: "Promocion",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Promocion_PromocionId",
                table: "Productos",
                column: "PromocionId",
                principalTable: "Promocion",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
