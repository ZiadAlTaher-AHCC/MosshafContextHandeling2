using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addNewAsbabNozoolTableWithNewStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsbabNozoolsNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsbabNozoolBookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsbabNozoolsNew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsbabNozoolsNew_AsbabNozoolBooks_AsbabNozoolBookId",
                        column: x => x.AsbabNozoolBookId,
                        principalTable: "AsbabNozoolBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AsbabNozoolsNew_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsbabNozoolsNew_AsbabNozoolBookId",
                table: "AsbabNozoolsNew",
                column: "AsbabNozoolBookId");

            migrationBuilder.CreateIndex(
                name: "IX_AsbabNozoolsNew_AyaId",
                table: "AsbabNozoolsNew",
                column: "AyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsbabNozoolsNew");
        }
    }
}
