using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class renameNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ahhkams_AhkamBooks_AhkamBookId",
                table: "Ahhkams");

            migrationBuilder.DropForeignKey(
                name: "FK_Ahhkams_Ayas_AyaId",
                table: "Ahhkams");

            migrationBuilder.DropForeignKey(
                name: "FK_AsbabNozoolsNew_AsbabNozoolBooks_AsbabNozoolBookId",
                table: "AsbabNozoolsNew");

            migrationBuilder.DropForeignKey(
                name: "FK_AsbabNozoolsNew_Ayas_AyaId",
                table: "AsbabNozoolsNew");

            migrationBuilder.DropForeignKey(
                name: "FK_TragemsNew_Ayas_AyaId",
                table: "TragemsNew");

            migrationBuilder.DropForeignKey(
                name: "FK_TragemsNew_TragemBooks_TragemBookId",
                table: "TragemsNew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TragemsNew",
                table: "TragemsNew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AsbabNozoolsNew",
                table: "AsbabNozoolsNew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ahhkams",
                table: "Ahhkams");

            migrationBuilder.RenameTable(
                name: "TragemsNew",
                newName: "Tragems");

            migrationBuilder.RenameTable(
                name: "AsbabNozoolsNew",
                newName: "AsbabNozools");

            migrationBuilder.RenameTable(
                name: "Ahhkams",
                newName: "Ahkams");

            migrationBuilder.RenameIndex(
                name: "IX_TragemsNew_TragemBookId",
                table: "Tragems",
                newName: "IX_Tragems_TragemBookId");

            migrationBuilder.RenameIndex(
                name: "IX_TragemsNew_AyaId",
                table: "Tragems",
                newName: "IX_Tragems_AyaId");

            migrationBuilder.RenameIndex(
                name: "IX_AsbabNozoolsNew_AyaId",
                table: "AsbabNozools",
                newName: "IX_AsbabNozools_AyaId");

            migrationBuilder.RenameIndex(
                name: "IX_AsbabNozoolsNew_AsbabNozoolBookId",
                table: "AsbabNozools",
                newName: "IX_AsbabNozools_AsbabNozoolBookId");

            migrationBuilder.RenameIndex(
                name: "IX_Ahhkams_AyaId",
                table: "Ahkams",
                newName: "IX_Ahkams_AyaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ahhkams_AhkamBookId",
                table: "Ahkams",
                newName: "IX_Ahkams_AhkamBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tragems",
                table: "Tragems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AsbabNozools",
                table: "AsbabNozools",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ahkams",
                table: "Ahkams",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ahkams_AhkamBooks_AhkamBookId",
                table: "Ahkams",
                column: "AhkamBookId",
                principalTable: "AhkamBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ahkams_Ayas_AyaId",
                table: "Ahkams",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsbabNozools_AsbabNozoolBooks_AsbabNozoolBookId",
                table: "AsbabNozools",
                column: "AsbabNozoolBookId",
                principalTable: "AsbabNozoolBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsbabNozools_Ayas_AyaId",
                table: "AsbabNozools",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tragems_Ayas_AyaId",
                table: "Tragems",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tragems_TragemBooks_TragemBookId",
                table: "Tragems",
                column: "TragemBookId",
                principalTable: "TragemBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ahkams_AhkamBooks_AhkamBookId",
                table: "Ahkams");

            migrationBuilder.DropForeignKey(
                name: "FK_Ahkams_Ayas_AyaId",
                table: "Ahkams");

            migrationBuilder.DropForeignKey(
                name: "FK_AsbabNozools_AsbabNozoolBooks_AsbabNozoolBookId",
                table: "AsbabNozools");

            migrationBuilder.DropForeignKey(
                name: "FK_AsbabNozools_Ayas_AyaId",
                table: "AsbabNozools");

            migrationBuilder.DropForeignKey(
                name: "FK_Tragems_Ayas_AyaId",
                table: "Tragems");

            migrationBuilder.DropForeignKey(
                name: "FK_Tragems_TragemBooks_TragemBookId",
                table: "Tragems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tragems",
                table: "Tragems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AsbabNozools",
                table: "AsbabNozools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ahkams",
                table: "Ahkams");

            migrationBuilder.RenameTable(
                name: "Tragems",
                newName: "TragemsNew");

            migrationBuilder.RenameTable(
                name: "AsbabNozools",
                newName: "AsbabNozoolsNew");

            migrationBuilder.RenameTable(
                name: "Ahkams",
                newName: "Ahhkams");

            migrationBuilder.RenameIndex(
                name: "IX_Tragems_TragemBookId",
                table: "TragemsNew",
                newName: "IX_TragemsNew_TragemBookId");

            migrationBuilder.RenameIndex(
                name: "IX_Tragems_AyaId",
                table: "TragemsNew",
                newName: "IX_TragemsNew_AyaId");

            migrationBuilder.RenameIndex(
                name: "IX_AsbabNozools_AyaId",
                table: "AsbabNozoolsNew",
                newName: "IX_AsbabNozoolsNew_AyaId");

            migrationBuilder.RenameIndex(
                name: "IX_AsbabNozools_AsbabNozoolBookId",
                table: "AsbabNozoolsNew",
                newName: "IX_AsbabNozoolsNew_AsbabNozoolBookId");

            migrationBuilder.RenameIndex(
                name: "IX_Ahkams_AyaId",
                table: "Ahhkams",
                newName: "IX_Ahhkams_AyaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ahkams_AhkamBookId",
                table: "Ahhkams",
                newName: "IX_Ahhkams_AhkamBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TragemsNew",
                table: "TragemsNew",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AsbabNozoolsNew",
                table: "AsbabNozoolsNew",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ahhkams",
                table: "Ahhkams",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ahhkams_AhkamBooks_AhkamBookId",
                table: "Ahhkams",
                column: "AhkamBookId",
                principalTable: "AhkamBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ahhkams_Ayas_AyaId",
                table: "Ahhkams",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsbabNozoolsNew_AsbabNozoolBooks_AsbabNozoolBookId",
                table: "AsbabNozoolsNew",
                column: "AsbabNozoolBookId",
                principalTable: "AsbabNozoolBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsbabNozoolsNew_Ayas_AyaId",
                table: "AsbabNozoolsNew",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TragemsNew_Ayas_AyaId",
                table: "TragemsNew",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TragemsNew_TragemBooks_TragemBookId",
                table: "TragemsNew",
                column: "TragemBookId",
                principalTable: "TragemBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
