namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the program!");
            Console.WriteLine("How old are you?");

            try
            {
                //convert user input to int; if not correct, throws a FormatException
                int userAge = int.Parse(Console.ReadLine());

                //a negative age is out of range
                if (userAge <= 0 || userAge > 150)
                {
                    throw new ArgumentOutOfRangeException();
                }

                int userBorn = DateTime.Now.Year - userAge;
                Console.WriteLine("You were born in {0}.", userBorn);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Age must be greater than 0 and less than 150.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input a whole number.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }

            Console.ReadLine();
            
        }
    }
}