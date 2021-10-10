using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    public class Player : Members
    {
        public void Init(Card card1, Card card2)
        {
            AddCard(card1);
            AddCard(card2);
        }
    }
}
