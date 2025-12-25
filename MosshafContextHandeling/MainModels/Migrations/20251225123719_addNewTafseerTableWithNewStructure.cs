using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addNewTafseerTableWithNewStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tafsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TafseerBookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tafsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tafsers_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tafsers_TafseerBooks_TafseerBookId",
                        column: x => x.TafseerBookId,
                        principalTable: "TafseerBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tafsers_AyaId",
                table: "Tafsers",
                column: "AyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tafsers_TafseerBookId",
                table: "Tafsers",
                column: "TafseerBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tafsers");
        }
    }
}
