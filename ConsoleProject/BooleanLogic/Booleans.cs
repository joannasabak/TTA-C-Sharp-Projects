using System;
using System.Reflection.Metadata;

namespace BooleanLogic
{
    class Booleans
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Boolean Logic Program!");

            //&& operator
            Console.WriteLine("\ntrue && false: " + (true && false));
            Console.WriteLine("\ntrue && true: " + (true && true));
            Console.WriteLine("\nfalse && false: " + (false && false));

            //|| operator
            Console.WriteLine("\ntrue || false: " + (true || false));
            Console.WriteLine("\ntrue || true: " + (true || true));
            Console.WriteLine("\nfalse || false: " + (false || false));

            //! operator
            Console.WriteLine("\n!true: " + (!true));
            Console.WriteLine("\n!false: " + (!false));

            //!= operator
            Console.WriteLine("\ntrue != false: " + (true != false));

            //^ operator
            Console.WriteLine("\ntrue ^ false: " + (true ^ false));
            Console.WriteLine("\ntrue ^ true: " + (true ^ true));



            Console.ReadLine();


        }
    }
}