using System;
using System.Reflection.Metadata;

class DailyReport
{
    static void Main()
    {
        //introduction
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        //questions
        //name - string
        Console.WriteLine("1. What is your name?");
        string name = Console.ReadLine();

        //course - string
        Console.WriteLine("2. What course are you on?");
        string course = Console.ReadLine();

        //page nr - convert to int
        Console.WriteLine("3. What page number?");
        string page = Console.ReadLine();
        int pageNumber = Convert.ToInt32(page);

        //help - convert to bool
        Console.WriteLine("4. Do you need help with anything? Please answer \"true\" or \"false\".");
        string help = Console.ReadLine();
        bool needsHelp = Convert.ToBoolean(help);

        //positive experiences - string
        Console.WriteLine("5. Were there any positive experiences you'd like to share? Please give specifics.");
        string experiences = Console.ReadLine();

        //feedback - string
        Console.WriteLine("6. Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        //study hours - convert to int
        Console.WriteLine("7. How many hours did you study today?");
        string hours = Console.ReadLine();
        int studyHours = Convert.ToInt32(hours);

        //final message
        Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    
        Console.WriteLine("\nBelow are your responses:\n");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Page Number: {pageNumber}");
        Console.WriteLine($"Needs Help: {needsHelp}");
        Console.WriteLine($"Positive Experiences: {experiences}");
        Console.WriteLine($"Feedback: {feedback}");
        Console.WriteLine($"Study Hours: {studyHours}");

        Console.WriteLine("\nPress any key to exit.");
        Console.Read();
    }
}