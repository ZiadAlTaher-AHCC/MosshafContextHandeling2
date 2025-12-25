using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addLetterIdToAya : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SearchAyaa",
                table: "Ayas");

            migrationBuilder.AddColumn<int>(
                name: "LetterId",
                table: "Ayas",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LetterId",
                table: "Ayas");

            migrationBuilder.AddColumn<string>(
                name: "SearchAyaa",
                table: "Ayas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
