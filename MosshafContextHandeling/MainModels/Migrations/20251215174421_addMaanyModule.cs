using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addMaanyModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaanyBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaanyBookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaanyBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaanyBooks_MaanyBooks_MaanyBookId",
                        column: x => x.MaanyBookId,
                        principalTable: "MaanyBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Maanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageNo = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaanyBookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maanies_MaanyBooks_MaanyBookId",
                        column: x => x.MaanyBookId,
                        principalTable: "MaanyBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maanies_MaanyBookId",
                table: "Maanies",
                column: "MaanyBookId");

            migrationBuilder.CreateIndex(
                name: "IX_MaanyBooks_MaanyBookId",
                table: "MaanyBooks",
                column: "MaanyBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maanies");

            migrationBuilder.DropTable(
                name: "MaanyBooks");
        }
    }
}
