using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addErabModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErabBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MappedColumnName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErabBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Erabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    Nahas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kharat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tbian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gadwal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Darwish = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErabBooks");

            migrationBuilder.DropTable(
                name: "Erabs");
        }
    }
}
