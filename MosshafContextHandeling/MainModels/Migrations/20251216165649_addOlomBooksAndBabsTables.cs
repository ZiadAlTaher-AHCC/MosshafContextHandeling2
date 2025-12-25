using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addOlomBooksAndBabsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OlomBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MappedColumnName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlomBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OlomChapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlomBookId = table.Column<int>(type: "int", nullable: true),
                    ChapterNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlomChapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OlomChapters_OlomBooks_OlomBookId",
                        column: x => x.OlomBookId,
                        principalTable: "OlomBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OlomChapters_OlomBookId",
                table: "OlomChapters",
                column: "OlomBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OlomChapters");

            migrationBuilder.DropTable(
                name: "OlomBooks");
        }
    }
}
