using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class HandleErabTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ErabsNew_Ayas_AyaId",
                table: "ErabsNew");

            migrationBuilder.DropForeignKey(
                name: "FK_ErabsNew_ErabBooks_ErabBookId",
                table: "ErabsNew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ErabsNew",
                table: "ErabsNew");

            migrationBuilder.DropColumn(
                name: "MappedColumnName",
                table: "ErabBooks");

            migrationBuilder.RenameTable(
                name: "ErabsNew",
                newName: "Erabs");

            migrationBuilder.RenameColumn(
                name: "Book",
                table: "ErabBooks",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Book",
                table: "AsbabNozoolBooks",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_ErabsNew_ErabBookId",
                table: "Erabs",
                newName: "IX_Erabs_ErabBookId");

            migrationBuilder.RenameIndex(
                name: "IX_ErabsNew_AyaId",
                table: "Erabs",
                newName: "IX_Erabs_AyaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Erabs",
                table: "Erabs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Erabs_Ayas_AyaId",
                table: "Erabs",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Erabs_ErabBooks_ErabBookId",
                table: "Erabs",
                column: "ErabBookId",
                principalTable: "ErabBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Erabs_Ayas_AyaId",
                table: "Erabs");

            migrationBuilder.DropForeignKey(
                name: "FK_Erabs_ErabBooks_ErabBookId",
                table: "Erabs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Erabs",
                table: "Erabs");

            migrationBuilder.RenameTable(
                name: "Erabs",
                newName: "ErabsNew");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ErabBooks",
                newName: "Book");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AsbabNozoolBooks",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Erabs_ErabBookId",
                table: "ErabsNew",
                newName: "IX_ErabsNew_ErabBookId");

            migrationBuilder.RenameIndex(
                name: "IX_Erabs_AyaId",
                table: "ErabsNew",
                newName: "IX_ErabsNew_AyaId");

            migrationBuilder.AddColumn<string>(
                name: "MappedColumnName",
                table: "ErabBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ErabsNew",
                table: "ErabsNew",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ErabsNew_Ayas_AyaId",
                table: "ErabsNew",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ErabsNew_ErabBooks_ErabBookId",
                table: "ErabsNew",
                column: "ErabBookId",
                principalTable: "ErabBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
