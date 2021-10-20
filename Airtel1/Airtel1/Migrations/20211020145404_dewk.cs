using Microsoft.EntityFrameworkCore.Migrations;

namespace Airtel1.Migrations
{
    public partial class dewk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "RoamingPlans");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "phoneRecharges");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "internationals");

            migrationBuilder.AddColumn<string>(
                name: "Descrip",
                table: "RoamingPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrip",
                table: "phoneRecharges",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrip",
                table: "internationals",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrip",
                table: "RoamingPlans");

            migrationBuilder.DropColumn(
                name: "Descrip",
                table: "phoneRecharges");

            migrationBuilder.DropColumn(
                name: "Descrip",
                table: "internationals");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "RoamingPlans",
                type: "varchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "phoneRecharges",
                type: "varchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "internationals",
                type: "varchar(MAX)",
                nullable: true);
        }
    }
}
