using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Player
    {
        //player constructor
        public Player(string name, int beginnigBalance)
        {
            Hand = new List<Card>();
            Balance = beginnigBalance;
            Name = name;
        }

        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            //a bet must be positive; a negative bet would add money to the balance
            if (amount <= 0)
            {
                Console.WriteLine("Your bet must be more than 0.");
                return false;
            }
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough to place this bet.");
                return false;
            } 
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //operator overloading +/- add or remove a player
        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
