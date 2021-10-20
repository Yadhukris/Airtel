using Microsoft.EntityFrameworkCore.Migrations;

namespace Airtel1.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "internationals",
                columns: table => new
                {
                    Inid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    validity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_internationals", x => x.Inid);
                });

            migrationBuilder.CreateTable(
                name: "phoneRecharges",
                columns: table => new
                {
                    PRid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    validity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phoneRecharges", x => x.PRid);
                });

            migrationBuilder.CreateTable(
                name: "RoamingPlans",
                columns: table => new
                {
                    Rid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    validity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoamingPlans", x => x.Rid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Pno = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Pno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "internationals");

            migrationBuilder.DropTable(
                name: "phoneRecharges");

            migrationBuilder.DropTable(
                name: "RoamingPlans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
