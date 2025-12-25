using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class editAyaAndSuraTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuranId",
                table: "Ayas");

            migrationBuilder.DropColumn(
                name: "SuraName",
                table: "Ayas");

            migrationBuilder.RenameColumn(
                name: "SuraNo",
                table: "Ayas",
                newName: "SuraId");

            migrationBuilder.RenameColumn(
                name: "RobNo",
                table: "Ayas",
                newName: "RobeeNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suras",
                table: "Suras",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Suras",
                table: "Suras");

            migrationBuilder.RenameColumn(
                name: "SuraId",
                table: "Ayas",
                newName: "SuraNo");

            migrationBuilder.RenameColumn(
                name: "RobeeNo",
                table: "Ayas",
                newName: "RobNo");

            migrationBuilder.AddColumn<int>(
                name: "QuranId",
                table: "Ayas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuraName",
                table: "Ayas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
