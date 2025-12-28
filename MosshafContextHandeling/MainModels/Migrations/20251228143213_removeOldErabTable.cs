using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class removeOldErabTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Erabs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Erabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    Daas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Darwish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gadwal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kharat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nahas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tbian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Erabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Erabs_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Erabs_AyaId",
                table: "Erabs",
                column: "AyaId");
        }
    }
}
