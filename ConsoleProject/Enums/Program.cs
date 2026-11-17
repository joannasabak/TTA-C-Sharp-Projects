namespace Enums;

class Program
{
    static void Main()
    {
        //prompt the user to enter a day of the week
        Console.WriteLine("What day of the week is it?");

        //try to parse the user input into the Days enum and display the corresponding day
        try
        {
            // Read user input
            string todayIs = Console.ReadLine();
            // Parse the input into the Days enum
            //call Enum.Parse() method to convert the string input into the corresponding enum value
            //bool at the end of the method call is to ignore case sensitivity
            int dayIndex = (int)Enum.Parse(typeof(DaysOfTheWeek.Days), todayIs, true);

            Console.WriteLine("Today is: " + (DaysOfTheWeek.Days)dayIndex);
        }

        //catch any exceptions that may occur during parsing and display an error message
        catch (Exception)
        {
            Console.WriteLine("Invalid day name. Please enter a valid day of the week.");
        }
        //finally block to ensure that the program always displays a thank you message and waits for user input before closing
        finally
        {
            Console.WriteLine("Thank you for using the program.");
            Console.ReadLine();
        }
    }
}