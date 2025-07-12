using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toc
{
    public partial class frmRockPaperScissorsGame : Form
    {
        enum enTurn
        {
            Player,
            Computer
        }

        enum enWinner
        {
            Player,
            Computer,
            Draw
        }

        enum enChoices
        {
            Rock,
            Paper,
            Scissor
        }
        struct stRoundInfo
        {
            public enTurn Turn;
            public enWinner Winner;
            public enChoices PlayerChoice;
            public enChoices ComputerChoice;
            public int NumberOfRounds;
        }

        struct stGameFinalResult
        {
            public int GameRounds;
            public int Player1WonTimes;
            public int ComputerWonTimes;
            public int DrawTimes;
            public enWinner WhoFinalWinner;
            public string NameFinalWinner;
        }


        stRoundInfo RoundInfo = new stRoundInfo();
        stGameFinalResult GameFinalResult = new stGameFinalResult();
        string[] arrChoices = { "Rock", "Paper", "Scissor" };
        public frmRockPaperScissorsGame(int NumberOfRounds)
        {
            InitializeComponent();
            GameFinalResult.GameRounds = NumberOfRounds;
        }

        private void frmRockPaperScissorsGame_Load(object sender, EventArgs e)
        {
            lblYourChoice.Text = "";
            lblWinner.Text = "";
            lblComputerChoice.Text = "";
            RoundInfo.NumberOfRounds = 1;
            lblRound.Text = "Round 1";
        }

        
        int GenerateRandomNumber()
        {
            Random rnd = new Random();

            return rnd.Next(1, 4);
        }

        enWinner WhoWin()
        {
            if (RoundInfo.PlayerChoice == RoundInfo.ComputerChoice)
                return enWinner.Draw;

            switch (RoundInfo.PlayerChoice)
            {
                case enChoices.Rock:
                    return ((RoundInfo.ComputerChoice == enChoices.Paper) ? enWinner.Computer : enWinner.Player);


                case enChoices.Paper:
                    return (RoundInfo.ComputerChoice == enChoices.Rock) ? enWinner.Player : enWinner.Computer;

                case enChoices.Scissor:
                    return (RoundInfo.ComputerChoice == enChoices.Paper) ? enWinner.Player : enWinner.Computer;
            }

            return enWinner.Draw;
        }

        void ShowResult(enWinner Winner)
        {
            switch(Winner)
            {
                case enWinner.Computer:
                    lblWinner.Text = "Computer wins!!";
                    GameFinalResult.ComputerWonTimes++;
                    break;

                case enWinner.Player:
                    lblWinner.Text = "You win!!";
                    GameFinalResult.Player1WonTimes++;
                    break;

                case enWinner.Draw:
                    lblWinner.Text = "It's a draw!!";
                    GameFinalResult.DrawTimes++;
                    break;

            }

           DialogResult Result = MessageBox.Show(lblWinner.Text, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);       

        }

        enWinner WhoFinalWinner()
        {
            if (GameFinalResult.Player1WonTimes == GameFinalResult.ComputerWonTimes)
                return GameFinalResult.WhoFinalWinner = enWinner.Draw;

            return (GameFinalResult.ComputerWonTimes > GameFinalResult.Player1WonTimes ? GameFinalResult.WhoFinalWinner = enWinner.Computer : GameFinalResult.WhoFinalWinner = enWinner.Player);
        }

        void NameFinalWinner()
        {
            switch(GameFinalResult.WhoFinalWinner)
            {
                case enWinner.Computer:
                    GameFinalResult.NameFinalWinner = "Computer";
                    break;
                case enWinner.Player:
                    GameFinalResult.NameFinalWinner = "Player";
                    break;
                case enWinner.Draw:
                    GameFinalResult.NameFinalWinner = "Draw";
                    break;
            }
        }
        void UpdateGameState(Button btn)
        {

            pictureBox1.BackgroundImage = btn.BackgroundImage;
            RoundInfo.PlayerChoice = (enChoices)Convert.ToInt16(btn.Tag.ToString()) - 1;
            lblYourChoice.Text = arrChoices[Convert.ToInt16(btn.Tag.ToString()) - 1];
            lblTurn.Text = "Computer";
            int rnd = GenerateRandomNumber();
            RoundInfo.ComputerChoice = (enChoices)(rnd - 1);
            pictureBox2.BackgroundImage = (rnd == 1 ? Properties.Resources.fist : (rnd == 2 ? Properties.Resources.Paper : Properties.Resources.Scissor));
            lblComputerChoice.Text = arrChoices[rnd - 1];
            ShowResult(WhoWin());

            if (RoundInfo.NumberOfRounds < GameFinalResult.GameRounds)
            {
                RoundInfo.NumberOfRounds++;
                lblComputerChoice.Text = "";
                lblWinner.Text = "";
                lblYourChoice.Text = "";
                lblRound.Text = "Round " + RoundInfo.NumberOfRounds.ToString();
                lblTurn.Text = "Player";
                pictureBox1.BackgroundImage = null;
                pictureBox2.BackgroundImage = null;
            }
            else
            {
                MessageBox.Show("The number of rounds have finished!!");
                WhoFinalWinner();
                NameFinalWinner();

                frmRockPaperScissorGameResult frm = new frmRockPaperScissorGameResult(GameFinalResult.GameRounds,
                    GameFinalResult.Player1WonTimes, GameFinalResult.ComputerWonTimes, GameFinalResult.DrawTimes,
                    GameFinalResult.NameFinalWinner);
                frm.ShowDialog();
                this.Close();
            }

        }
        private void btnRock_Click(object sender, EventArgs e)
        {
            UpdateGameState(btnRock);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            UpdateGameState(btnPaper);
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            UpdateGameState(btnScissor);
        }

        
    }
}
