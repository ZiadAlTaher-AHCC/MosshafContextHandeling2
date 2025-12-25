using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addEgazBabsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EgazBabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    EgazChapterNo = table.Column<int>(type: "int", nullable: false),
                    EgazBookNo = table.Column<int>(type: "int", nullable: false),
                    BabNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgazBabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgazBabs_EgazBabs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "EgazBabs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EgazBabs_EgazChapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "EgazChapters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EgazBabs_ChapterId",
                table: "EgazBabs",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_EgazBabs_ParentId",
                table: "EgazBabs",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgazBabs");
        }
    }
}
