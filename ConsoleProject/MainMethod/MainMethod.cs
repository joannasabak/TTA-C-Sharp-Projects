namespace MainMethod;

public class Program
{ 
    static void Main()
    {
        //instantiate the MathOperations class
        MathOperations math = new MathOperations();

        //call the Calculate methods with different parameter types
        //integers
        int result1 = math.Calculate(5, 10);
        Console.WriteLine("The result of adding 5 and 10 is: " + result1);

        //decimals
        int result2 = math.Calculate(5.5m, 10.2m);
        Console.WriteLine("The result of multiplying 5.5 and 10.2 is: " + result2);

        //strings
        int result3 = math.Calculate("15", "5");
        Console.WriteLine("The result of subtracting 5 from 15 is: " + result3);

        Console.ReadLine();
    }

}
    