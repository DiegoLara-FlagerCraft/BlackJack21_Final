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
        Dealer D = new Dealer();
        Player P = new Player();
        int ScoreD = 0;
        int ScoreP = 0;
        int Wins = 0;
        int Fails = 0;
        int Games =  0;
        
        public Form1()
        {
            InitializeComponent();
            BtnIniciar.Show();
            BtnPedir.Hide();
            BtnPlantar.Hide();
        }

        public int Verif(List<Card> Hand)
        {
            int Score = 0;
            foreach (Card c in Hand)
            {
                if ( c.Score == 1 && Score + c.Score > 21)
                {
                    Score += 1;
                }
                else
                {
                    Score += c.Score;
                }
            }
            return
                Score;

        }
        public void CardsP()
        {
            RtxtManoP.Clear();
            RtxtScoreD.Clear();
            foreach (Card c in P.Hand)
            {
                RtxtManoP.Text += c.Suit + c.Symbol + "\n";
            }
        }
        public void CardsD()
        {
            RtxtManoD.Clear();
            foreach (Card c in D.Hand)
            {
                RtxtManoD.Text += c.Suit + c.Symbol + "\n";
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            BtnIniciar.Visible = false;
            BtnPedir.Show();
            BtnPlantar.Show();
            D.Generate();
            D.Init();
            Card card1 = D.Deal();
            Card card2 = D.Deal();
            P.Init(card1,card2);
            CardsP();
            CardsD();
            ScoreP = Verif(P.Hand);
            RtxtScoreP.Text = Convert.ToString(ScoreP);
        }
        private void BtnPedir_Click(object sender, EventArgs e)
        {
            Card c = D.Deal();
            P.AddCard(c);
            CardsP();
            ScoreP = Verif(P.Hand);
            RtxtScoreP.Text = Convert.ToString(ScoreP);
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
    }
}
