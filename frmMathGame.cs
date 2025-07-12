using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tic_Tac_Toc
{
    public partial class frmMathGame : Form
    {
        public enum enLevel
        {
            Easy,
            Med,
            Hard,
            Mix
        }

        public enum enOpType
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Mix
        }

        struct stQuestion
        {
            public int Num1;
            public int Num2;
            public char OpType;
            public enLevel QuestionLevel;
            public enOpType QuestionOpType;
            public int RightAnswer;
            public stTimer Timer;
        }

        struct stQuestions
        {
            public int NumberOfQuestions;
            public List<stQuestion> ListQuestions;
            public enLevel Level;
            public enOpType OpType;
        }

        struct stGameResult
        {
            public int NumberOfRightAnswers;
            public int NumberOfWrongAnswers;
        }

        struct stTimer
        {
            public int NumberOfSeconds;
            public int NumberOfMinutes;
            public int NumberOfHours;
        }

        stQuestion _Question = new stQuestion();
        stQuestions _Questions = new stQuestions();
        stGameResult _GameResult = new stGameResult();

        static Random _rnd = new Random();
        int _CurrentQuestionIndex = 0;

        bool _HaveTimer;

        int GenerateRandomNumber(int Min, int Max)
        {
            return _rnd.Next(Min, Max);
        }

        public frmMathGame(int NumberOfQuestions, int IndexLevel, int IndexOpType, bool HaveTimer)
        {
            InitializeComponent();
            _Questions.NumberOfQuestions = NumberOfQuestions;
            _Questions.ListQuestions = new List<stQuestion>();
            _Questions.Level = (enLevel)IndexLevel;
            _Questions.OpType = (enOpType)IndexOpType;
            _Question.QuestionLevel = (enLevel)IndexLevel;
            _Question.QuestionOpType = (enOpType)IndexOpType;
            _HaveTimer = HaveTimer;


        }

        enOpType GetOpType()
        {
            if (_Questions.OpType == enOpType.Mix)
                return _Question.QuestionOpType = (enOpType)GenerateRandomNumber(0, 4);

            return _Questions.OpType;
        }

        char GetOpTypeSymbol()
        {
            switch (_Question.QuestionOpType)
            {
                case enOpType.Addition:
                    return '+';

                case enOpType.Subtraction:
                    return '-';

                case enOpType.Multiplication:
                    return '*';

                case enOpType.Division:
                    return '/';

                default:
                    return '+';
            }
        }

        (int Result, int Num1, int Num2) GetNumbersForDivision( int Min, int Max)
        {
            /*
                  I created this function because I made this game for children,
                  and I wanted it to be simple and smart
            */

            int Result;
            int Num2;
            int Num1;

            // To get integral numbers
            // Result refers to 

            //Result = Num1/ Num2

            Result = GenerateRandomNumber(Min, Max); // refers to RightAnswer
            Num2 = GenerateRandomNumber(Min, Max); // refers to divisor
            Num1 = Result * Num2;            

            return (Result, Num1, Num2);
        }

        int GetNumbers( int Min, int Max)
        {
           return GenerateRandomNumber(Min, Max);
        }

        int SimpleCalculator(ref stQuestion que)
        {
            switch (que.QuestionOpType)
            {
                case enOpType.Addition:
                    return que.Num1 + que.Num2;

                case enOpType.Subtraction:
                    return que.Num1 - que.Num2;

                case enOpType.Multiplication:
                    return que.Num1 * que.Num2;

                default:
                    return que.Num1 + que.Num2;

            }
        }

        enLevel GetLevel()
        {
            if(_Questions.Level == enLevel.Mix)
                return (enLevel)_rnd.Next(0, 3);

            return _Questions.Level;
        }

        (int Min, int Max) GetRangeByLevel(enLevel Lev)
        {
            switch (Lev)
            {
                case enLevel.Easy:
                    return (1, 11);
                case enLevel .Med: 
                    return (20, 51);

                case enLevel .Hard:
                    return (50, 101);

                default:
                    return (1, 11);
            }
        }

        stQuestion GenerateQuestion()
        {
            stQuestion que = new stQuestion();
            que.QuestionOpType = GetOpType();
            que.OpType = GetOpTypeSymbol();
            que.QuestionLevel = GetLevel();
            (int Min,int  Max) = GetRangeByLevel(que.QuestionLevel);// Helper Function

            if (que.QuestionOpType == enOpType.Division && (que.QuestionLevel == enLevel.Med ||
                que.QuestionLevel == enLevel.Hard))// to get these numbers for only division operation, 
                // and i put the question level condition because if the question level is easy, the device may
                // lag or freeze and enter in infinite loop
                ( que.RightAnswer, que.Num1, que.Num2) =GetNumbersForDivision(Min , Max);
            else
            {
                que.Num1 = GetNumbers( Min, Max);
                que.Num2 = GetNumbers( Min, Max);
                que.RightAnswer = SimpleCalculator(ref que);
            }

            que.Timer = GetQuestionTimer(que.QuestionLevel);

            return que;
        }

        void GenerateQuestions()
        {
            for (int i = 1; i <= _Questions.NumberOfQuestions; i++)
            {
                _Questions.ListQuestions.Add(GenerateQuestion());
            }
        }

        void SetAnswersInButtons()
        {

            HashSet<int> answers = new HashSet<int>();// To prevent repetition of the same value
            answers.Add(_Question.RightAnswer);

            while (answers.Count < 4)
            {
                int rndOffset;
                int WrongAnswer;

                do
                {
                    rndOffset = _rnd.Next(-5, 6);
                    WrongAnswer = _Question.RightAnswer + rndOffset;
                } while (rndOffset == 0 || WrongAnswer < 0|| answers.Contains(WrongAnswer));

                answers.Add(WrongAnswer);

            }

            List<int> ShuffledAnswers = answers.OrderBy(x => _rnd.Next()).ToList(); // To randomly shuffle the answers


            btnAnswer1.Text = ShuffledAnswers[0].ToString();
            btnAnswer2.Text = ShuffledAnswers[1].ToString();
            btnAnswer3.Text = ShuffledAnswers[2].ToString();
            btnAnswer4.Text = ShuffledAnswers[3].ToString();

        }

        void GenerateAnswersInButtons()
        {
            int rndBtnToSetRightAnswer = GenerateRandomNumber(1, 5);

            switch (_Question.QuestionLevel)
            {
                case enLevel.Easy:
                    SetAnswersInButtons();
                    break;

                case enLevel.Med:
                    SetAnswersInButtons();
                    break;

                case enLevel.Hard:
                    SetAnswersInButtons();
                    break;

            }
        }

        stTimer GetQuestionTimer(enLevel Lev)
        {
            stTimer T = new stTimer();
            switch (Lev)
            {
                case enLevel.Easy:
                    T.NumberOfSeconds = 30;

                    break;

                case enLevel.Med:
                    T.NumberOfMinutes = 1;
                    break;

                case enLevel.Hard:
                    T.NumberOfSeconds = 30;
                    T.NumberOfMinutes = 1;
                    break;
            }

            return T;
        }

        void DisplayCurrentQuestion()
        {
            btnNextQuestion.Enabled = false;

            if (_CurrentQuestionIndex < _Questions.ListQuestions.Count())
            {
                lblNumberOfQuestion.Text = "Question [" + (_CurrentQuestionIndex + 1).ToString() + "/" + _Questions.NumberOfQuestions.ToString() + "]";
                _Question = _Questions.ListQuestions[_CurrentQuestionIndex];
                lblQuestion.Text = _Question.Num1.ToString() + Environment.NewLine;
                lblQuestion.Text += "                " + _Question.OpType + Environment.NewLine;
                lblQuestion.Text += _Question.Num2.ToString() ;
                lblQuestion.Text += Environment.NewLine + "__________________";

                GenerateAnswersInButtons();
            }
            else
            {
                MessageBox.Show("The Questions have finished!!", "Math Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMathGameResult frm = new frmMathGameResult(_Questions.NumberOfQuestions, _GameResult.NumberOfRightAnswers,
                    _GameResult.NumberOfWrongAnswers, _Questions.Level.ToString(), _Questions.OpType.ToString());
                frm.Show();
                this.Close();
            }

            lblTimer.ForeColor = Color.Black;
            lblTimer.Text = $"{_Question.Timer.NumberOfHours:D2} : {_Question.Timer.NumberOfMinutes:D2} : {_Question.Timer.NumberOfSeconds:D2}";
            if (_HaveTimer)
            {
                timer1.Enabled = true;
            }
        }

        void IfAnswerIsWrong()
        {
            _GameResult.NumberOfWrongAnswers++;

            foreach (Button btn in new[] { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 })
            {
                if (btn.Text == _Question.RightAnswer.ToString())
                {
                    btn.BackColor = Color.YellowGreen;
                    break;
                }
            }

            
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btnAnswer = (Button)sender;

            if (Convert.ToInt32(btnAnswer.Text) == _Question.RightAnswer)
            {
                btnAnswer.BackColor = Color.YellowGreen;

                _GameResult.NumberOfRightAnswers++;
            }
            else
            {
                btnAnswer.BackColor = Color.Red;

                IfAnswerIsWrong();
            }

            timer1.Enabled = false;
            btnNextQuestion.Enabled = true;
        }

        private void frmMathGame_Load(object sender, EventArgs e)
        {
            GenerateQuestions();
            DisplayCurrentQuestion();

            if (!_HaveTimer)
            {
                lblTimer.Visible = false;
                TImerLabel.Visible = false;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            foreach (Button btn in new[] { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 })
            {
                btn.BackColor = Color.PowderBlue;
            }

            _CurrentQuestionIndex++;
            DisplayCurrentQuestion();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TotalSeconds = _Question.Timer.NumberOfSeconds;
            TotalSeconds += _Question.Timer.NumberOfMinutes * 60;
            TotalSeconds += _Question.Timer.NumberOfHours * 60 * 60;

            if(TotalSeconds <= 0)
            {
                timer1.Enabled =false;
                IfAnswerIsWrong();
                btnNextQuestion.Enabled = true;
                return;
            }

            TotalSeconds--;

            _Question.Timer.NumberOfHours = TotalSeconds / 3600;
            _Question.Timer.NumberOfMinutes = (TotalSeconds % 3600) / 60;
            _Question.Timer.NumberOfSeconds = (TotalSeconds % 60);


            if (TotalSeconds <= 5)
            {
                lblTimer.ForeColor = Color.Red;
            }

            lblTimer.Text = $"{_Question.Timer.NumberOfHours:D2} : {_Question.Timer.NumberOfMinutes:D2} : {_Question.Timer.NumberOfSeconds:D2}";
 
        }
    }
}