using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    class Card
    {
        public string suit;
        public string symbol;
        public string color;
        public int score;

        public string Suit { get => suit; set => suit = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Color { get => color; set => color = value; }
        public int Score { get => score; set => score = value; }

        public Card(string suit, string symbol)
        {
            this.suit = suit;
            this.symbol = symbol;

            if (suit == "♥" || suit == "♦")
            {
                this.color = "Red";
            }

            if (suit == "♣" || suit == "♠")
            {
                this.color = "Black";
            }

            //_______________________________________________________________________

            if (symbol == "A")
            {
                this.score = 1;
            }

            if (symbol == "2")
            {
                this.score = 2;
            }

            if (symbol == "3")
            {
                this.score = 3;
            }

            if (symbol == "4")
            {
                this.score = 4;
            }

            if (symbol == "5")
            {
                this.score = 5;
            }

            if (symbol == "6")
            {
                this.score = 6;
            }

            if (symbol == "7")
            {
                this.score = 7;
            }

            if (symbol == "8")
            {
                this.score = 8;
            }

            if (symbol == "9")
            {
                this.score = 9;
            }

            if (symbol == "10" || symbol == "J" || symbol == "Q" || symbol == "K")
            {
                this.score = 10;
            }
        }
    }
}
