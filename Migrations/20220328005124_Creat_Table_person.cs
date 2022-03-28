using Microsoft.EntityFrameworkCore.Migrations;

namespace VuVanDuc2022483.Migrations
{
    public partial class Creat_Table_person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PersonName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "VVD0483",
                columns: table => new
                {
                    VVDId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    VVDName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    VVDGender = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VVD0483", x => x.VVDId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "VVD0483");
        }
    }
}
