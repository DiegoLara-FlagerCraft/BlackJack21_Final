using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    class Dealer
    {
        private List<Card> deck;
        private List<Card> hand;

        public void Generate()
        {
            deck = new List<Card>();

            string[] suits = { "♥", "♦", "♣", "♠" };
            string[] symbols = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach(string s in suits)
            {
                foreach (string sy in symbols)
                {
                    deck.Add(new Card(s, sy));
                }
            }

            Randomize();
        }

        public List<Card> GetDeck()
        {
            return deck;
        }

        private void Randomize()
        {
            Random ran = new Random();
            this.deck = this.deck.OrderBy(a => ran.Next()).ToList();
        }

        public Card Deal()
        {
            Card c = deck.Last();
            this.deck.RemoveAt(this.deck.Count - 1);
            hand.Add(c);
            return c;
        }
        public List<Card> GetHand()
        {
            return hand;
        }

    }
}
 