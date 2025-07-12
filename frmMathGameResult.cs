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
    public partial class frmMathGameResult : Form
    {
        public frmMathGameResult(int NumberOfQuestions, int NumberOfRightAnswers,
            int NumberOfWrongAnswers, string QuestionsLevel, string OpType)
        {
            InitializeComponent();

            lblQuestionsLevelText.Text = "Questions Leve: ";
            lblOpTypeText.Text = "Operation Type: ";
            lblNumberOfQuestionsText.Text = "Number Of Questions: ";
            lblNumberOfRightAnswersText.Text = "Number Of Right Questions: ";
            lblNumberOfWrongAnswersText.Text = "Number Of Wrong Questions: ";

            lblQuestionsLevel.Text       =  QuestionsLevel;
            lblOpType.Text               =  OpType;
            lblNumberOfQuestions.Text    =  NumberOfQuestions.ToString();
            lblNumberOfRightAnswers.Text =  NumberOfRightAnswers.ToString();
            lblNumberOfWrongAnswers.Text =  NumberOfWrongAnswers.ToString();
        }

        private void frmMathGameResult_Load(object sender, EventArgs e)
        {

        }
    }
}
