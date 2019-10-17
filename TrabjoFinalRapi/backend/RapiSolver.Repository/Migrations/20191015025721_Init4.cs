using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolver.Repository.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roles_usuarios_UsuarioId",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "roles");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuarios",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "roles",
                newName: "RolId");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "roles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_roles_usuarios_UsuarioId",
                table: "roles",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roles_usuarios_UsuarioId",
                table: "roles");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "roles",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "roles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "roles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_roles_usuarios_UsuarioId",
                table: "roles",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
