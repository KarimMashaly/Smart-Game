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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTicTacToe frm = new frmTicTacToe();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRockPaperScissorsReq frm = new frmRockPaperScissorsReq();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMathGameReq frm = new frmMathGameReq();
            frm.Show();
        }
    }
}
