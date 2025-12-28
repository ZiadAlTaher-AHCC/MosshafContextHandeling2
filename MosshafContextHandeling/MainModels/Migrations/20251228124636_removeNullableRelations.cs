using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class removeNullableRelations : Migration
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
                name: "FK_Tafsers_Ayas_AyaId",
                table: "Tafsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tafsers_TafseerBooks_TafseerBookId",
                table: "Tafsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TragemsNew_TragemBooks_TragemBookId",
                table: "TragemsNew");

            migrationBuilder.AlterColumn<int>(
                name: "TragemBookId",
                table: "TragemsNew",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TafseerBookId",
                table: "Tafsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AyaId",
                table: "Tafsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AsbabNozoolBookId",
                table: "AsbabNozoolsNew",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AyaId",
                table: "Ahhkams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AhkamBookId",
                table: "Ahhkams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_Tafsers_Ayas_AyaId",
                table: "Tafsers",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tafsers_TafseerBooks_TafseerBookId",
                table: "Tafsers",
                column: "TafseerBookId",
                principalTable: "TafseerBooks",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Tafsers_Ayas_AyaId",
                table: "Tafsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tafsers_TafseerBooks_TafseerBookId",
                table: "Tafsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TragemsNew_TragemBooks_TragemBookId",
                table: "TragemsNew");

            migrationBuilder.AlterColumn<int>(
                name: "TragemBookId",
                table: "TragemsNew",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TafseerBookId",
                table: "Tafsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AyaId",
                table: "Tafsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AsbabNozoolBookId",
                table: "AsbabNozoolsNew",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AyaId",
                table: "Ahhkams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AhkamBookId",
                table: "Ahhkams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Ahhkams_AhkamBooks_AhkamBookId",
                table: "Ahhkams",
                column: "AhkamBookId",
                principalTable: "AhkamBooks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ahhkams_Ayas_AyaId",
                table: "Ahhkams",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AsbabNozoolsNew_AsbabNozoolBooks_AsbabNozoolBookId",
                table: "AsbabNozoolsNew",
                column: "AsbabNozoolBookId",
                principalTable: "AsbabNozoolBooks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tafsers_Ayas_AyaId",
                table: "Tafsers",
                column: "AyaId",
                principalTable: "Ayas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tafsers_TafseerBooks_TafseerBookId",
                table: "Tafsers",
                column: "TafseerBookId",
                principalTable: "TafseerBooks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TragemsNew_TragemBooks_TragemBookId",
                table: "TragemsNew",
                column: "TragemBookId",
                principalTable: "TragemBooks",
                principalColumn: "Id");
        }
    }
}
