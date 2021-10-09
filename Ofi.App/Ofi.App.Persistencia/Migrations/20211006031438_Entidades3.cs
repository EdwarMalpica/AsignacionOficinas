using Microsoft.EntityFrameworkCore.Migrations;

namespace Ofi.App.Persistencia.Migrations
{
    public partial class Entidades3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idPersona",
                table: "personas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idPersona",
                table: "personas");
        }
    }
}
