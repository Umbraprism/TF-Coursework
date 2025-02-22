using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class MultipleChoiceScreen : Form
    {
        private Question question;
        private int score;

        public MultipleChoiceScreen(ref Question question)
        {
            InitializeComponent();
            this.question = question;
            this.Text = $"{FormHelper.CurrentQuiz.Name} Quiz";
            score = FormHelper.CurrentQuiz.Score;
        }

        private void MultipleChoiceScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            lblQuizName.Text = $"{FormHelper.CurrentQuiz.Name.ToUpper()} QUIZ";
            lblQuestionText.Text = question.Text;
            lblScore.Text = score.ToString();
            lblTimeRemaining.Text = FormHelper.CurrentQuiz.TimeRemaining.ToString();
            tmrQuiz.Start();

            int i = 0;

            foreach (Button button in this.tlpAnswers.Controls)
            {
                button.Text = question.Answers[i];
                i++;

                if (FormHelper.CurrentQuiz.IsDisguised)
                {
                    button.BackColor = FormHelper.ColourPalette["Blue"];
                }
            }

            lblScore.Text = score.ToString();
            pbAbility.Image = TFClass.Assets[FormHelper.QuizPlayer.TFClass.Id].Emblem;
        }

        private void pbAbility_Click(object sender, EventArgs e)
        {
            FormHelper.QuizPlayer.TFClass.TFClassAbility.UseAbility(this, ref FormHelper.CurrentQuiz, ref question);

            if (question.IsCorrect)
            {
                double scoreAddition = FormHelper.CurrentQuiz.ScoreMultiplier != 0 ? 20 * FormHelper.CurrentQuiz.ScoreMultiplier : 20;

                score += (int)scoreAddition;

                question.IsCorrect = true;

                new AnswerIndicationScreen((int)scoreAddition).Show();
                this.Close();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (UInt32.Parse(btn.Tag.ToString()) == question.CorrectAnswerIndex)
            {
                double scoreAddition = FormHelper.CurrentQuiz.ScoreMultiplier != 0 ? 20 * FormHelper.CurrentQuiz.ScoreMultiplier : 20;

                score += (int)scoreAddition;
                question.IsCorrect = true;
                question.IsAnswered = true;

                new AnswerIndicationScreen((int)scoreAddition).Show();
                this.Close();
            }
            else
            {
                if (FormHelper.QuizPlayer.TFClass.Id == 4)
                {
                    FormHelper.CurrentQuiz.ScoreMultiplier = 0;
                }

                FormHelper.CurrentQuiz.IsDisguised = false;

                question.IsAnswered = true;

                new AnswerIndicationScreen(0).Show();
                this.Close();
            }
        }

        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            FormHelper.CurrentQuiz.TimeRemaining--;
            lblTimeRemaining.Text = FormHelper.CurrentQuiz.TimeRemaining.ToString(); 

            if (FormHelper.CurrentQuiz.TimeRemaining <= 0)
            {
                tmrQuiz.Stop();
                new EndScreen().Show();
                this.Close();
            }
        }
    }
}
