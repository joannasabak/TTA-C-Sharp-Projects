namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask player for their name and balance
            Console.WriteLine("Welcome to the Casino! Tell us your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            //keep asking until the input is a whole number
            int bank;
            while (!int.TryParse(Console.ReadLine(), out bank))
            {
                Console.WriteLine("Please enter a whole number.");
            }
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
        

            //if they want to play initialize the game
            if (answer == "yes" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
           
                //conditions to keep playing
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                //after the loop remove them from play
                game -= player;
                Console.WriteLine("Thank you for playing.");
            }

            Console.WriteLine("Feel free to look around. Bye now.");
            Console.Read();
        
        }

    }
}