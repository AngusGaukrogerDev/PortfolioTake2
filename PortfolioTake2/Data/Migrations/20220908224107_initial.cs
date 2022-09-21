using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioTake2.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flashcard",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpanishWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePromptLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoPromptLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardLevel = table.Column<int>(type: "int", nullable: false),
                    NumberOfReviews = table.Column<int>(type: "int", nullable: false),
                    LastReviewTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flashcard", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flashcard");
        }
    }
}
