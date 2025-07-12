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
    public partial class frmMathGameReq : Form
    {
        public frmMathGameReq()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(NUDNumberOfQuestions.Value == 0)
            {
                MessageBox.Show("You should choose number of questions!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cbOperationType.SelectedIndex == 3 && cbQuestionsLevel.SelectedIndex == 0)
            {
                MessageBox.Show("You should choose another level or operation type because there is no division operations for easy levels :) !!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmMathGame frm = new frmMathGame((int)NUDNumberOfQuestions.Value, cbQuestionsLevel.SelectedIndex,
                cbOperationType.SelectedIndex, rbYes.Checked? true : false);
            frm.Show();
            this.Close();
        }

        private void frmMathGameReq_Load(object sender, EventArgs e)
        {
            cbOperationType.SelectedIndex = 0;
            cbQuestionsLevel.SelectedIndex = 0;
        }
    }
}
