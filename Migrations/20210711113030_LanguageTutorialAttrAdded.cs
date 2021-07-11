using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningCoding.Migrations
{
    public partial class LanguageTutorialAttrAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgrammingLanguageDescription",
                table: "ProgrammingLanguage",
                newName: "ProgrammingLanguageTutorials");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 1,
                column: "ProgrammingLanguageTutorials",
                value: "https://www.tutorialsteacher.com/csharp/csharp-tutorials");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 2,
                column: "ProgrammingLanguageTutorials",
                value: "https://html.com/");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 3,
                column: "ProgrammingLanguageTutorials",
                value: "https://docs.python.org/3/tutorial/");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 4,
                column: "ProgrammingLanguageTutorials",
                value: "https://www.tutorialspoint.com/java/index.htm");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 5,
                column: "ProgrammingLanguageTutorials",
                value: "https://www.w3schools.com/CPP/default.asp");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 6,
                column: "ProgrammingLanguageTutorials",
                value: "https://www.w3schools.com/js/");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 7,
                column: "ProgrammingLanguageTutorials",
                value: "https://reactjs.org/tutorial/tutorial.html");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 8,
                column: "ProgrammingLanguageTutorials",
                value: "https://www.tektutorialshub.com/angular-tutorial/");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 9,
                column: "ProgrammingLanguageTutorials",
                value: "https://www.w3schools.com/php/DEFAULT.asp");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 10,
                column: "ProgrammingLanguageTutorials",
                value: "https://www.tutorialspoint.com/swift/index.htm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgrammingLanguageTutorials",
                table: "ProgrammingLanguage",
                newName: "ProgrammingLanguageDescription");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 1,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 2,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 3,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 4,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 5,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 6,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 7,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 8,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 9,
                column: "ProgrammingLanguageDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguage",
                keyColumn: "ProgrammingLanguageId",
                keyValue: 10,
                column: "ProgrammingLanguageDescription",
                value: "");
        }
    }
}
