using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addNewTragemTableWithNewStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TragemsNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TragemBookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TragemsNew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TragemsNew_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TragemsNew_TragemBooks_TragemBookId",
                        column: x => x.TragemBookId,
                        principalTable: "TragemBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TragemsNew_AyaId",
                table: "TragemsNew",
                column: "AyaId");

            migrationBuilder.CreateIndex(
                name: "IX_TragemsNew_TragemBookId",
                table: "TragemsNew",
                column: "TragemBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TragemsNew");
        }
    }
}
