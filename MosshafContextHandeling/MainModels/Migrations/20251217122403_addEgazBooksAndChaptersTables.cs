using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addEgazBooksAndChaptersTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EgazBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MappedColumnName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgazBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EgazChapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EgazBookId = table.Column<int>(type: "int", nullable: false),
                    EgazChapterNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgazChapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgazChapters_EgazBooks_EgazBookId",
                        column: x => x.EgazBookId,
                        principalTable: "EgazBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EgazChapters_EgazBookId",
                table: "EgazChapters",
                column: "EgazBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgazChapters");

            migrationBuilder.DropTable(
                name: "EgazBooks");
        }
    }
}
