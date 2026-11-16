namespace MethodsFinal;

public class Program
{
    static void Main()
    {
        //instantiate the Operations class (step 2)
        Operations operation = new Operations();

        //prompt the user to enter a number (step 3)
        Console.WriteLine("Enter a number:");
        double number = Convert.ToDouble(Console.ReadLine());

        operation.Divide(number, out double result);

        Console.WriteLine("Your number has been divided by 2. The result is: " + result);

        //call the overloaded method (step 5)
        operation.Divide(5, out int intResult);
        Console.WriteLine("Result from overloaded method: " + intResult);

        //call the static method (step 6)
        Console.WriteLine("Result from static method: " + MathHelper.Triple(5));

        Console.ReadLine();

    }
}