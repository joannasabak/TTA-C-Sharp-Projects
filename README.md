# The Tech Academy Basic C-Sharp Projects

## Introduction

This repository contains the coding projects I've built while completing the C# course at The Tech Academy. 
It's a record of my progress as I learned to write, debug, and organize C# code.

## What's Inside

| Folder | What it is |
|---|---|
| `ConsoleProject/` | A solution of small console apps — one per course drill (data types, methods, loops, classes, exceptions and more) |
| `TwentyOne/` | A Twenty-One (blackjack) card game: a `Casino` class library plus a console app that uses it, with exceptions logged to SQL Server |
| `MVC/CarInsurance/` | ASP.NET Core MVC app that calculates car insurance quotes, with an admin page listing all quotes issued |
| `MVC/NewsletterApp/` | ASP.NET MVC 5 newsletter sign-up form that saves subscribers to a database |

### Console drills

The `ConsoleProject` solution covers the course fundamentals, including:

- **Basics:** data types, strings and integers, math operations, boolean logic, `DateTime`
- **Control flow:** iterations, switch/break, arrays and loops
- **Methods:** calling methods, overloading, optional parameters, the `Main` method
- **Object-oriented programming:** constructors, abstract classes, structs, enums, generics
- **Error handling:** exceptions and try/catch
- **More advanced:** lambda expressions, logging

## Tools and Technologies

- **Language:** C#
- **IDE:** Visual Studio
- **Framework:** .NET 10 (NewsletterApp uses .NET Framework 4.7.2)
- **Web:** ASP.NET Core MVC, ASP.NET MVC 5
- **Data:** SQL Server LocalDB, Entity Framework Core, ADO.NET
- **Version control:** Git and GitHub

## Running the Projects

1. Clone the repository.
2. Open the `.slnx` file for the project you want in Visual Studio.
3. Right-click the project to run and choose **Set as Startup Project**, then press **F5**.

The database projects (TwentyOne, CarInsurance, NewsletterApp) expect **SQL Server LocalDB** at `(localdb)\MSSQLLocalDB`.
For CarInsurance, run `Update-Database` in the Package Manager Console first to create the database.
