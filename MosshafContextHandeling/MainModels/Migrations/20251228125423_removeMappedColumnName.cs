using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class removeMappedColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "TragemBooks");

            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "TafseerBooks");

            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "OlomBooks");

            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "ErabBooks");

            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "EgazBooks");

            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "AsbabNozoolBooks");

            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "AhkamBooks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "TragemBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "TafseerBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "OlomBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "ErabBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "EgazBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "AsbabNozoolBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "AhkamBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
