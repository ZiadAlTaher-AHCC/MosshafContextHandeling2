using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addMogamsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mogams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MogamBabId = table.Column<int>(type: "int", nullable: false),
                    MogamChapterNo = table.Column<int>(type: "int", nullable: true),
                    MogamBabNo = table.Column<int>(type: "int", nullable: true),
                    MogamBookNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mogams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mogams_MogamBabs_MogamBabId",
                        column: x => x.MogamBabId,
                        principalTable: "MogamBabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mogams_MogamBabId",
                table: "Mogams",
                column: "MogamBabId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mogams");
        }
    }
}
