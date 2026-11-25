using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick another number");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Dividing the two:");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberThree);
            Console.ReadLine();
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole nr");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by 0.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}