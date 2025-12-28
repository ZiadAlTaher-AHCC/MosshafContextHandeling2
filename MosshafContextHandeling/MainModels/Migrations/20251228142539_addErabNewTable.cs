using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addErabNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErabsNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErabBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErabsNew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ErabsNew_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ErabsNew_ErabBooks_ErabBookId",
                        column: x => x.ErabBookId,
                        principalTable: "ErabBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ErabsNew_AyaId",
                table: "ErabsNew",
                column: "AyaId");

            migrationBuilder.CreateIndex(
                name: "IX_ErabsNew_ErabBookId",
                table: "ErabsNew",
                column: "ErabBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErabsNew");
        }
    }
}
