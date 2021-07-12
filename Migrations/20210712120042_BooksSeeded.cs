using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningCoding.Migrations
{
    public partial class BooksSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookUrlImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookDownloadUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "BookDownloadUrl", "BookTitle", "BookUrlImage" },
                values: new object[,]
                {
                    { 1, "https://za1lib.org/dl/5430455/eece3f", "Modern Full-Stack Development: Using TypeScript, React, Node.js, Webpack, and Docker", "https://covers.zlibcdn2.com/covers299/books/6e/45/e4/6e45e486274523acce569f1f08a3b473.jpg" },
                    { 2, "https://za1lib.org/dl/2475034/1cad05?dsource=recommend", "JavaScript and JQuery: Interactive Front-End Web Development", "https://covers.zlibcdn2.com/covers299/books/26/c3/03/26c303a8f1e8881a7a6bd59d57a76aef.jpg" },
                    { 3, "https://za1lib.org/dl/1304587/324ac0?dsource=recommend", "HTML and CSS: Design and Build Websites", "https://covers.zlibcdn2.com/covers/books/f2/f2/31/f2f231b39e648d7db773fe8c02e87132.jpg" },
                    { 4, "https://za1lib.org/dl/4999553/984dd2", "Essential Algorithms: A Practical Approach to Computer Algorithms Using Python and C#", "https://covers.zlibcdn2.com/covers/books/d3/8e/29/d38e29bd3aa485e5cdfda1a93699d64a.jpg" },
                    { 5, "https://za1lib.org/dl/3525636/0771cb?dsource=recommend", "Design Patterns in C#: A Hands-on Guide with Real-World Examples", "https://covers.zlibcdn2.com/covers/books/bc/16/59/bc165985d4176b3165e5e9e462298a23.jpg" },
                    { 6, "https://za1lib.org/dl/3498746/a20a2a", "The Road to learn React: Your journey to master plain yet pragmatic React.js", "https://covers.zlibcdn2.com/covers/books/1c/a8/0d/1ca80d2ca01ac4fe106c899900e9eecb.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
