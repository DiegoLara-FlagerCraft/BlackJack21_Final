using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    public class Members
    {
        private List<Card> hand = new List<Card>();
        public List<Card> Hand { get => hand; set => hand = value; }

        public void AddCard(Card c)
        {
            Hand.Add(c);
        }
    }
}
