using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ofi.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gobernaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oficinas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gobernaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "secretarias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoSecretaria = table.Column<int>(type: "int", nullable: false),
                    numeroOficinas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secretarias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    estadoCovid = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    turno = table.Column<int>(type: "int", nullable: true),
                    unidadServicioid = table.Column<int>(type: "int", nullable: true),
                    servicioRealizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProveedoresDeServicio_unidadServicioid = table.Column<int>(type: "int", nullable: true),
                    despachoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_personas_secretarias_ProveedoresDeServicio_unidadServicioid",
                        column: x => x.ProveedoresDeServicio_unidadServicioid,
                        principalTable: "secretarias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personas_secretarias_unidadServicioid",
                        column: x => x.unidadServicioid,
                        principalTable: "secretarias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "oficinas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aforoMaximo = table.Column<int>(type: "int", nullable: false),
                    GobernadorYAsesorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oficinas", x => x.id);
                    table.ForeignKey(
                        name: "FK_oficinas_personas_GobernadorYAsesorid",
                        column: x => x.GobernadorYAsesorid,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reporte_covid",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    sintomas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaDiagnostico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tiempoAistamiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reporte_covid", x => x.id);
                    table.ForeignKey(
                        name: "FK_reporte_covid_personas_personaid",
                        column: x => x.personaid,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_oficinas_GobernadorYAsesorid",
                table: "oficinas",
                column: "GobernadorYAsesorid");

            migrationBuilder.CreateIndex(
                name: "IX_personas_despachoid",
                table: "personas",
                column: "despachoid");

            migrationBuilder.CreateIndex(
                name: "IX_personas_ProveedoresDeServicio_unidadServicioid",
                table: "personas",
                column: "ProveedoresDeServicio_unidadServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_personas_unidadServicioid",
                table: "personas",
                column: "unidadServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_covid_personaid",
                table: "reporte_covid",
                column: "personaid");

            migrationBuilder.AddForeignKey(
                name: "FK_personas_oficinas_despachoid",
                table: "personas",
                column: "despachoid",
                principalTable: "oficinas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_oficinas_personas_GobernadorYAsesorid",
                table: "oficinas");

            migrationBuilder.DropTable(
                name: "gobernaciones");

            migrationBuilder.DropTable(
                name: "reporte_covid");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "oficinas");

            migrationBuilder.DropTable(
                name: "secretarias");
        }
    }
}
