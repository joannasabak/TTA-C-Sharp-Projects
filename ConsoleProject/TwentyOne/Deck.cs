using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Deck
    {
        //deck constructor
        public Deck()
        {
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }             
            }
        }

        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> shuffledCards = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    //create a random indicies with values between zero and deck size (52)
                    int randomIndex = random.Next(0, Cards.Count);
                    //add a card to shuffledCards at random index
                    shuffledCards.Add(Cards[randomIndex]);
                    //remove a card from the original deck
                    Cards.RemoveAt(randomIndex);
                }

                //return a new deck with shuffled cards
                this.Cards = shuffledCards;
            }
        }
    }
}
