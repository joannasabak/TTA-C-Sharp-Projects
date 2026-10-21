using System;

class SampleApp
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string date = DateTime.Today.ToShortDateString();
        string name = Console.ReadLine();
        string msg = $"\nHello, {name}! Today is {date}.";
        Console.WriteLine(msg);

        string path = @"C:\Users\hackathon\Documents\GitHub\Basic-C#-Programs\ConsoleProject\ConsoleProject\studentScores.txt";
        string[] lines = System.IO.File.ReadAllLines(path);

        double total = 0.0;
        Console.WriteLine("\nStudent Score:  \n");
        foreach (string line in lines)
        {
            Console.Write("\n" + line);
            double score = Convert.ToDouble(line);
            total += score;
        }

        double avg = total / lines.Length;
        Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avg);
        Console.WriteLine("\nPress any key to exit. It is important to use the right escape sequences \" \" - like the double quote character.");

        Console.Read();
    }
}