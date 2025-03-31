using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class AnswerIndicationScreen : Form
    {
        #region Field declarations

        private int score;

        #endregion

        #region Constructor

        public AnswerIndicationScreen(int score)
        {
            this.score = score;
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private async void AnswerIndicationScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            Question previousQuestion = Session.Quiz.BaseQuestions[Session.Quiz.CurrentQuestionIndex];

            lblIndicator.Width = this.Width / 2;
            lblIndicator.Height = this.Height / 2;

            lblScore.Width = this.Width / 2;
            lblScore.Height = this.Height / 2;

            if (Session.Player.TFClass.Ability.ChargeLevel < Session.Player.TFClass.Ability.ChargesRequired)
            {
                Session.Player.TFClass.Ability.ChargeLevel++;
            }

            if (score > 0)
            {
                lblIndicator.Text = "CORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = UI.ColourPalette["Green"];
            }
            else
            {
                lblIndicator.Text = "INCORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = UI.ColourPalette["Red"];

                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.Text = $"Correct Answer - {previousQuestion.Answers[previousQuestion.CorrectAnswerIndex]}";
            }

            Session.Quiz.Score += score;

            await Task.Delay(2000);

            try
            {
                Session.Quiz.CurrentQuestionIndex++;

                Question nextQuestion = Session.Quiz.BaseQuestions[Session.Quiz.CurrentQuestionIndex];

                switch (nextQuestion.Type)
                {
                    case QuestionType.MultipleChoice:
                        new MultipleChoiceScreen(ref nextQuestion).Show();
                        break;
                    case QuestionType.TrueFalse:
                        new TrueFalseScreen(ref nextQuestion).Show();
                        break;
                    case QuestionType.DragDrop:
                        new DragDropScreen(ref nextQuestion).Show();
                        break;
                    case QuestionType.GapFill:
                        new GapFillScreen(ref nextQuestion).Show();
                        break;
                    default:
                        throw new FormatException("Question is not of a valid type.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                new EndScreen().Show();
                this.Close();
            }

            this.Close();
        }

        #endregion
    }
}
