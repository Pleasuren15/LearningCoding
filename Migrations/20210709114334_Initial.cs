using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningCoding.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguage",
                columns: table => new
                {
                    ProgrammingLanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammingLanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageOverview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguagePros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageCons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguage", x => x.ProgrammingLanguageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgrammingLanguage");
        }
    }
}
