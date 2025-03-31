using Coursework.Extensions;
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
            this.Text = $"{Session.Quiz.Name} Quiz";
            score = Session.Quiz.Score;
        }

        private void TrueFalseScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            lblQuizName.Text = $"{Session.Quiz.Name.ToUpper()} QUIZ";
            lblQuestionText.Text = question.Text;

            lblScore.Text = score.ToString();
            lblTimeRemaining.Text = TimeSpan.FromSeconds(Session.Quiz.TimeRemaining).ToString(@"m\:ss");

            tmrQuiz.Start();

            lblQuestionNumber.Text = $"{Session.Quiz.CurrentQuestionIndex + 1}/{Session.Quiz.BaseQuestions.Count}";

            ppbCharge.Value = (Session.Player.TFClass.Ability.ChargeLevel * 100) / Session.Player.TFClass.Ability.ChargesRequired;
            pbAbility.Image = TFClass.Assets[Session.Player.TFClass.Id].Portrait;

            if (ppbCharge.Value != 100 && pbAbility.Image != null)
            {
                Bitmap destaurated = (Bitmap)pbAbility.Image;

                pbAbility.Image = destaurated.Desaturate();
            }

            int i = 0;

            foreach (Button button in this.tlpAnswers.Controls)
            {
                button.Text = question.Answers[i];
                i++;

                if (Session.Quiz.IsDisguised)
                {
                    button.BackColor = UI.ColourPalette["Blue"];
                }
            }

            lblScore.Text = score.ToString();
        }

        private void pbAbility_Click(object sender, EventArgs e)
        {
            Session.Player.TFClass.Ability.UseAbility(this, ref Session.Quiz, ref question);

            if (question.IsCorrect)
            {
                double scoreAddition = Session.Quiz.ScoreMultiplier != 0 ? 20 * Session.Quiz.ScoreMultiplier : 20;

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
                double scoreAddition = Session.Quiz.ScoreMultiplier != 0 ? 20 * Session.Quiz.ScoreMultiplier : 20;

                score += (int)scoreAddition;
                question.IsCorrect = true;
                question.IsAnswered = true;

                new AnswerIndicationScreen((int)scoreAddition).Show();
                this.Close();
            }
            else
            {
                if (Session.Player.TFClass.Id == 4)
                {
                    Session.Quiz.ScoreMultiplier = 0;
                }

                Session.Quiz.IsDisguised = false;

                question.IsAnswered = true;

                new AnswerIndicationScreen(0).Show();
                this.Close();
            }
        }

        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            Session.Quiz.TimeRemaining--;
            lblTimeRemaining.Text = TimeSpan.FromSeconds(Session.Quiz.TimeRemaining).ToString(@"m\:ss");

            if (Session.Quiz.TimeRemaining <= 0)
            {
                tmrQuiz.Stop();
                new EndScreen().Show();
                this.Close();
            }
        }
    }
}
