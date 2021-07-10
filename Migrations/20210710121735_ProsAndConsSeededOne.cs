using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningCoding.Migrations
{
    public partial class ProsAndConsSeededOne : Migration
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
                    ProgrammingLanguageHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguage", x => x.ProgrammingLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguageCon",
                columns: table => new
                {
                    ProgrammingLanguageConsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammingLanguageConsDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguageCon", x => x.ProgrammingLanguageConsId);
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguageCon_ProgrammingLanguage_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguage",
                        principalColumn: "ProgrammingLanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguagePro",
                columns: table => new
                {
                    ProgrammingLanguageProsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammingLanguageProsDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguagePro", x => x.ProgrammingLanguageProsId);
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguagePro_ProgrammingLanguage_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguage",
                        principalColumn: "ProgrammingLanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguage",
                columns: new[] { "ProgrammingLanguageId", "ProgrammingLanguageCategory", "ProgrammingLanguageDescription", "ProgrammingLanguageHistory", "ProgrammingLanguageImageUrl", "ProgrammingLanguageName", "ProgrammingLanguageOverview" },
                values: new object[,]
                {
                    { 1, "High-level", "", "C# was developed by Microsoft within its .NET framework initiative and later approved as a standard by ECMA (ECMA-334) C# programming language is a general-purpose, OOPS based programming language. C# development team was lead by \"Anders Hejlsberg\" in 2002", "https://img.icons8.com/color/175/000000/c-sharp-logo.png", "C#", "C# (pronounced \"C - sharp\") is an object-oriented programming language from Microsoft that aims to combine the computing power of C++ with the programming ease of Visual Basic" },
                    { 2, "Low-level", "", "The first version of HTML was written by Tim Berners-Lee in 1993. Since then, there have been many different versions of HTML. The most widely used version throughout the 2000's was HTML 4.01, which became an official standard in December 1999. Another version, XHTML, was a rewrite of HTML as an XML language", "https://img.icons8.com/color/175/000000/html-5--v1.png", "HTML", "HTML stands for Hypertext Markup Language, and it is the most widely used language to write Web Pages. As its name suggests, HTML is a Markup Language which means you use HTML to simply \"mark - up\" a text document with tags that tell a Web browser how to structure it to display" },
                    { 3, "High-level", "", "Python was conceived in the late 1980s by Guido van Rossum at Centrum Wiskunde & Informatica (CWI) in the Netherlands as a successor to ABC programming language, which was inspired by SETL, capable of exception handling and interfacing with the Amoeba operating system. Its implementation began in December 1989", "https://img.icons8.com/color/175/000000/python--v1.png", "Python", "Python is a high-level, interpreted, interactive and object-oriented scripting language. Python is designed to be highly readable. It uses English keywords frequently where as other languages use punctuation, and it has fewer syntactical constructions than other languages." },
                    { 4, "High-level", "", "Java was originally developed by James Gosling at Sun Microsystems (which has since been acquired by Oracle) and released in 1995 as a core component of Sun Microsystems' Java platform", "https://img.icons8.com/color/175/000000/java-coffee-cup-logo--v1.png", "Java", "Java is a simple, general-purpose, object-oriented, interpreted, robust, secure, architecture-neutral, portable, high-performance, multithreaded computer language. ... Java technology is both a programming language and a platform. Java is a high level, robust, secured and object-oriented programming language" },
                    { 5, "High-level", "", "Before the initial standardization in 1998, C++ was developed by Danish computer scientist Bjarne Stroustrup at Bell Labs since 1979 as an extension of the C language; he wanted an efficient and flexible language similar to C that also provided high-level features for program organization", "https://img.icons8.com/color/175/000000/c-plus-plus-logo.png", "C++", "C++ is a statically typed, compiled, general-purpose, case-sensitive, free-form programming language that supports procedural, object-oriented, and generic programming. C++ is regarded as a middle-level language, as it comprises a combination of both high-level and low-level language features" },
                    { 6, "High-level", "", "In September 1995, a Netscape programmer named Brandan Eich developed a new scripting language in just 10 days. It was originally named Mocha, but quickly became known as LiveScript and, later, JavaScript.", "https://img.icons8.com/color/175/000000/javascript--v1.png", "JavaScript", "JavaScript is a dynamic computer programming language. It is lightweight and most commonly used as a part of web pages, whose implementations allow client-side script to interact with the user and make dynamic pages. It is an interpreted programming language with object-oriented capabilities." },
                    { 7, "High-level", "", "React was created by Jordan Walke, a software engineer at Facebook, who released an early prototype of React called \"FaxJS\". He was influenced by XHP, an HTML component library for PHP. It was first deployed on Facebook's News Feed in 2011 and later on Instagram in 2012. It was open-sourced at JSConf US in May 2013.", "https://img.icons8.com/color/175/000000/react-native.png", "React", "React is a library for building composable user interfaces. It encourages the creation of reusable UI components, which present data that changes over time. ... React can also render on the server using Node, and it can power native apps using React Native." },
                    { 8, "High-level", "", "AngularJS was originally developed in 2009 by Miško Hevery at Brat Tech LLC as the software behind an online JSON storage service, that would have been priced by the megabyte, for easy-to-make applications for the enterprise.", "https://img.icons8.com/color/175/000000/angularjs.png", "Angular", "Angular is a platform and framework for building single-page client applications using HTML and TypeScript. Angular is written in TypeScript. It implements core and optional functionality as a set of TypeScript libraries that you import into your applications." },
                    { 9, "Low-level", "", "PHP was conceived sometime in the fall of 1994 by Rasmus Lerdorf. Early non-released versions were used on his home page to keep track of who was looking at his online resume. The first version used by others was available sometime in early 1995 and was known as the Personal Home Page Tools.", "https://img.icons8.com/offices/175/000000/php-logo.png", "PHP", "PHP is an intuitive, server side scripting language. Like any other scripting language it allows developers to build logic into the creation of web page content and handle data returned from a web browser. PHP also contains a number of extensions that make it easy to interact with databases, extracting data to be displayed on a web page and storing information entered by a web site visitor back into the database." },
                    { 10, "High-level", "", "Development of Swift started in July 2010 by Chris Lattner, with the eventual collaboration of many other programmers at Apple.Swift took language ideas \"from Objective-C, Rust, Haskell, Ruby, Python, C#, CLU, and far too many others to list\"", "https://img.icons8.com/color/175/000000/swift.png", "Swift", "Swift is a powerful and intuitive programming language for iOS, iPadOS, macOS, tvOS, and watchOS. Writing Swift code is interactive and fun, the syntax is concise yet expressive, and Swift includes modern features developers love. Swift code is safe by design, yet also produces software that runs lightning-fast." }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguageCon",
                columns: new[] { "ProgrammingLanguageConsId", "ProgrammingLanguageConsDesc", "ProgrammingLanguageId" },
                values: new object[,]
                {
                    { 6, "Poor x-platform GUI.", 1 },
                    { 7, "C# is an internal part of the . NET framework so the server running the application must be windows based.", 1 },
                    { 8, "C# is less flexible as it mostly depends on the . Net framework.", 1 },
                    { 27, "As we know Python is a dynamically typed language so the data type of a variable can change anytime. A variable containing integer number may hold a string in the future, which can lead to Runtime Errors.", 3 },
                    { 26, "Programming in Python is easy and stress-free. But when we are interacting with the database, it lacks behind.", 3 },
                    { 14, "It cannot produce dynamic output alone, since it’s a static language.", 2 },
                    { 15, "Making of structure of HTML documents becomes tough to understood.", 2 },
                    { 16, "It is the time consuming as the time it consume to maintain on the colour scheme of a page and to make lists, tables and forms.", 2 },
                    { 17, "It can create only static and plain pages so if we’d like dynamic pages then HTML isn’t useful.", 2 },
                    { 18, "Required to write a lot of code for just creating simple webpage.", 2 },
                    { 25, "To provide simplicity to the developer, Python has to do a little tradeoff. The Python programming language uses a large amount of memory. This can be a disadvantage while building applications when we prefer memory optimization.", 3 },
                    { 24, "We discussed above that Python is an interpreted language and dynamically-typed language. The line by line execution of code often leads to slow execution.", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguagePro",
                columns: new[] { "ProgrammingLanguageProsId", "ProgrammingLanguageId", "ProgrammingLanguageProsDesc" },
                values: new object[,]
                {
                    { 21, 3, "Interpreted Language" },
                    { 20, 3, "Python is a very productive language. Due to the simplicity of Python, developers can focus on solving the problem. They don’t need to spend too much time in understanding the syntax or behavior of the programming language. You write less code and get more things done." },
                    { 19, 3, "Python is a high-level programming language that has English-like syntax. This makes it easier to read and understand the code" },
                    { 13, 2, "HTML is easy enough to write." },
                    { 9, 2, "Do not got to purchase any extra software because it’s by default in every window." },
                    { 11, 2, "HTML can be supported to each and every browser, if not supported to all the browers." },
                    { 10, 2, "HTML also allows the utilization of templates, which makes designing a webpage easy." },
                    { 22, 3, "The standard library of Python is huge, you can find almost all the functions needed for your task. So, you don’t have to depend on external libraries." },
                    { 5, 1, "Better Integrity and Interoperability" },
                    { 4, 1, "Backward Compatibility" },
                    { 3, 1, "Cross Platform" },
                    { 2, 1, "Automatic Garbage Collection." },
                    { 1, 1, "Object-Oriented Language." },
                    { 12, 2, "HTML is present in every window by default so you not need to buy the software which cost too much." },
                    { 23, 3, "In many languages like C/C++, you need to change your code to run the program on different platforms. That is not the same with Python. You only write once and run it anywhere." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguageCon_ProgrammingLanguageId",
                table: "ProgrammingLanguageCon",
                column: "ProgrammingLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguagePro_ProgrammingLanguageId",
                table: "ProgrammingLanguagePro",
                column: "ProgrammingLanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgrammingLanguageCon");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguagePro");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguage");
        }
    }
}
