using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fillinger.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emberek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nem = table.Column<int>(type: "int", nullable: false),
                    SzuletesiDatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emberek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kapcsolatok",
                columns: table => new
                {
                    EmberId = table.Column<int>(type: "int", nullable: false),
                    ApjaId = table.Column<int>(type: "int", nullable: true),
                    AnyjaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Kapcsolatok_Emberek_AnyjaId",
                        column: x => x.AnyjaId,
                        principalTable: "Emberek",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kapcsolatok_Emberek_ApjaId",
                        column: x => x.ApjaId,
                        principalTable: "Emberek",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kapcsolatok_Emberek_EmberId",
                        column: x => x.EmberId,
                        principalTable: "Emberek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kapcsolatok_AnyjaId",
                table: "Kapcsolatok",
                column: "AnyjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kapcsolatok_ApjaId",
                table: "Kapcsolatok",
                column: "ApjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kapcsolatok_EmberId",
                table: "Kapcsolatok",
                column: "EmberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kapcsolatok");

            migrationBuilder.DropTable(
                name: "Emberek");
        }
    }
}
