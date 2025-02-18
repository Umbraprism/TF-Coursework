using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

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

        private async void AnswerIndicationScreen_Load(object sender, EventArgs e) // change to appropriate colours soon
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            lblIndicator.Width = this.Width / 2;
            lblIndicator.Height = this.Height / 2;

            lblScore.Width = this.Width / 2;
            lblScore.Height = this.Height / 2;

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
            }

            FormHelper.CurrentQuiz.Score += score;

            await Task.Delay(2000);

            try
            {
                FormHelper.CurrentQuiz.CurrentQuestionIndex++;
                Question question = FormHelper.CurrentQuiz.BaseQuestions[FormHelper.CurrentQuiz.CurrentQuestionIndex];

                switch (question.Type)
                {
                    case QuestionType.MultipleChoice:
                        new MultipleChoiceScreen(ref question).Show();
                        break;
                    case QuestionType.TrueFalse:
                        new TrueFalseScreen(ref question).Show();
                        break;
                    case QuestionType.DragDrop:
                        new DragDropScreen(ref question).Show();
                        break;
                    default:
                        throw new FormatException("Question is not of a valid type.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                FormHelper.MainMenuScreen.Show();;
                FormHelper.QuizPlayer.ScoresHashmap[FormHelper.CurrentQuiz.QuizType].HighestScore = FormHelper.CurrentQuiz.Score;
            }

            this.Close();
        }
    }
}
