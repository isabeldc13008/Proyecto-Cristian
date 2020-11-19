using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCristian.Migrations
{
    public partial class Migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    Id_compra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(nullable: false,defaultValue:DateTime.Now),
                    Id_usuario = table.Column<int>(nullable: false),
                    cantidad = table.Column<int>(nullable: false),
                    valor = table.Column<int>(nullable: false),
                    usuarioid_usuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compras", x => x.Id_compra);
                    table.ForeignKey(
                        name: "FK_compras_usuarios_usuarioid_usuario",
                        column: x => x.usuarioid_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "detalleCompra",
                columns: table => new
                {
                    id_detallecompra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_producto = table.Column<int>(nullable: false),
                    id_compra = table.Column<int>(nullable: false),
                    productoid_productos = table.Column<int>(nullable: true),
                    compraId_compra = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleCompra", x => x.id_detallecompra);
                    table.ForeignKey(
                        name: "FK_detalleCompra_compras_compraId_compra",
                        column: x => x.compraId_compra,
                        principalTable: "compras",
                        principalColumn: "Id_compra",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_detalleCompra_productos_productoid_productos",
                        column: x => x.productoid_productos,
                        principalTable: "productos",
                        principalColumn: "id_productos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compras_usuarioid_usuario",
                table: "compras",
                column: "usuarioid_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_detalleCompra_compraId_compra",
                table: "detalleCompra",
                column: "compraId_compra");

            migrationBuilder.CreateIndex(
                name: "IX_detalleCompra_productoid_productos",
                table: "detalleCompra",
                column: "productoid_productos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleCompra");

            migrationBuilder.DropTable(
                name: "compras");
        }
    }
}
