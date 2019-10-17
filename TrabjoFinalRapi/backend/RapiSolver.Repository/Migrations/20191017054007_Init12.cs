using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolver.Repository.Migrations
{
    public partial class Init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "suppliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "suppliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "suppliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "suppliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "suppliers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "suppliers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "suppliers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "suppliers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "customers");
        }
    }
}
