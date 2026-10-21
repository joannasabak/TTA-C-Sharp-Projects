using System;

namespace IncomeComparison
{

    class IncomeCompare
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // Prompt user for input for Person 1 and Person 2
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hours1 = Console.ReadLine();

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hours2 = Console.ReadLine();

            // Convert inputs to decimal for calculations
            decimal Rate1 = Convert.ToDecimal(hourlyRate1);
            decimal Rate2 = Convert.ToDecimal(hourlyRate2);
            decimal Hours1 = Convert.ToDecimal(hours1);
            decimal Hours2 = Convert.ToDecimal(hours2);

            decimal annualSalary1 = Rate1 * Hours1 * 52;
            decimal annualSalary2 = Rate2 * Hours2 * 52;

            // Display annual salaries
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

            // Compare salaries and display result
            bool isPerson1Higher = annualSalary1 > annualSalary2;

            Console.WriteLine("Does Person 1 make more money than Person 2? " + isPerson1Higher);

            // Wait for user input before closing the program
            Console.WriteLine("\nPress any key to exit.");
            Console.Read();
        }
    }
}
