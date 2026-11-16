using System;

namespace MainMethod;

public class MathOperations
{
    //first method takes two integers and returns their sum
    public int Calculate(int a, int b)
    {
        return a + b;
    }

    //second method takes two decimals and returns their product as int
    public int Calculate(decimal a, decimal b)
    {
        decimal result = a * b;
        return Convert.ToInt32(result);
    }

    //third method takes two strings, converts them to integers, and returns their difference
    public int Calculate(string number1, string number2)
    {
        if (int.TryParse(number1, out int a) && int.TryParse(number2, out int b))
        {
            return a - b;
        }
        else
        {
            throw new ArgumentException($"'{number1}' or '{number2}' is not a whole number.");
        }         
    }
}
