﻿// <auto-generated />
using LearningCoding.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearningCoding.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210711135117_FeedbackModelAdded")]
    partial class FeedbackModelAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LearningCoding.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeedbackEmail")
                        .HasColumnType("int");

                    b.Property<int>("FeedbackMessage")
                        .HasColumnType("int");

                    b.Property<int>("FeedbackName")
                        .HasColumnType("int");

                    b.Property<int>("FeedbackSubject")
                        .HasColumnType("int");

                    b.HasKey("FeedbackId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("LearningCoding.Models.ProgrammingLanguage", b =>
                {
                    b.Property<int>("ProgrammingLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProgrammingLanguageCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingLanguageHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingLanguageImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingLanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingLanguageOverview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingLanguageTutorials")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgrammingLanguageId");

                    b.ToTable("ProgrammingLanguage");

                    b.HasData(
                        new
                        {
                            ProgrammingLanguageId = 1,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "C# was developed by Microsoft within its .NET framework initiative and later approved as a standard by ECMA (ECMA-334) C# programming language is a general-purpose, OOPS based programming language. C# development team was lead by \"Anders Hejlsberg\" in 2002",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/c-sharp-logo.png",
                            ProgrammingLanguageName = "C#",
                            ProgrammingLanguageOverview = "C# (pronounced \"C - sharp\") is an object-oriented programming language from Microsoft that aims to combine the computing power of C++ with the programming ease of Visual Basic",
                            ProgrammingLanguageTutorials = "https://www.tutorialsteacher.com/csharp/csharp-tutorials"
                        },
                        new
                        {
                            ProgrammingLanguageId = 2,
                            ProgrammingLanguageCategory = "Low-level",
                            ProgrammingLanguageHistory = "The first version of HTML was written by Tim Berners-Lee in 1993. Since then, there have been many different versions of HTML. The most widely used version throughout the 2000's was HTML 4.01, which became an official standard in December 1999. Another version, XHTML, was a rewrite of HTML as an XML language",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/html-5--v1.png",
                            ProgrammingLanguageName = "HTML",
                            ProgrammingLanguageOverview = "HTML stands for Hypertext Markup Language, and it is the most widely used language to write Web Pages. As its name suggests, HTML is a Markup Language which means you use HTML to simply \"mark - up\" a text document with tags that tell a Web browser how to structure it to display",
                            ProgrammingLanguageTutorials = "https://html.com/"
                        },
                        new
                        {
                            ProgrammingLanguageId = 3,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "Python was conceived in the late 1980s by Guido van Rossum at Centrum Wiskunde & Informatica (CWI) in the Netherlands as a successor to ABC programming language, which was inspired by SETL, capable of exception handling and interfacing with the Amoeba operating system. Its implementation began in December 1989",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/python--v1.png",
                            ProgrammingLanguageName = "Python",
                            ProgrammingLanguageOverview = "Python is a high-level, interpreted, interactive and object-oriented scripting language. Python is designed to be highly readable. It uses English keywords frequently where as other languages use punctuation, and it has fewer syntactical constructions than other languages.",
                            ProgrammingLanguageTutorials = "https://docs.python.org/3/tutorial/"
                        },
                        new
                        {
                            ProgrammingLanguageId = 4,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "Java was originally developed by James Gosling at Sun Microsystems (which has since been acquired by Oracle) and released in 1995 as a core component of Sun Microsystems' Java platform",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/java-coffee-cup-logo--v1.png",
                            ProgrammingLanguageName = "Java",
                            ProgrammingLanguageOverview = "Java is a simple, general-purpose, object-oriented, interpreted, robust, secure, architecture-neutral, portable, high-performance, multithreaded computer language. ... Java technology is both a programming language and a platform. Java is a high level, robust, secured and object-oriented programming language",
                            ProgrammingLanguageTutorials = "https://www.tutorialspoint.com/java/index.htm"
                        },
                        new
                        {
                            ProgrammingLanguageId = 5,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "Before the initial standardization in 1998, C++ was developed by Danish computer scientist Bjarne Stroustrup at Bell Labs since 1979 as an extension of the C language; he wanted an efficient and flexible language similar to C that also provided high-level features for program organization",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/c-plus-plus-logo.png",
                            ProgrammingLanguageName = "C++",
                            ProgrammingLanguageOverview = "C++ is a statically typed, compiled, general-purpose, case-sensitive, free-form programming language that supports procedural, object-oriented, and generic programming. C++ is regarded as a middle-level language, as it comprises a combination of both high-level and low-level language features",
                            ProgrammingLanguageTutorials = "https://www.w3schools.com/CPP/default.asp"
                        },
                        new
                        {
                            ProgrammingLanguageId = 6,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "In September 1995, a Netscape programmer named Brandan Eich developed a new scripting language in just 10 days. It was originally named Mocha, but quickly became known as LiveScript and, later, JavaScript.",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/javascript--v1.png",
                            ProgrammingLanguageName = "JavaScript",
                            ProgrammingLanguageOverview = "JavaScript is a dynamic computer programming language. It is lightweight and most commonly used as a part of web pages, whose implementations allow client-side script to interact with the user and make dynamic pages. It is an interpreted programming language with object-oriented capabilities.",
                            ProgrammingLanguageTutorials = "https://www.w3schools.com/js/"
                        },
                        new
                        {
                            ProgrammingLanguageId = 7,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "React was created by Jordan Walke, a software engineer at Facebook, who released an early prototype of React called \"FaxJS\". He was influenced by XHP, an HTML component library for PHP. It was first deployed on Facebook's News Feed in 2011 and later on Instagram in 2012. It was open-sourced at JSConf US in May 2013.",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/react-native.png",
                            ProgrammingLanguageName = "React",
                            ProgrammingLanguageOverview = "React is a library for building composable user interfaces. It encourages the creation of reusable UI components, which present data that changes over time. ... React can also render on the server using Node, and it can power native apps using React Native.",
                            ProgrammingLanguageTutorials = "https://reactjs.org/tutorial/tutorial.html"
                        },
                        new
                        {
                            ProgrammingLanguageId = 8,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "AngularJS was originally developed in 2009 by Miško Hevery at Brat Tech LLC as the software behind an online JSON storage service, that would have been priced by the megabyte, for easy-to-make applications for the enterprise.",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/angularjs.png",
                            ProgrammingLanguageName = "Angular",
                            ProgrammingLanguageOverview = "Angular is a platform and framework for building single-page client applications using HTML and TypeScript. Angular is written in TypeScript. It implements core and optional functionality as a set of TypeScript libraries that you import into your applications.",
                            ProgrammingLanguageTutorials = "https://www.tektutorialshub.com/angular-tutorial/"
                        },
                        new
                        {
                            ProgrammingLanguageId = 9,
                            ProgrammingLanguageCategory = "Low-level",
                            ProgrammingLanguageHistory = "PHP was conceived sometime in the fall of 1994 by Rasmus Lerdorf. Early non-released versions were used on his home page to keep track of who was looking at his online resume. The first version used by others was available sometime in early 1995 and was known as the Personal Home Page Tools.",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/offices/175/000000/php-logo.png",
                            ProgrammingLanguageName = "PHP",
                            ProgrammingLanguageOverview = "PHP is an intuitive, server side scripting language. Like any other scripting language it allows developers to build logic into the creation of web page content and handle data returned from a web browser. PHP also contains a number of extensions that make it easy to interact with databases, extracting data to be displayed on a web page and storing information entered by a web site visitor back into the database.",
                            ProgrammingLanguageTutorials = "https://www.w3schools.com/php/DEFAULT.asp"
                        },
                        new
                        {
                            ProgrammingLanguageId = 10,
                            ProgrammingLanguageCategory = "High-level",
                            ProgrammingLanguageHistory = "Development of Swift started in July 2010 by Chris Lattner, with the eventual collaboration of many other programmers at Apple.Swift took language ideas \"from Objective-C, Rust, Haskell, Ruby, Python, C#, CLU, and far too many others to list\"",
                            ProgrammingLanguageImageUrl = "https://img.icons8.com/color/175/000000/swift.png",
                            ProgrammingLanguageName = "Swift",
                            ProgrammingLanguageOverview = "Swift is a powerful and intuitive programming language for iOS, iPadOS, macOS, tvOS, and watchOS. Writing Swift code is interactive and fun, the syntax is concise yet expressive, and Swift includes modern features developers love. Swift code is safe by design, yet also produces software that runs lightning-fast.",
                            ProgrammingLanguageTutorials = "https://www.tutorialspoint.com/swift/index.htm"
                        });
                });

            modelBuilder.Entity("LearningCoding.Models.ProgrammingLanguageCons", b =>
                {
                    b.Property<int>("ProgrammingLanguageConsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProgrammingLanguageConsDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgrammingLanguageId")
                        .HasColumnType("int");

                    b.HasKey("ProgrammingLanguageConsId");

                    b.HasIndex("ProgrammingLanguageId");

                    b.ToTable("ProgrammingLanguageCon");

                    b.HasData(
                        new
                        {
                            ProgrammingLanguageConsId = 6,
                            ProgrammingLanguageConsDesc = "Poor x-platform GUI.",
                            ProgrammingLanguageId = 1
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 7,
                            ProgrammingLanguageConsDesc = "C# is an internal part of the . NET framework so the server running the application must be windows based.",
                            ProgrammingLanguageId = 1
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 8,
                            ProgrammingLanguageConsDesc = "C# is less flexible as it mostly depends on the . Net framework.",
                            ProgrammingLanguageId = 1
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 14,
                            ProgrammingLanguageConsDesc = "It cannot produce dynamic output alone, since it’s a static language.",
                            ProgrammingLanguageId = 2
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 15,
                            ProgrammingLanguageConsDesc = "Making of structure of HTML documents becomes tough to understood.",
                            ProgrammingLanguageId = 2
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 16,
                            ProgrammingLanguageConsDesc = "It is the time consuming as the time it consume to maintain on the colour scheme of a page and to make lists, tables and forms.",
                            ProgrammingLanguageId = 2
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 17,
                            ProgrammingLanguageConsDesc = "It can create only static and plain pages so if we’d like dynamic pages then HTML isn’t useful.",
                            ProgrammingLanguageId = 2
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 18,
                            ProgrammingLanguageConsDesc = "Required to write a lot of code for just creating simple webpage.",
                            ProgrammingLanguageId = 2
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 24,
                            ProgrammingLanguageConsDesc = "We discussed above that Python is an interpreted language and dynamically-typed language. The line by line execution of code often leads to slow execution.",
                            ProgrammingLanguageId = 3
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 25,
                            ProgrammingLanguageConsDesc = "To provide simplicity to the developer, Python has to do a little tradeoff. The Python programming language uses a large amount of memory. This can be a disadvantage while building applications when we prefer memory optimization.",
                            ProgrammingLanguageId = 3
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 26,
                            ProgrammingLanguageConsDesc = "Programming in Python is easy and stress-free. But when we are interacting with the database, it lacks behind.",
                            ProgrammingLanguageId = 3
                        },
                        new
                        {
                            ProgrammingLanguageConsId = 27,
                            ProgrammingLanguageConsDesc = "As we know Python is a dynamically typed language so the data type of a variable can change anytime. A variable containing integer number may hold a string in the future, which can lead to Runtime Errors.",
                            ProgrammingLanguageId = 3
                        });
                });

            modelBuilder.Entity("LearningCoding.Models.ProgrammingLanguagePros", b =>
                {
                    b.Property<int>("ProgrammingLanguageProsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProgrammingLanguageId")
                        .HasColumnType("int");

                    b.Property<string>("ProgrammingLanguageProsDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgrammingLanguageProsId");

                    b.HasIndex("ProgrammingLanguageId");

                    b.ToTable("ProgrammingLanguagePro");

                    b.HasData(
                        new
                        {
                            ProgrammingLanguageProsId = 1,
                            ProgrammingLanguageId = 1,
                            ProgrammingLanguageProsDesc = "Object-Oriented Language."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 2,
                            ProgrammingLanguageId = 1,
                            ProgrammingLanguageProsDesc = "Automatic Garbage Collection."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 3,
                            ProgrammingLanguageId = 1,
                            ProgrammingLanguageProsDesc = "Cross Platform"
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 4,
                            ProgrammingLanguageId = 1,
                            ProgrammingLanguageProsDesc = "Backward Compatibility"
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 5,
                            ProgrammingLanguageId = 1,
                            ProgrammingLanguageProsDesc = "Better Integrity and Interoperability"
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 9,
                            ProgrammingLanguageId = 2,
                            ProgrammingLanguageProsDesc = "Do not got to purchase any extra software because it’s by default in every window."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 10,
                            ProgrammingLanguageId = 2,
                            ProgrammingLanguageProsDesc = "HTML also allows the utilization of templates, which makes designing a webpage easy."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 11,
                            ProgrammingLanguageId = 2,
                            ProgrammingLanguageProsDesc = "HTML can be supported to each and every browser, if not supported to all the browers."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 12,
                            ProgrammingLanguageId = 2,
                            ProgrammingLanguageProsDesc = "HTML is present in every window by default so you not need to buy the software which cost too much."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 13,
                            ProgrammingLanguageId = 2,
                            ProgrammingLanguageProsDesc = "HTML is easy enough to write."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 19,
                            ProgrammingLanguageId = 3,
                            ProgrammingLanguageProsDesc = "Python is a high-level programming language that has English-like syntax. This makes it easier to read and understand the code"
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 20,
                            ProgrammingLanguageId = 3,
                            ProgrammingLanguageProsDesc = "Python is a very productive language. Due to the simplicity of Python, developers can focus on solving the problem. They don’t need to spend too much time in understanding the syntax or behavior of the programming language. You write less code and get more things done."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 21,
                            ProgrammingLanguageId = 3,
                            ProgrammingLanguageProsDesc = "Interpreted Language"
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 22,
                            ProgrammingLanguageId = 3,
                            ProgrammingLanguageProsDesc = "The standard library of Python is huge, you can find almost all the functions needed for your task. So, you don’t have to depend on external libraries."
                        },
                        new
                        {
                            ProgrammingLanguageProsId = 23,
                            ProgrammingLanguageId = 3,
                            ProgrammingLanguageProsDesc = "In many languages like C/C++, you need to change your code to run the program on different platforms. That is not the same with Python. You only write once and run it anywhere."
                        });
                });

            modelBuilder.Entity("LearningCoding.Models.ProgrammingLanguageCons", b =>
                {
                    b.HasOne("LearningCoding.Models.ProgrammingLanguage", "ProgrammingLanguage")
                        .WithMany("ProgrammingLanguageCons")
                        .HasForeignKey("ProgrammingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgrammingLanguage");
                });

            modelBuilder.Entity("LearningCoding.Models.ProgrammingLanguagePros", b =>
                {
                    b.HasOne("LearningCoding.Models.ProgrammingLanguage", "ProgrammingLanguage")
                        .WithMany("ProgrammingLanguagePros")
                        .HasForeignKey("ProgrammingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgrammingLanguage");
                });

            modelBuilder.Entity("LearningCoding.Models.ProgrammingLanguage", b =>
                {
                    b.Navigation("ProgrammingLanguageCons");

                    b.Navigation("ProgrammingLanguagePros");
                });
#pragma warning restore 612, 618
        }
    }
}
