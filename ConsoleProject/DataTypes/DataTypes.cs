using System;

class DataTypesProgram
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Data Types Program!");
        
        Console.WriteLine("\nWhat is your favourite number?");
        string favouriteNr = Console.ReadLine();
        int fav = Convert.ToInt32(favouriteNr);
        int total = fav + 5;

        Console.WriteLine("Your favourite number + 5 is: " + total);

        Console.WriteLine("\nPress any key to exit.");
        Console.Read();
    }
}