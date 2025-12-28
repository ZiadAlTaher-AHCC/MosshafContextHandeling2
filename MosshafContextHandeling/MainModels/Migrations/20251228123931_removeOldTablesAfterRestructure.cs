using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class removeOldTablesAfterRestructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ahkams");

            migrationBuilder.DropTable(
                name: "AsbabNozools");

            migrationBuilder.DropTable(
                name: "Tafseers");

            migrationBuilder.DropTable(
                name: "Tragems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ahkams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Araby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gahdamy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gasas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kiaharsy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NaylMaram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rwaee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ahkams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ahkams_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AsbabNozools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    Eegab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Esteaab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lebab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Moharrer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mosnad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsbabNozools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsbabNozools_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tafseers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Aazb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arafa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aysar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baaawy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baedawy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baseet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bnothemen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DorAlMason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dorar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elgalalen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elmoysar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elwaseet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErshadSaood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EzzSalam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatthBian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameeBianEegy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hatem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ibnkathir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kadeer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KashafZamakhshary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kortoby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mafateh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahasenQasmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Many = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mara7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maraghi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mawrdy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoharrerWageez = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mohet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mojahed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Montkhab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moqatel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nasafy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazzaqSanaany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saady1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Safwat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShaarawyNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SofianAlThawry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tabary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tahreer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tasheel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WageezWahdy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZadAlMaser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zahra = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Tragems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Alb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Braz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chinese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngAhmedAli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngAhmedRazaKhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngArberry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngAsad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngClearQuranAllah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngClearQuranGod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngCommunityAllah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngCommunityGod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngDaryabadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngHilaliAndKhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngKhattab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngMaududi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngMubarakpuri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngPickthall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngQarai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngQaribullahAndDarwish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngSarwar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngYusufAli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    English2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishShaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fares = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    German2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Germany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gverse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hendi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Indo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Italy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Japanese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Malawy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Polg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Polsh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rusha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sahly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Torki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tragems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tragems_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ahkams_AyaId",
                table: "Ahkams",
                column: "AyaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsbabNozools_AyaId",
                table: "AsbabNozools",
                column: "AyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tafseers_AyaId",
                table: "Tafseers",
                column: "AyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tragems_AyaId",
                table: "Tragems",
                column: "AyaId");
        }
    }
}
