using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;
using static System.Net.Mime.MediaTypeNames;

namespace Coursework.Forms
{
    public partial class AnswerIndicationScreen : Form
    {
        private int score;

        public AnswerIndicationScreen(int score)
        {
            this.score = score;
            InitializeComponent();
        }

        private async void AnswerIndicationScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            Question previousQuestion = FormHelper.Quiz.BaseQuestions[FormHelper.Quiz.CurrentQuestionIndex];

            lblIndicator.Width = this.Width / 2;
            lblIndicator.Height = this.Height / 2;

            lblScore.Width = this.Width / 2;
            lblScore.Height = this.Height / 2;

            if (PlayerHelper.Player.TFClass.Ability.ChargeLevel < PlayerHelper.Player.TFClass.Ability.ChargesRequired)
            {
                PlayerHelper.Player.TFClass.Ability.ChargeLevel++;
            }

            if (score > 0)
            {
                lblIndicator.Text = "CORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = FormHelper.ColourPalette["Green"];
            }
            else
            {
                lblIndicator.Text = "INCORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = FormHelper.ColourPalette["Red"];

                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.Text = $"Correct Answer - {previousQuestion.Answers[previousQuestion.CorrectAnswerIndex]}";
            }

            FormHelper.Quiz.Score += score;

            await Task.Delay(2000);

            try
            {
                FormHelper.Quiz.CurrentQuestionIndex++;

                Question nextQuestion = FormHelper.Quiz.BaseQuestions[FormHelper.Quiz.CurrentQuestionIndex];

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
    }
}
