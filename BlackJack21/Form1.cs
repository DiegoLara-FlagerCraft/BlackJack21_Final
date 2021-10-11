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
        int Games = 0;
        int Very = 0;

        public Form1()
        {
            InitializeComponent();
            BtnIniciar.Show();
            BtnPedir.Hide();
            BtnPlantar.Hide();
        }

        public int Check(List<Card> Hand)
        {

            int Score = 0;
            foreach (Card c in Hand)
            {
                if (c.score == 1 && Score + c.score <= 10)
                {
                    Score += 11;
                }
                else if (c.score == 1 && Score + c.score > 10)
                {
                    Score += 1;
                }
                else
                {
                    Score += c.score;
                }
            }
            return
                Score;

        }

        public void Clean()
        {
            P.Hand = new List<Card>();
            D.Hand = new List<Card>();
            RtxtManoD.Text = " ";
            RtxtManoP.Text = " ";
            RtxtScoreD.Text = " ";
            RtxtScoreP.Text = " ";
            ScoreD = 0;
            ScoreP = 0;
        }
        public void CardsP()
        {
            RtxtManoP.Clear();
            foreach (Card c in P.Hand)
            {
                RtxtManoP.Text += c.Suit + c.Symbol + "\n";
            }
        }
        public void CardsD()
        {
            RtxtManoD.Clear();
            Card c = D.Hand.First();
            RtxtManoD.Text += c.Suit + c.Symbol + "\n";
            ScoreD = c.score;
            RtxtScoreD.Text = Convert.ToString(ScoreD);
        }

        public void CardsDfn()
        {
            RtxtManoD.Clear();
            foreach (Card c in D.Hand)
            {
                RtxtManoD.Text += c.Suit + c.Symbol + "\n";
            }
            ScoreD = Check(D.Hand);
            RtxtScoreD.Text = Convert.ToString(ScoreD);
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
            P.Init(card1, card2);
            CardsP();
            CardsD();
            ScoreP = Check(P.Hand);
            RtxtScoreP.Text = Convert.ToString(ScoreP);
            Games += 1;
            RtxtGames.Text = Convert.ToString(Games);

            if (ScoreP == 21)
            {
                BtnPedir.Hide();
                BtnPlantar.Hide();
                MessageBox.Show("BLACKJACK");
                BtnIniciar.Show();
                Clean();
                Wins += 1;
                RtxtWins.Text = Convert.ToString(Wins);
            }
            
        }
        private void BtnPedir_Click(object sender, EventArgs e)
        {
            Card c = D.Deal();
            P.AddCard(c);
            CardsP();
            ScoreP = Check(P.Hand);
            RtxtScoreP.Text = Convert.ToString(ScoreP);

            if (ScoreP > 21)
            {
                BtnPedir.Hide();
                BtnPlantar.Hide();
                MessageBox.Show("PERDISTE");
                BtnIniciar.Show();
                Clean();
                Fails += 1;
                RtxtFails.Text = Convert.ToString(Fails);
            }
        }

        private void BtnPlantar_Click(object sender, EventArgs e)
        {
            CardsDfn();
            ScoreD = Check(D.Hand);

            if (ScoreD >= ScoreP)
            {
                BtnPedir.Hide();
                BtnPlantar.Hide();
                MessageBox.Show("PERDISTE");
                BtnIniciar.Show();
                Clean();
                Fails += 1;
                RtxtFails.Text = Convert.ToString(Fails);
            }

            else if (ScoreP > 17)
            {
                while (ScoreD < 21)
                {
                    Card c = D.Deal();
                    D.AddCard(c);
                    CardsDfn();
                    ScoreD = Check(D.Hand);
                    RtxtScoreD.Text = Convert.ToString(ScoreD);
                }
            }

            else if (ScoreP <= 17)
            {
                while (ScoreD < 17)
                {
                    Card c = D.Deal();
                    D.AddCard(c);
                    CardsDfn();
                    ScoreD = Check(D.Hand);
                    RtxtScoreD.Text = Convert.ToString(ScoreD);
                }
            }

            Confirm();
        }

        public void Confirm()
        {
            if (ScoreD < ScoreP)
            {
                BtnPedir.Hide();
                BtnPlantar.Hide();
                MessageBox.Show("GANASTE");
                BtnIniciar.Show();
                Clean();
                Wins += 1;
                RtxtWins.Text = Convert.ToString(Wins);
            }

            else if (ScoreD > 21)
            {
                BtnPedir.Hide();
                BtnPlantar.Hide();
                MessageBox.Show("GANASTE");
                BtnIniciar.Show();
                Clean();
                Wins += 1;
                RtxtWins.Text = Convert.ToString(Wins);
            }

            else if (ScoreD > ScoreP && ScoreD <= 21)
            {
                BtnPedir.Hide();
                BtnPlantar.Hide();
                MessageBox.Show("PERDISTE");
                BtnIniciar.Show();
                Clean();
                Fails += 1;
                RtxtFails.Text = Convert.ToString(Fails);
            }
        }
    }
}

