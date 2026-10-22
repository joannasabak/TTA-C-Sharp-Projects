using System;

namespace AwesomePackages
{
    class RocketSpeedShipping
    {
        public static bool IsRightSize(double packageWidth, double packageHeight, double packageLength)
        {
            return packageWidth + packageHeight + packageLength <= 50;
        }

        public double Cost(double packageWidth, double packageHeight, double packageLength, double packageWeight)
        {
            return packageWidth * packageHeight * packageLength * packageWeight / 100;
        }

        static void Main()
        {
            //INTRO
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //inputs for weight
            Console.WriteLine("\nWe ship your package at rocket speed! Please enter your package parameters:");
            Console.WriteLine("\nWhat is the weight of your package in kgs?");
            double packageWeight = double.Parse(Console.ReadLine());

            //check the weight
            if (packageWeight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            //inputs for dims
            Console.WriteLine("\nWhat is the width of your package in cm?");
            double packageWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the height of your package in cm?");
            double packageHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the length of your package in cm?");
            double packageLength = double.Parse(Console.ReadLine());

            //check the if the package is too big
            if (!IsRightSize(packageWidth, packageHeight, packageLength))
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\nYour package is the right size! Rocket boosters on!");

            //calculate the cost
            RocketSpeedShipping shippingPrice = new RocketSpeedShipping();
            double packageCost = shippingPrice.Cost(packageWidth, packageHeight, packageLength, packageWeight);
            Console.WriteLine($"\nYour estimated total for shipping is ${packageCost:F2}.");
            Console.WriteLine("\nThank you for using Package Express. Have a nice day!");


            Console.ReadLine();
        }
    }
}