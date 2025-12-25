using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class renameAhkamModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Maram",
                table: "Ahkams",
                newName: "NaylMaram");

            migrationBuilder.RenameColumn(
                name: "Kia",
                table: "Ahkams",
                newName: "Kiaharsy");

            migrationBuilder.RenameColumn(
                name: "Gah",
                table: "Ahkams",
                newName: "Gahdamy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NaylMaram",
                table: "Ahkams",
                newName: "Maram");

            migrationBuilder.RenameColumn(
                name: "Kiaharsy",
                table: "Ahkams",
                newName: "Kia");

            migrationBuilder.RenameColumn(
                name: "Gahdamy",
                table: "Ahkams",
                newName: "Gah");
        }
    }
}
