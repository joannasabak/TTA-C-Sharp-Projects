using System;

namespace CarInsurance
{
    class Eligible
    {
        public static bool IsEligible(int age, bool hadDUI, int speedingTickets)
        {
            return age >= 15 && !hadDUI && speedingTickets < 3;        
        }

        static void Main()
        {
            //user inputs
            Console.WriteLine("Eligibility Check:");
            Console.WriteLine("\nWhat is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? (true/false)");
            bool hadDUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int speedingTickets = int.Parse(Console.ReadLine());

            //check eligibility
            if (IsEligible(age, hadDUI, speedingTickets)) 
            {
                Console.WriteLine("\nYou are eligible for car insurance.");
            }
            else
            {
                Console.WriteLine("\nYou are not eligible for car insurance.");
            }
        }
    }
}