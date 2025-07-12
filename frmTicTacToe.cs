using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toc
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }

        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }


        struct stGameStatue
        {
            public enWinner Winner;
            public bool GameOver;
            public int Counter;
        }

        stGameStatue GameStatue;
        enPlayer PlayerTurn;
        void ChangeImage(Button btn)
        {
            if (GameStatue.GameOver)
                return;

            btn.Text = "";
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.BackgroundImage = Properties.Resources.xx_pic;
                        lblPlayer.Text = "Player2";
                        btn.Tag = "x";
                        PlayerTurn = enPlayer.Player2;
                        break;
                    case enPlayer.Player2:
                        btn.BackgroundImage = Properties.Resources.oo_pic;
                        lblPlayer.Text = "Player1";
                        btn.Tag = "y";
                        PlayerTurn = enPlayer.Player1;
                        break;
                }
                GameStatue.Counter++;
             
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "x")
                {
                    GameStatue.Winner = enWinner.Player1;
                    lblWinner.Text = "Player1";
                }
                else
                {
                    GameStatue.Winner = enWinner.Player2;
                    lblWinner.Text = "Player2";
                }
                GameStatue.GameOver = true;
                MessageBox.Show("Game Over", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }

        void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;
            if (CheckValues(button4, button5, button6))
                return;
            if (CheckValues(button7, button8, button9))
                return;
            if (CheckValues(button1, button4, button7))
                return;
            if (CheckValues(button2, button5, button8))
                return;
            if (CheckValues(button3, button6, button9))
                return;
            if (CheckValues(button1, button5, button9))
                return;
            if (CheckValues(button3, button5, button7))
                return;

            if(GameStatue.Counter == 9)
            {
                GameStatue.Winner = enWinner.Draw;
                lblWinner.Text = "Draw";
                MessageBox.Show("Game Over", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {

            ChangeImage((Button)sender);
            CheckWinner();
        }

        void ResetButton(Button btn)
        {
            btn.BackgroundImage = Properties.Resources.Question;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            GameStatue.GameOver = false;
            GameStatue.Counter = 0;
            lblPlayer.Text = "Player1";
            lblWinner.Text = "In Progress";
            PlayerTurn = enPlayer.Player1;
            GameStatue.Winner = enWinner.GameInProgress;
        }
    }
}
