using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addTafseerTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TafseerBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MappedColumnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TafseerBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tafseers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Elgalalen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ibnkathir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mohet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kortoby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kadeer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elmoysar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EzzSalam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elwaseet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baedawy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aysar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baaawy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nasafy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Montkhab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mawrdy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bnothemen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mara7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tabary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saady1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baseet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hatem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arafa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZadAlMaser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zahra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moqatel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dorar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mafateh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoharrerWageez = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DorAlMason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatthBian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mojahed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SofianAlThawry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tasheel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazzaqSanaany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameeBianEegy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maraghi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aazb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Safwat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KashafZamakhshary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WageezWahdy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShaarawyNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErshadSaood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Many = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahasenQasmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tahreer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qatan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tafseers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tafseers_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tafseers_AyaId",
                table: "Tafseers",
                column: "AyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TafseerBooks");

            migrationBuilder.DropTable(
                name: "Tafseers");
        }
    }
}
