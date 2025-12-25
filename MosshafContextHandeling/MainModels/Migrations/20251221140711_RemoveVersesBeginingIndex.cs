using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVersesBeginingIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VersesBeginningIndexs");

            migrationBuilder.RenameColumn(
                name: "LetterId",
                table: "Ayas",
                newName: "BeginningLetterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeginningLetterId",
                table: "Ayas",
                newName: "LetterId");

            migrationBuilder.CreateTable(
                name: "VersesBeginningIndexs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    LetterId = table.Column<int>(type: "int", nullable: true),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersesBeginningIndexs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersesBeginningIndexs_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VersesBeginningIndexs_AyaId",
                table: "VersesBeginningIndexs",
                column: "AyaId");
        }
    }
}
