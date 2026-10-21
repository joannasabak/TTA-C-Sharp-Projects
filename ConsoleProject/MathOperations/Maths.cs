using System;

namespace MathOperations
{
    class Maths
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Math Operations Program!");
            // Prompt user for a number
            Console.WriteLine("\nPlease enter the first number:");
            string firstInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstInput);
            double operation1 = firstNumber * 50;

            //print the result and implicitly convert the double to a string for concatenation
            Console.WriteLine("Your number multiplied by 50 is: " + operation1);

            //second number operation
            Console.WriteLine("\nPlease enter the second number:");
            string secondInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondInput);
            double operation2 = secondNumber + 25;

            Console.WriteLine("Your second number plus 25 is: " + operation2);

            //third number operation
            Console.WriteLine("\nPlease enter the third number:");
            string thirdInput = Console.ReadLine();
            double thirdNumber = Convert.ToDouble(thirdInput);
            double operation3 = thirdNumber / 12.5;

            Console.WriteLine("Your third by number divided by 12.5 is: " + operation3);

            //fourth number needs a boolean operation
            Console.WriteLine("\nPlease enter the fourth number:");
            string fourthInput = Console.ReadLine();
            double fourthNumber = Convert.ToDouble(fourthInput);
            bool operation4 = fourthNumber > 50;

            Console.WriteLine("Is your fourth number greater than 50? " + operation4);

            //fifth number operation - modulus
            Console.WriteLine("\nPlease enter the fifth number:");
            string fifthInput = Console.ReadLine();
            double fifthNumber = Convert.ToDouble(fifthInput);
            double operation5 = fifthNumber % 7;

            Console.WriteLine("Your fifth number modulo 7 is: " + operation5);

            Console.WriteLine("\nPress any key to exit.");
            Console.Read();
        }
    }
}