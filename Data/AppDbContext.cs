using LearningCoding.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LearningCoding.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<ProgrammingLanguageCons> ProgrammingLanguageCons { get; set; }
        public DbSet<ProgrammingLanguagePros> ProgrammingLanguagesPros { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgrammingLanguageCons>().ToTable("ProgrammingLanguageCon");
            modelBuilder.Entity<ProgrammingLanguage>().ToTable("ProgrammingLanguage");
            modelBuilder.Entity<ProgrammingLanguagePros>().ToTable("ProgrammingLanguagePro");
            modelBuilder.Entity<Feedback>().ToTable("Feedback");
            modelBuilder.Entity<Book>().ToTable("Book");

            modelBuilder.Entity<ProgrammingLanguage>().HasData(
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageName = "C#",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "C# (pronounced \"C - sharp\") is an object-oriented programming language from Microsoft that aims to combine the computing power of C++ with the programming ease of Visual Basic",
                    ProgrammingLanguageTutorials = "https://www.tutorialsteacher.com/csharp/csharp-tutorials",
                    ProgrammingLanguageHistory = "C# was developed by Microsoft within its .NET framework initiative and later approved as a standard by ECMA (ECMA-334) C# programming language is a general-purpose, OOPS based programming language. C# development team was lead by \"Anders Hejlsberg\" in 2002",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/c-sharp-logo.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageName = "HTML",
                    ProgrammingLanguageCategory = "Low-level",
                    ProgrammingLanguageOverview = "HTML stands for Hypertext Markup Language, and it is the most widely used language to write Web Pages. As its name suggests, HTML is a Markup Language which means you use HTML to simply \"mark - up\" a text document with tags that tell a Web browser how to structure it to display",
                    ProgrammingLanguageTutorials = "https://html.com/",
                    ProgrammingLanguageHistory = "The first version of HTML was written by Tim Berners-Lee in 1993. Since then, there have been many different versions of HTML. The most widely used version throughout the 2000's was HTML 4.01, which became an official standard in December 1999. Another version, XHTML, was a rewrite of HTML as an XML language",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/html-5--v1.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageName = "Python",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "Python is a high-level, interpreted, interactive and object-oriented scripting language. Python is designed to be highly readable. It uses English keywords frequently where as other languages use punctuation, and it has fewer syntactical constructions than other languages.",
                    ProgrammingLanguageTutorials = "https://docs.python.org/3/tutorial/",
                    ProgrammingLanguageHistory = "Python was conceived in the late 1980s by Guido van Rossum at Centrum Wiskunde & Informatica (CWI) in the Netherlands as a successor to ABC programming language, which was inspired by SETL, capable of exception handling and interfacing with the Amoeba operating system. Its implementation began in December 1989",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/python--v1.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 4,
                    ProgrammingLanguageName = "Java",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "Java is a simple, general-purpose, object-oriented, interpreted, robust, secure, architecture-neutral, portable, high-performance, multithreaded computer language. ... Java technology is both a programming language and a platform. Java is a high level, robust, secured and object-oriented programming language",
                    ProgrammingLanguageTutorials = "https://www.tutorialspoint.com/java/index.htm",
                    ProgrammingLanguageHistory = "Java was originally developed by James Gosling at Sun Microsystems (which has since been acquired by Oracle) and released in 1995 as a core component of Sun Microsystems' Java platform",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/java-coffee-cup-logo--v1.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 5,
                    ProgrammingLanguageName = "C++",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "C++ is a statically typed, compiled, general-purpose, case-sensitive, free-form programming language that supports procedural, object-oriented, and generic programming. C++ is regarded as a middle-level language, as it comprises a combination of both high-level and low-level language features",
                    ProgrammingLanguageTutorials = "https://www.w3schools.com/CPP/default.asp",
                    ProgrammingLanguageHistory = "Before the initial standardization in 1998, C++ was developed by Danish computer scientist Bjarne Stroustrup at Bell Labs since 1979 as an extension of the C language; he wanted an efficient and flexible language similar to C that also provided high-level features for program organization",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/c-plus-plus-logo.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 6,
                    ProgrammingLanguageName = "JavaScript",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "JavaScript is a dynamic computer programming language. It is lightweight and most commonly used as a part of web pages, whose implementations allow client-side script to interact with the user and make dynamic pages. It is an interpreted programming language with object-oriented capabilities.",
                    ProgrammingLanguageTutorials = "https://www.w3schools.com/js/",
                    ProgrammingLanguageHistory = "In September 1995, a Netscape programmer named Brandan Eich developed a new scripting language in just 10 days. It was originally named Mocha, but quickly became known as LiveScript and, later, JavaScript.",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/javascript--v1.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 7,
                    ProgrammingLanguageName = "React",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "React is a library for building composable user interfaces. It encourages the creation of reusable UI components, which present data that changes over time. ... React can also render on the server using Node, and it can power native apps using React Native.",
                    ProgrammingLanguageTutorials = "https://reactjs.org/tutorial/tutorial.html",
                    ProgrammingLanguageHistory = "React was created by Jordan Walke, a software engineer at Facebook, who released an early prototype of React called \"FaxJS\". He was influenced by XHP, an HTML component library for PHP. It was first deployed on Facebook's News Feed in 2011 and later on Instagram in 2012. It was open-sourced at JSConf US in May 2013.",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/react-native.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 8,
                    ProgrammingLanguageName = "Angular",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "Angular is a platform and framework for building single-page client applications using HTML and TypeScript. Angular is written in TypeScript. It implements core and optional functionality as a set of TypeScript libraries that you import into your applications.",
                    ProgrammingLanguageTutorials = "https://www.tektutorialshub.com/angular-tutorial/",
                    ProgrammingLanguageHistory = "AngularJS was originally developed in 2009 by Miško Hevery at Brat Tech LLC as the software behind an online JSON storage service, that would have been priced by the megabyte, for easy-to-make applications for the enterprise.",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/angularjs.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 9,
                    ProgrammingLanguageName = "PHP",
                    ProgrammingLanguageCategory = "Low-level",
                    ProgrammingLanguageOverview = "PHP is an intuitive, server side scripting language. Like any other scripting language it allows developers to build logic into the creation of web page content and handle data returned from a web browser. PHP also contains a number of extensions that make it easy to interact with databases, extracting data to be displayed on a web page and storing information entered by a web site visitor back into the database.",
                    ProgrammingLanguageTutorials = "https://www.w3schools.com/php/DEFAULT.asp",
                    ProgrammingLanguageHistory = "PHP was conceived sometime in the fall of 1994 by Rasmus Lerdorf. Early non-released versions were used on his home page to keep track of who was looking at his online resume. The first version used by others was available sometime in early 1995 and was known as the Personal Home Page Tools.",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/offices/175/000000/php-logo.png"
                },
                new ProgrammingLanguage()
                {
                    ProgrammingLanguageId = 10,
                    ProgrammingLanguageName = "Swift",
                    ProgrammingLanguageCategory = "High-level",
                    ProgrammingLanguageOverview = "Swift is a powerful and intuitive programming language for iOS, iPadOS, macOS, tvOS, and watchOS. Writing Swift code is interactive and fun, the syntax is concise yet expressive, and Swift includes modern features developers love. Swift code is safe by design, yet also produces software that runs lightning-fast.",
                    ProgrammingLanguageTutorials = "https://www.tutorialspoint.com/swift/index.htm",
                    ProgrammingLanguageHistory = "Development of Swift started in July 2010 by Chris Lattner, with the eventual collaboration of many other programmers at Apple.Swift took language ideas \"from Objective-C, Rust, Haskell, Ruby, Python, C#, CLU, and far too many others to list\"",
                    ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/swift.png"
                }
                );


            #region C# Pros&Cons
            modelBuilder.Entity<ProgrammingLanguagePros>().HasData(
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 1,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageProsDesc = "Object-Oriented Language."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 2,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageProsDesc = "Automatic Garbage Collection."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 3,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageProsDesc = "Cross Platform"
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 4,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageProsDesc = "Backward Compatibility"
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 5,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageProsDesc = "Better Integrity and Interoperability"
                });

            modelBuilder.Entity<ProgrammingLanguageCons>().HasData(
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 6,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageConsDesc = "Poor x-platform GUI."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 7,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageConsDesc = "C# is an internal part of the . NET framework so the server running the application must be windows based."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 8,
                    ProgrammingLanguageId = 1,
                    ProgrammingLanguageConsDesc = "C# is less flexible as it mostly depends on the . Net framework."
                });
            #endregion

            #region HTML Pros&Cons
            modelBuilder.Entity<ProgrammingLanguagePros>().HasData(
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 9,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageProsDesc = "Do not got to purchase any extra software because it’s by default in every window."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 10,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageProsDesc = "HTML also allows the utilization of templates, which makes designing a webpage easy."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 11,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageProsDesc = "HTML can be supported to each and every browser, if not supported to all the browers."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 12,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageProsDesc = "HTML is present in every window by default so you not need to buy the software which cost too much."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 13,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageProsDesc = "HTML is easy enough to write."
                });

            modelBuilder.Entity<ProgrammingLanguageCons>().HasData(
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 14,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageConsDesc = "It cannot produce dynamic output alone, since it’s a static language."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 15,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageConsDesc = "Making of structure of HTML documents becomes tough to understood."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 16,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageConsDesc = "It is the time consuming as the time it consume to maintain on the colour scheme of a page and to make lists, tables and forms."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 17,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageConsDesc = "It can create only static and plain pages so if we’d like dynamic pages then HTML isn’t useful."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 18,
                    ProgrammingLanguageId = 2,
                    ProgrammingLanguageConsDesc = "Required to write a lot of code for just creating simple webpage."
                });
            #endregion

            #region Python Pros&Cons
            modelBuilder.Entity<ProgrammingLanguagePros>().HasData(
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 19,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageProsDesc = "Python is a high-level programming language that has English-like syntax. This makes it easier to read and understand the code"
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 20,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageProsDesc = "Python is a very productive language. Due to the simplicity of Python, developers can focus on solving the problem. They don’t need to spend too much time in understanding the syntax or behavior of the programming language. You write less code and get more things done."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 21,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageProsDesc = "Interpreted Language"
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 22,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageProsDesc = "The standard library of Python is huge, you can find almost all the functions needed for your task. So, you don’t have to depend on external libraries."
                },
                new ProgrammingLanguagePros()
                {
                    ProgrammingLanguageProsId = 23,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageProsDesc = "In many languages like C/C++, you need to change your code to run the program on different platforms. That is not the same with Python. You only write once and run it anywhere."
                });

            modelBuilder.Entity<ProgrammingLanguageCons>().HasData(
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 24,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageConsDesc = "We discussed above that Python is an interpreted language and dynamically-typed language. The line by line execution of code often leads to slow execution."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 25,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageConsDesc = "To provide simplicity to the developer, Python has to do a little tradeoff. The Python programming language uses a large amount of memory. This can be a disadvantage while building applications when we prefer memory optimization."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 26,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageConsDesc = "Programming in Python is easy and stress-free. But when we are interacting with the database, it lacks behind."
                },
                new ProgrammingLanguageCons()
                {
                    ProgrammingLanguageConsId = 27,
                    ProgrammingLanguageId = 3,
                    ProgrammingLanguageConsDesc = "As we know Python is a dynamically typed language so the data type of a variable can change anytime. A variable containing integer number may hold a string in the future, which can lead to Runtime Errors."
                });
            #endregion

            #region Books
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    BookId = 1,
                    BookTitle = "Modern Full-Stack Development: Using TypeScript, React, Node.js, Webpack, and Docker",
                    BookUrlImage = "https://covers.zlibcdn2.com/covers299/books/6e/45/e4/6e45e486274523acce569f1f08a3b473.jpg",
                    BookDownloadUrl = "https://za1lib.org/dl/5430455/eece3f"
                },
                new Book()
                {
                    BookId = 2,
                    BookTitle = "JavaScript and JQuery: Interactive Front-End Web Development",
                    BookUrlImage = "https://covers.zlibcdn2.com/covers299/books/26/c3/03/26c303a8f1e8881a7a6bd59d57a76aef.jpg",
                    BookDownloadUrl = "https://za1lib.org/dl/2475034/1cad05?dsource=recommend"
                },
                new Book()
                {
                    BookId = 3,
                    BookTitle = "HTML and CSS: Design and Build Websites",
                    BookUrlImage = "https://covers.zlibcdn2.com/covers/books/f2/f2/31/f2f231b39e648d7db773fe8c02e87132.jpg",
                    BookDownloadUrl = "https://za1lib.org/dl/1304587/324ac0?dsource=recommend"
                },
                new Book()
                {
                    BookId = 4,
                    BookTitle = "Essential Algorithms: A Practical Approach to Computer Algorithms Using Python and C#",
                    BookUrlImage = "https://covers.zlibcdn2.com/covers/books/d3/8e/29/d38e29bd3aa485e5cdfda1a93699d64a.jpg",
                    BookDownloadUrl = "https://za1lib.org/dl/4999553/984dd2"
                },
                new Book()
                {
                    BookId = 5,
                    BookTitle = "Design Patterns in C#: A Hands-on Guide with Real-World Examples",
                    BookUrlImage = "https://covers.zlibcdn2.com/covers/books/bc/16/59/bc165985d4176b3165e5e9e462298a23.jpg",
                    BookDownloadUrl = "https://za1lib.org/dl/3525636/0771cb?dsource=recommend"
                },
                new Book() {
                    BookId = 6,
                    BookTitle = "The Road to learn React: Your journey to master plain yet pragmatic React.js",
                    BookUrlImage = "https://covers.zlibcdn2.com/covers/books/1c/a8/0d/1ca80d2ca01ac4fe106c899900e9eecb.jpg",
                    BookDownloadUrl = "https://za1lib.org/dl/3498746/a20a2a"
                });
            #endregion
        }
    }
}
