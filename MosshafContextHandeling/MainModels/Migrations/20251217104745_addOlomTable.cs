using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addOlomTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oloms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BabId = table.Column<int>(type: "int", nullable: false),
                    ChapterNo = table.Column<int>(type: "int", nullable: true),
                    BabNo = table.Column<int>(type: "int", nullable: true),
                    SubBabNo = table.Column<int>(type: "int", nullable: true),
                    OlomBookNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oloms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oloms_OlomBabs_BabId",
                        column: x => x.BabId,
                        principalTable: "OlomBabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oloms_BabId",
                table: "Oloms",
                column: "BabId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oloms");
        }
    }
}
