using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolver.Repository.Migrations
{
    public partial class Init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roles_usuarios_UsuarioId",
                table: "roles");

            migrationBuilder.DropIndex(
                name: "IX_roles_UsuarioId",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "roles");

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Publish",
                table: "roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_RolId",
                table: "usuarios",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_roles_RolId",
                table: "usuarios",
                column: "RolId",
                principalTable: "roles",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_roles_RolId",
                table: "usuarios");

            migrationBuilder.DropIndex(
                name: "IX_usuarios_RolId",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Publish",
                table: "roles");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "roles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_roles_UsuarioId",
                table: "roles",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_roles_usuarios_UsuarioId",
                table: "roles",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
