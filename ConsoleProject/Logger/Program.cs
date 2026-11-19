namespace Logger;

class Program
{
    static void Main()
    {
        //prompt the user for a number
        Console.WriteLine("Please input a number: ");

        //make sure they input a nr - keep asking until they do
        int userNr;
        while (!int.TryParse(Console.ReadLine(), out userNr))
        {
            Console.WriteLine("That's not a number. Please try again: ");
        }

        //log it to the txt file
        File.AppendAllText(@"C:\Users\name\Documents\logs_c\yourNr.txt", "Your number is: " + userNr + "\n");

        //read the text file
        string print = File.ReadAllText(@"C:\Users\name\Documents\logs_c\yourNr.txt");
        //print it back to the user
        Console.WriteLine("Contents of the log file:");
        Console.WriteLine(print);
        Console.ReadLine();
    }
}