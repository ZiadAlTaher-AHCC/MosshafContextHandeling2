using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addOlomBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OlomBabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    BabNo = table.Column<int>(type: "int", nullable: true),
                    ChapterNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlomBabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OlomBabs_OlomBabs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "OlomBabs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OlomBabs_OlomChapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "OlomChapters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OlomBabs_ChapterId",
                table: "OlomBabs",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_OlomBabs_ParentId",
                table: "OlomBabs",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OlomBabs");
        }
    }
}
