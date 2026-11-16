namespace OptionalParam;

public class Program
{
    static void Main()
    {
        //create an instance of the Calculate class
        Calculate calculate = new Calculate();

        //prompt the user for the first number
        Console.WriteLine("What number would you like to use for some math operations?");
        int userInput = Convert.ToInt32(Console.ReadLine());

        //prompt the user for the second number (optional)
        Console.WriteLine("What exponent would you like to use? It is optional.");
        string exponentInput = Console.ReadLine();
        

        if (string.IsNullOrEmpty(exponentInput))
        {
            //call the Power method with only one parameter
            Console.WriteLine(userInput + " to the power of 2 is: " + calculate.Power(userInput));
        }
        else
        {
            //call the Power method with both parameters
            int exponent = Convert.ToInt32(exponentInput);
            Console.WriteLine(userInput + " to the power of " + exponent + " is: " + calculate.Power(userInput, exponent));
        }

        Console.ReadLine();
    }
}