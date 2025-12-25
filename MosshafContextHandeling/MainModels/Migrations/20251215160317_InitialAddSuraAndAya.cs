using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class InitialAddSuraAndAya : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ayas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: true),
                    QuranId = table.Column<int>(type: "int", nullable: true),
                    Verse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerseNoSign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNo = table.Column<int>(type: "int", nullable: true),
                    PartNo = table.Column<int>(type: "int", nullable: true),
                    HezbNo = table.Column<int>(type: "int", nullable: true),
                    RobNo = table.Column<int>(type: "int", nullable: true),
                    VerseNo = table.Column<int>(type: "int", nullable: true),
                    VerseNoAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuraNo = table.Column<int>(type: "int", nullable: true),
                    SuraName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sound = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgWarsh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchAyaa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Suras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NoOfVerses = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SabbTasmia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Taareef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mwadee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SabbNzol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fadl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ayas");

            migrationBuilder.DropTable(
                name: "Suras");
        }
    }
}
