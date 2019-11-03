using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolver.Repository.Migrations
{
    public partial class Init31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recommendations_customers_CustomerId",
                table: "recommendations");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "recommendations",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_recommendations_CustomerId",
                table: "recommendations",
                newName: "IX_recommendations_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_recommendations_usuarios_UsuarioId",
                table: "recommendations",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recommendations_usuarios_UsuarioId",
                table: "recommendations");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "recommendations",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_recommendations_UsuarioId",
                table: "recommendations",
                newName: "IX_recommendations_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_recommendations_customers_CustomerId",
                table: "recommendations",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
