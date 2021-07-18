using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAndFood.Migrations
{
    public partial class idare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yonetims");

            migrationBuilder.CreateTable(
                name: "Idares",
                columns: table => new
                {
                    IdareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idarekullaniciadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Idaresifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IdareRole = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idares", x => x.IdareId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Idares");

            migrationBuilder.CreateTable(
                name: "Yonetims",
                columns: table => new
                {
                    AdminiD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminKullaniciAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AdminRole = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    AdminSifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetims", x => x.AdminiD);
                });
        }
    }
}
