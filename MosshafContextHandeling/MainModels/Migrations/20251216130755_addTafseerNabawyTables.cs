using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addTafseerNabawyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TafseerNabawies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerseNo = table.Column<int>(type: "int", nullable: false),
                    Selid = table.Column<int>(type: "int", nullable: true),
                    SuraId = table.Column<int>(type: "int", nullable: false),
                    Taraf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HadithTxt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HadithSearch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TafseerNabawies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TafseerNabawies_Suras_SuraId",
                        column: x => x.SuraId,
                        principalTable: "Suras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TafseerNabawies_SuraId",
                table: "TafseerNabawies",
                column: "SuraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TafseerNabawies");
        }
    }
}
