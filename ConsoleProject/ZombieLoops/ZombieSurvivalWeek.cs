using System;

//Zombie Survival Week:
//A text-based adventure game where the player must survive a zombie outbreak for 6 days until rescue arrives.
//The player must manage food supplies, make decisions during zombie encounters, and signal for rescue.

namespace ZombieSurvivalWeek
{
    class CanYouMakeIt
    {
        static void Main()
        {
            //intro
            Console.WriteLine("A zombie outbreak has hit your town. \nYou’re holed up in an abandoned supermarket, and the radio says a rescue helicopter will arrive soon.");
            Console.WriteLine("\nYou have to survive until then.");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            //food inputs
            Console.WriteLine($"\nHello, {name}! How many cans of food do you have?");
            int food = int.Parse(Console.ReadLine());

            //day inputs
            Console.WriteLine("\nHow many days have you been hiding for?");
            int day = int.Parse(Console.ReadLine());

            //sets player's alive status
            bool isAlive = true;

            //while loop to simulate each day of survival
            while (day <= 6 && isAlive)
            {
                //picks a scenario for each day
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Day 1: It's only been one day. Focus on barricading the doors.");
                        break;

                    case 2:
                        Console.WriteLine("Day 2: You found some extra supplies! Make sure to hide them well.");
                        food += 2;
                        break;

                    case 3:
                        Console.WriteLine("Day 3: Your water reserves are running low. Find a way to replenish them.");
                        break;

                    case 4:
                        Console.WriteLine("Day 4: You were attacked by zombies!");
                        //prompt the player to choose to fight or run
                        Console.WriteLine("\nDo you fight (f) or run (r)?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "f")
                        {
                            Console.WriteLine("You fought bravely and survived the day!");
                        }
                        else if (choice == "r")
                        {
                            Console.WriteLine("You ran away and survived the day!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice! You hesitated and got caught by zombies. Game over.");
                            isAlive = false;
                        }
                        break;

                    case 5:
                        Console.WriteLine("Day 5: You go and scout for more supplies. Do you find any? Answer (y/n):");
                        //prompt the player to choose to find supplies or not
                        string supplyChoice = Console.ReadLine().ToLower();                       
                        if (supplyChoice == "y")
                        {
                            Console.WriteLine("Great! You found more supplies.");
                            food += 3;
                        }
                        else
                        {
                            Console.WriteLine("You didn't find any more supplies.");
                            if (food <= 5)
                            {
                                Console.WriteLine("You ran out of food and starved. Game over.");
                                isAlive = false;
                            }
                            else
                            {
                                Console.WriteLine("But you still have some food left. Stay strong!");
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Day 6: You survived 6 days! Bear a little longer, help is coming!");
                        break;
                }

                //check if the player is still alive and manage food consumption
                if (isAlive)
                {
                    food--;
                    if (food < 0)
                    {
                        Console.WriteLine("You ran out of food and starved. Game over.");
                        isAlive = false;
                    }
                    else
                    {
                        Console.WriteLine($"You survived with {food} units of food left.");
                        Console.WriteLine("\nPress Enter to continue to the next day...");
                        Console.ReadLine();
                        day++;
                    }
                }

            }

            //if the player survived until day 6, prompt them to signal for rescue
            if (isAlive)
            {
                Console.WriteLine($"\nYou survived {day - 1} days! The helicopter is approaching.");
                //boolean to use in while loop
                bool choice = false;

                //do-while loop to prompt the player to signal for rescue
                do
                {
                    Console.WriteLine("\nDo you want to fire a flare? (y/n)");
                    string signalChoice = Console.ReadLine().ToLower();

                    //signal choice logic to determine if the player survives or not
                    if (signalChoice == "y")
                    {
                        choice = true;
                        Console.WriteLine("You signaled the helicopter! Did the pilot see you? (y/n)");
                        string pilotChoice = Console.ReadLine().ToLower();
                        if (pilotChoice == "y")
                        {
                            Console.WriteLine("The pilot saw you and successfully rescued you! Congratulations!");
                        }
                        else
                        {
                            Console.WriteLine("The pilot didn't see you. The helicopter leaves without noticing you. Game over.");
                        }
                    }
                    else if (signalChoice == "n")
                    {
                        choice = true;
                        Console.WriteLine("You decided not to signal the helicopter. The helicopter leaves without noticing you. Game over.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice! Please enter 'y' or 'n'.");
                    }
                }
                while (!choice);
            }
            else
            {
                Console.WriteLine("\nYou didn't survive the zombie outbreak. Better luck next time!");
            }

            Console.ReadLine();
        }
    }
}