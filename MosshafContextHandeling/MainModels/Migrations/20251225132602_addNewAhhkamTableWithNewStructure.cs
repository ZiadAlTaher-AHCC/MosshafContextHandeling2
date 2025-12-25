using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addNewAhhkamTableWithNewStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ahhkams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AhkamBookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ahhkams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ahhkams_AhkamBooks_AhkamBookId",
                        column: x => x.AhkamBookId,
                        principalTable: "AhkamBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ahhkams_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ahhkams_AhkamBookId",
                table: "Ahhkams",
                column: "AhkamBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Ahhkams_AyaId",
                table: "Ahhkams",
                column: "AyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ahhkams");
        }
    }
}
