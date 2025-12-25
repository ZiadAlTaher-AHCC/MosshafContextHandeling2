using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addAhkamModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AhkamBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MappedColumnName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AhkamBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ahkams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Araby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gasas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rwaee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ahkams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ahkams_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ahkams_AyaId",
                table: "Ahkams",
                column: "AyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AhkamBooks");

            migrationBuilder.DropTable(
                name: "Ahkams");
        }
    }
}
