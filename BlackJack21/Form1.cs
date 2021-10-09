using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dealer d = new Dealer();
            d.Generate();

            foreach(Card c in d.GetDeck())
            {
                RtxtMostrar.Text += c.Symbol + c.Suit + "- score: " + c.Score + " color: " + c.Color + "\n";
            }
        }

        private void BtnManoD_Click(object sender, EventArgs e)
        {
            Dealer f = new Dealer();
            f.Deal();

            foreach(Card c in f.GetHand())
            {
                RtxtManoD.Text = c.Symbol + c.Suit + "- score: " + c.Score + " color: " + c.Color + "\n";
            }
   
        }
    }
}
