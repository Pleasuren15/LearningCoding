using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningCoding.Migrations
{
    public partial class FeedbackModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackName = table.Column<int>(type: "int", nullable: false),
                    FeedbackEmail = table.Column<int>(type: "int", nullable: false),
                    FeedbackSubject = table.Column<int>(type: "int", nullable: false),
                    FeedbackMessage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");
        }
    }
}
