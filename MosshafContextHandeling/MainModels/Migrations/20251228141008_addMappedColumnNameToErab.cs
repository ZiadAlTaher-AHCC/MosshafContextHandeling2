using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addMappedColumnNameToErab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "ErabBooks",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "ErabBooks");
        }
    }
}
