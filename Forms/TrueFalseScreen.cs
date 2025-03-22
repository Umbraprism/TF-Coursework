using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class TrueFalseScreen : Form
    {
        private Question question;
        private int score;

        public TrueFalseScreen(ref Question question)
        {
            InitializeComponent();
            this.question = question;
            this.Text = $"{FormHelper.Quiz.Name} Quiz";
            score = FormHelper.Quiz.Score;
        }

        private void TrueFalseScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            lblQuizName.Text = $"{FormHelper.Quiz.Name.ToUpper()} QUIZ";
            lblQuestionText.Text = question.Text;

            lblScore.Text = score.ToString();
            lblTimeRemaining.Text = TimeSpan.FromSeconds(FormHelper.Quiz.TimeRemaining).ToString(@"m\:ss");

            tmrQuiz.Start();

            lblQuestionNumber.Text = $"{FormHelper.Quiz.CurrentQuestionIndex + 1}/{FormHelper.Quiz.BaseQuestions.Count}";

            ppbCharge.Value = (PlayerHelper.Player.TFClass.Ability.ChargeLevel * 100) / PlayerHelper.Player.TFClass.Ability.ChargesRequired;

            int i = 0;

            foreach (Button button in this.tlpAnswers.Controls)
            {
                button.Text = question.Answers[i];
                i++;

                if (FormHelper.Quiz.IsDisguised)
                {
                    button.BackColor = FormHelper.ColourPalette["Blue"];
                }
            }

            lblScore.Text = score.ToString();
            pbAbility.Image = TFClass.Assets[PlayerHelper.Player.TFClass.Id].Emblem;
        }

        private void pbAbility_Click(object sender, EventArgs e)
        {
            PlayerHelper.Player.TFClass.Ability.UseAbility(this, ref FormHelper.Quiz, ref question);

            if (question.IsCorrect)
            {
                double scoreAddition = FormHelper.Quiz.ScoreMultiplier != 0 ? 20 * FormHelper.Quiz.ScoreMultiplier : 20;

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
                double scoreAddition = FormHelper.Quiz.ScoreMultiplier != 0 ? 20 * FormHelper.Quiz.ScoreMultiplier : 20;

                score += (int)scoreAddition;
                question.IsCorrect = true;
                question.IsAnswered = true;

                new AnswerIndicationScreen((int)scoreAddition).Show();
                this.Close();
            }
            else
            {
                if (PlayerHelper.Player.TFClass.Id == 4)
                {
                    FormHelper.Quiz.ScoreMultiplier = 0;
                }

                FormHelper.Quiz.IsDisguised = false;

                question.IsAnswered = true;

                new AnswerIndicationScreen(0).Show();
                this.Close();
            }
        }

        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            FormHelper.Quiz.TimeRemaining--;
            lblTimeRemaining.Text = TimeSpan.FromSeconds(FormHelper.Quiz.TimeRemaining).ToString(@"m\:ss");

            if (FormHelper.Quiz.TimeRemaining <= 0)
            {
                tmrQuiz.Stop();
                new EndScreen().Show();
                this.Close();
            }
        }
    }
}
