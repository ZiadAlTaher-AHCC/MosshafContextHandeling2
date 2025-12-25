using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addTragemTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tragems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Gverse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    English2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngAhmedAli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngYusufAli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngQarai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngAhmedRazaKhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngArberry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngAsad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngDaryabadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngHilaliAndKhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngClearQuranGod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngClearQuranAllah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngCommunityGod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngCommunityAllah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngKhattab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngMaududi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngMubarakpuri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngPickthall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngSarwar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngQaribullahAndDarwish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Germany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Japanese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chinese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Italy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Indo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sahly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rusha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hendi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Malawy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Polg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Polsh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fares = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Torki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Braz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishShaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    German2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "IX_Tragems_AyaId",
                table: "Tragems",
                column: "AyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tragems");
        }
    }
}
