using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolver.Repository.Migrations
{
    public partial class Init30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Mark",
                table: "recommendations",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mark",
                table: "recommendations");
        }
    }
}
