using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MosshafContextHandeling.MainModels.Migrations
{
    /// <inheritdoc />
    public partial class addMultiMediaLecturerAndItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MultimediaLecturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Status = table.Column<short>(type: "smallint", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultimediaLecturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MultimediaItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Src = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfViews = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MultimediaLecturerId = table.Column<int>(type: "int", nullable: true),
                    MultimediaCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultimediaItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultimediaItems_MultimediaCategories_MultimediaCategoryId",
                        column: x => x.MultimediaCategoryId,
                        principalTable: "MultimediaCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultimediaItems_MultimediaLecturers_MultimediaLecturerId",
                        column: x => x.MultimediaLecturerId,
                        principalTable: "MultimediaLecturers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MultimediaItems_MultimediaCategoryId",
                table: "MultimediaItems",
                column: "MultimediaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MultimediaItems_MultimediaLecturerId",
                table: "MultimediaItems",
                column: "MultimediaLecturerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MultimediaItems");

            migrationBuilder.DropTable(
                name: "MultimediaLecturers");
        }
    }
}
