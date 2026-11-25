using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            //instantiate a new dealer
            Dealer = new TwentyOneDealer();

            //make sure each player starts with an empty hand
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            //new deck for the dealer
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            //players bet - method in Player; successful if amount lower than balance
            //bet is added to a dictionary prop from Game
            foreach (Player player in Players)
            {
                //keep asking until the input is a whole number
                int bet;
                while (!int.TryParse(Console.ReadLine(), out bet))
                {
                    Console.WriteLine("Please enter a whole number for your bet.");
                }
                if (bet < 0)
                {
                    throw new FraudException();
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }

            //give everyone a card
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackjack = TwentyOneRules.CheckForBlackjack(player.Hand);
                        if (blackjack)
                        {
                            //blackjack pays 1.5x the bet, plus the original bet back
                            int winnings = Convert.ToInt32(Bets[player] * 1.5);
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, winnings);
                            player.Balance += winnings + Bets[player];
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackjack = TwentyOneRules.CheckForBlackjack(Dealer.Hand);
                    if (blackjack)
                    {
                        Console.WriteLine("Blackjack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                        //the player is out, so end this round here
                        return;
                    }
                }
            }

            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //entry.Key is the Player object itself, so pay them directly
                    entry.Key.Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }

                //ask each player whether they want another round before ending this one
                foreach (Player player in Players)
                {
                    Console.WriteLine("Do you want to play again?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        player.isActivelyPlaying = true;
                    }
                    else
                    {
                        player.isActivelyPlaying = false;
                    }
                }
                return;
            }

            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Do you want to play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
