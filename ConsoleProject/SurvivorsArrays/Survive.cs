using System;

class SurvivorData
{
    static void Main()
    {
        Console.WriteLine("Still playing the zombie apocalypse theme.");
        //string array
        string[] survivors = { "Alice", "Bob", "Charlie", "Diana", "Ethan", "Kelly", "Liam" };
        //integer array
        int[] zombiesKilled = { 5, 3, 8, 2, 6, 4, 7 };

        //intro line
        Console.WriteLine("This is a register of survivors and their zombie kills.");

        //loop to get a valid index from the user
        bool isIndex = false;

        //do-while loop to get correct index input from the user
        do
        {   
            //prompt for input
            Console.WriteLine("\nPick a number between 0 and 6 to view a survivor's details:");
            //index is int for picking from the array
            int index = int.Parse(Console.ReadLine());

            //if any true, the index is invalid
            if (index < 0 || index >= survivors.Length)
            {
                Console.WriteLine("Invalid index. Zombies are getting closer.");
                Console.WriteLine("Press any key to try again.");
                Console.ReadLine();
            }
            //otherwise, pick from both arrays and display the information
            else
            {
                Console.WriteLine($"Survivor: {survivors[index]}, Zombies Killed: {zombiesKilled[index]}");
                isIndex = true;
            }

        }
        while (!isIndex);

        //list of strings for hiding places
        List<string> hidingPlaces = new List<string> { "Abandoned Supermarket", "Old Warehouse", "Underground Bunker", "Forest Cabin" };

        //ask the user to pick a hiding place from the list
        Console.WriteLine("\nPick a hiding place for yourself - choose a number between 0 and 3:");
        int hidingPlaceIndex = int.Parse(Console.ReadLine());

        //if the index is invalid, they die
        if (hidingPlaceIndex < 0 || hidingPlaceIndex >= hidingPlaces.Count)
        {
            Console.WriteLine("Invalid index. You didn't follow the instructions and zombies ate you.");
        }
        //otherwise, display the hiding place they chose
        else
        {
            Console.WriteLine($"You have chosen to hide at {hidingPlaces[hidingPlaceIndex]}.");
        }

        Console.ReadLine();
    }

}