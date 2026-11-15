using System;
using System.Linq;

class StrIntExceptions
{
    static void Main(string[] args)
    {
        //array of 10 random numbers between 1 and 20
        //int count = 10;
        //int[] numbers = new int[count];

        //for (int i = 0; i < count; i++)
        //{
        //    numbers[i] = Random.Shared.Next(1, 21);
        //}
        //Console.WriteLine(string.Join(", ", numbers));


        //list of 10 random numbers between 1 and 20
        List<int> numbers = Enumerable.Range(0, 10)
            .Select(_ => Random.Shared.Next(1, 21))
            .ToList();

        //display the numbers in the list
        Console.WriteLine("" + string.Join(", ", numbers));

        //ask the user to pick a number
        Console.WriteLine("Pick a number");

  
        try
        {
            int userNr = int.Parse(Console.ReadLine());

            //divide each number in the list by the user's number and display the results
            List<int> results = new List<int>();
            foreach (int nr in numbers)
            {
                results.Add(nr / userNr);
            }
            Console.WriteLine("Result:");
            foreach (int r in results)
            {
                Console.WriteLine(r);
            }
        }
        //catch division by zero exception
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by 0.");
        }
        //catch format exception
        catch (FormatException ex)
        {
            Console.WriteLine("Please write a whole number");
        }
        //catch any other exception
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