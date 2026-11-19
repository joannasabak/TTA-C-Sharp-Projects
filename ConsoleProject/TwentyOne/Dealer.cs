using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\hackathon\Documents\logs_c\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); 
        }
    }
}
