using Microsoft.EntityFrameworkCore.Migrations;

namespace Ofi.App.Persistencia.Migrations
{
    public partial class Entidades1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personas_secretarias_ProveedoresDeServicio_unidadServicioid",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "numeroOficinas",
                table: "secretarias");

            migrationBuilder.DropColumn(
                name: "oficinas",
                table: "gobernaciones");

            migrationBuilder.RenameColumn(
                name: "ProveedoresDeServicio_unidadServicioid",
                table: "personas",
                newName: "ProveedoresDeServicios_unidadServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_personas_ProveedoresDeServicio_unidadServicioid",
                table: "personas",
                newName: "IX_personas_ProveedoresDeServicios_unidadServicioid");

            migrationBuilder.AddColumn<int>(
                name: "Gobernacionid",
                table: "secretarias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Secretariaid",
                table: "oficinas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "gobernaciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_secretarias_Gobernacionid",
                table: "secretarias",
                column: "Gobernacionid");

            migrationBuilder.CreateIndex(
                name: "IX_oficinas_Secretariaid",
                table: "oficinas",
                column: "Secretariaid");

            migrationBuilder.AddForeignKey(
                name: "FK_oficinas_secretarias_Secretariaid",
                table: "oficinas",
                column: "Secretariaid",
                principalTable: "secretarias",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_secretarias_ProveedoresDeServicios_unidadServicioid",
                table: "personas",
                column: "ProveedoresDeServicios_unidadServicioid",
                principalTable: "secretarias",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_secretarias_gobernaciones_Gobernacionid",
                table: "secretarias",
                column: "Gobernacionid",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_oficinas_secretarias_Secretariaid",
                table: "oficinas");

            migrationBuilder.DropForeignKey(
                name: "FK_personas_secretarias_ProveedoresDeServicios_unidadServicioid",
                table: "personas");

            migrationBuilder.DropForeignKey(
                name: "FK_secretarias_gobernaciones_Gobernacionid",
                table: "secretarias");

            migrationBuilder.DropIndex(
                name: "IX_secretarias_Gobernacionid",
                table: "secretarias");

            migrationBuilder.DropIndex(
                name: "IX_oficinas_Secretariaid",
                table: "oficinas");

            migrationBuilder.DropColumn(
                name: "Gobernacionid",
                table: "secretarias");

            migrationBuilder.DropColumn(
                name: "Secretariaid",
                table: "oficinas");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "gobernaciones");

            migrationBuilder.RenameColumn(
                name: "ProveedoresDeServicios_unidadServicioid",
                table: "personas",
                newName: "ProveedoresDeServicio_unidadServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_personas_ProveedoresDeServicios_unidadServicioid",
                table: "personas",
                newName: "IX_personas_ProveedoresDeServicio_unidadServicioid");

            migrationBuilder.AddColumn<int>(
                name: "numeroOficinas",
                table: "secretarias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "oficinas",
                table: "gobernaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_secretarias_ProveedoresDeServicio_unidadServicioid",
                table: "personas",
                column: "ProveedoresDeServicio_unidadServicioid",
                principalTable: "secretarias",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
