using System;
using System.Collections.Generic;

namespace Assignments
{
    class App
    {
        static void Main(string[] args)
        {
            //create a string array
            string[] grandTitles = { "Sir", "Duchess", "Lord", "Lady", "Captain", "High Admiral" };

            //ask user for text input
            Console.WriteLine("What is your pet's name? They can get a grand title today");
            string petName = Console.ReadLine();

            //loop that iterates through the array and adds the user text to the end of each string
            for (int i = 0; i < grandTitles.Length; i++)
            {
                grandTitles[i] += " " + petName;
            }

            //another loop that prints off each string - this is a correct code which is a fix for infinite loops below
            for (int j = 0; j < grandTitles.Length; j++)
            {
                Console.WriteLine(grandTitles[j]);
            }

            Console.WriteLine("\nPick the one you like! Press Enter for more pet stuff");
            //Console.WriteLine("\nPress any key for some infinite loops");
            Console.ReadLine();


            //infinite loop v1 - never increment the counter; it will print the first item forever
            //fixed version is above, printing each element of the array once

            //for (int l = 0; l < grandTitles.Length;)
            //{
            //    Console.WriteLine(grandTitles[l]);
            //}

            //infinite lopp v2
            //once the loop gets to the end, it counts back and cycles through the loop forever
            //the fix is to remove the if statement from the loop back to the original print off loop

            //for (int m = 0; m < grandTitles.Length; m++)
            //{
            //    Console.WriteLine(grandTitles[m]);
            //    if (m == grandTitles.Length -1)
            //    {
            //        m = -1;
            //    }
            //}

            //loop using '<' to run - run is determined by the length of the array
            //it checks how many characters are in the name and prints different results
            for (int pet = 0; pet < grandTitles.Length; pet++)
            {
                if (grandTitles[pet].Length < 10)
                {
                    Console.WriteLine(grandTitles[pet] + " is a great name!");
                }
                else
                {
                    Console.WriteLine(grandTitles[pet] + " is a bit too long, it has " + grandTitles[pet].Length + " characters.");
                }
            }

            //string list, picking items from a list under certain conditions which are determined based on user inputs
            Console.WriteLine("\nLet's check if you are a good pet owner.");
            Console.WriteLine("How many times a week do you play with your pet?");
            int play = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times a week do you cuddle your pet?");
            int cuddles = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times a week do you leave them alone?");
            int alone = int.Parse(Console.ReadLine());

            List<string> care = new List<string>();

            care.Add("You are a great pet owner");
            care.Add("You are ok but you could do better");
            care.Add("You should really take better care of them!");

            double ownerScore = play * 0.4 + cuddles * 0.3 - alone * 0.3;

            if (ownerScore >= 8)
            {
                Console.WriteLine(care[0]);
            }
            else if (ownerScore < 8 && ownerScore >= 4)
            {
                Console.WriteLine(care[1]);
            }
            else
            {
                Console.WriteLine(care[2]);
            }

            //loop that uses <= to run
            //it adds a heart based on the number
            Console.Write("Love meter: ");
            for (int i = 1; i <= ownerScore; i++)
            {
                Console.Write("<3 ");
            }
            Console.ReadLine();

            AppLists.PartTwo();
        }

    }

    class AppLists
    {
        public static void PartTwo()
        {
            //intro
            Console.WriteLine("\nEnough about pets!");

            //list of unique strings
            List<string> climbingStuff = new List<string>()
            { "la sportiva shoes", "100m long rope", "15 quickdraws", "belay device", "grey chalk bag", "healthy snacks" };

            //intro
            Console.WriteLine("\nYour friend made a list of things you should pack for a climbing trip.");

            //boolean operator to determine if there was a match or not; once the item has been found, it stops the loop
            //if not found, it displays to the user that there are no matches
            bool found = false;

            while (!found)
            {
                //prompt for the search word, lowercased so capital letters don't affect matching
                Console.WriteLine("Check if they put everything in. Type what item to search for: ");
                string item = Console.ReadLine().ToLower();

                //go through each item in the list, using a for loop so we have the index
                for (int i = 0; i < climbingStuff.Count; i++)
                {
                    //split the item into an array of single words
                    string[] things = climbingStuff[i].ToLower().Split(' ');

                    //check each word against the search
                    foreach (string thing in things)
                    {
                        //if the words match, display the full item and its position (i + 1 so the list starts at 1)
                        if (thing == item)
                        {
                            Console.WriteLine("This item is already on the list at number " + (i + 1) + " as: " + climbingStuff[i]);
                            //setting found to true means the while loop won't run again
                            found = true;
                            //stop checking this item's words; the for loop carries on to find any other matches
                            break;
                        }
                    }
                }
                //no match so tell the user to answer again
                if (!found)
                {
                    Console.WriteLine("No matches for " + item + ". Try another item.");
                }
            }

            //runs once a match has been found
            Console.WriteLine("Happy climbing!");
            Console.ReadLine();


            //list of string with duplicate items
            List<string> duplicates = new List<string>()
            { "Greece", "Spain", "Yosemite", "Nevada", "Greece", "UK", "Morocco", "UK" };

            //input from the user
            Console.WriteLine("Your friend also wrote a selection of places to go climbing.");
            Console.WriteLine("Where do you want to go? Let's see if you match!");
            string places = Console.ReadLine().ToLower();

            //bool to track the match
            bool match = false;

            for (int j = 0; j < duplicates.Count; j++)
            {
                //check for matches 
                if (places == duplicates[j].ToLower())
                {
                    Console.WriteLine("You picked the same place. It was number " + (j+1) + " on their list.");
                    //switch bool to true to exit the loop
                    match = true;
                }
            }

            //if there's no match, tell the user
            if (!match)
            {
                Console.WriteLine("You don't like the same places. No match found!");
            }

            Console.ReadLine();


            //check for duplicates and mark them
            //create a new list of 'seen' items
            //hat remembers every place the loop has already looked at
            List<string> seen = new List<string>();

            Console.WriteLine("Let's check the friend's list for any places they wrote twice. This might mean they really like it.");
            Console.WriteLine("Press Enter to check");
            Console.ReadLine();

            foreach (string spot in duplicates)
            {
                //if the place is already in the seen list, it appeared earlier, so it's a duplicate
                if (seen.Contains(places))
                {
                    Console.WriteLine(spot + " - this place is a duplicate.");
                }
                else
                {
                    Console.WriteLine(spot + " - this place is unique");
                    //remember it so any later copy is recognised as a duplicate
                    seen.Add(spot);
                }
            }

            Console.ReadLine();
        }

    }
}