using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolver.Repository.Migrations
{
    public partial class Init13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "suppliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "suppliers");

            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "customers");
        }
    }
}
