using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addNavPropToAyaAndSura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ayas_SuraId",
                table: "Ayas",
                column: "SuraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ayas_Suras_SuraId",
                table: "Ayas",
                column: "SuraId",
                principalTable: "Suras",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ayas_Suras_SuraId",
                table: "Ayas");

            migrationBuilder.DropIndex(
                name: "IX_Ayas_SuraId",
                table: "Ayas");
        }
    }
}
