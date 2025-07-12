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
    public partial class frmRockPaperScissorsReq : Form
    {
        public frmRockPaperScissorsReq()
        {
            InitializeComponent();
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {

            if(NUDNumberOfRounds.Value == 0)
            {
                MessageBox.Show("You should select number of rounds!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmRockPaperScissorsGame frm = new frmRockPaperScissorsGame((int)NUDNumberOfRounds.Value);
            frm.Show();
            this.Close();
        }
    }
}
