namespace CallingMethods;

public class Program
{
    static void Main()
    {
        //prompt the user for a number
        Console.WriteLine("What number would you like to use for some math operations?");
        int userInput = Convert.ToInt32(Console.ReadLine());

        //call the methods from the Maths class
        Console.WriteLine(userInput + " to the power of 2 is: " + Maths.Power(userInput));
        Console.WriteLine("The negative of " + userInput + " is: " + Maths.Negative(userInput));
        Console.WriteLine("The factorial of " + userInput + " is: " + Maths.Factorial(userInput));

    }
}