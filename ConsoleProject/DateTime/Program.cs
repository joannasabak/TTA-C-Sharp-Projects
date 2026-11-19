namespace DateAndTime

{
    class Program
    {
        static void Main()
        {
            //print current date and time
            Console.WriteLine("Current date and time is: " + DateTime.Now);
            
            //prompt the user for a nr
            Console.WriteLine("Please pick a number:");

            //keep asking until they input a valid nr
            int hours;
            while (!int.TryParse(Console.ReadLine(), out hours))
            {
                Console.WriteLine("That's not a number. Please try again: ");
            }

            //add the nr to the h
            DateTime future = DateTime.Now.AddHours(hours);
            
            //print it to the console
            Console.WriteLine("In " + hours + "h it will be: " + future);
            Console.ReadLine();
        }
    }
}