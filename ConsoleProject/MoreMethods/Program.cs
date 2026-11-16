using MoreMethods;

namespace VoidMethod;

public class  Program
{
    static void Main()
    {
        //instantiate the Results class
        Results result = new Results();

        //call the Actions method with two numbers
        result.Actions(5, 10);
        //call the Actions method with named parameters
        result.Actions(a: 5, b: 10);
        //call the Actions method with named parameters in reverse order
        result.Actions(b: 10, a: 5);

        Console.ReadLine();

    }
}