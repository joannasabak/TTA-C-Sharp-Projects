namespace Struct;

class Program
{
    static void Main()
    {
        //create object of data type Number
        Number number1 = new Number();
        //assign value to number1
        number1.Amount = 5.5m;

        //print to the console
        Console.WriteLine("Value of ths number is " + number1.Amount);
        Console.ReadLine();
    }
}