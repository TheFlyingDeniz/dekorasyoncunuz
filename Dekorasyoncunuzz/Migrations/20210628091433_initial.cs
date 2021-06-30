using Microsoft.EntityFrameworkCore.Migrations;

namespace Dekorasyoncunuzz.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dekorasyonlar",
                columns: table => new
                {
                    Dekorasyon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dekorasyon_fiyat = table.Column<int>(type: "int", nullable: false),
                    Dekorasyon_isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dekorasyon_cinsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dekorasyon_marka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dekorasyonlar", x => x.Dekorasyon_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dekorasyonlar");
        }
    }
}
