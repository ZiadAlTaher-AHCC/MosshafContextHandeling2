using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addAsbabNozoolModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsbabNozoolBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MappedColumnName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsbabNozoolBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsbabNozools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    Lebab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mosnad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eegab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Esteaab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Moharrer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsbabNozools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsbabNozools_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsbabNozools_AyaId",
                table: "AsbabNozools",
                column: "AyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsbabNozoolBooks");

            migrationBuilder.DropTable(
                name: "AsbabNozools");
        }
    }
}
