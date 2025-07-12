using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toc
{
    public partial class frmRockPaperScissorGameResult : Form
    {
        struct stGameFinalResult
        {
            public int GameRounds;
            public int Player1WonTimes;
            public int ComputerWonTimes;
            public int DrawTimes;
            public string FinalWinner;
        }

        stGameFinalResult _GameResult;
        public frmRockPaperScissorGameResult(int GameRounds, int Player1WonTimes,
            int ComputerWonTimes, int DrawTimes, string FinalWinner)
        {
            InitializeComponent();
            _GameResult.GameRounds = GameRounds;
            _GameResult.Player1WonTimes = Player1WonTimes;
            _GameResult.ComputerWonTimes = ComputerWonTimes;
            _GameResult.DrawTimes = DrawTimes;
            _GameResult.FinalWinner = FinalWinner;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to paly again?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (Result == DialogResult.OK)
            {
                frmRockPaperScissorsReq frm = new frmRockPaperScissorsReq();
                frm.Show();
                this.Close();
            }
        }

        void PrintResults()
        {
            lblNumberOfRounds.Text = _GameResult.GameRounds.ToString();
            lblPlayer1WonTimes.Text = _GameResult.Player1WonTimes.ToString();
            lblComputerWonTimes.Text = _GameResult.ComputerWonTimes.ToString();
            lblDrawTimes.Text = _GameResult.DrawTimes.ToString();
            lblFinalWinner.Text = _GameResult.FinalWinner.ToString();
        }
        private void frmRockPaperScissorGameResult_Load(object sender, EventArgs e)
        {
            lblComputerWonTimes.Text = "";
            lblDrawTimes.Text = "";
            lblFinalWinner.Text = "";
            lblNumberOfRounds.Text = "";
            lblPlayer1WonTimes.Text = "";

            PrintResults();

            
        }
    }
}
