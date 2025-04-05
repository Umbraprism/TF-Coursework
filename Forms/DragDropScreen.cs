using Coursework.Extensions;
using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class DragDropScreen : Form
    {
        #region Field declarations

        private Question question;
        private int score;

        #endregion

        #region Constructor

        public DragDropScreen(ref Question question)
        {
            InitializeComponent();
            this.question = question;
            this.Text = $"{Session.Quiz.Name} Quiz";
            score = Session.Quiz.Score;
        }

        #endregion

        #region Event Handlers

        private void DragDropScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            lblQuizName.Text = $"{Session.Quiz.Name.ToUpper()} QUIZ";
            lblQuestionText.Text = question.Text;

            lblScore.Text = score.ToString();
            lblTimeRemaining.Text = TimeSpan.FromSeconds(Session.Quiz.TimeRemaining).ToString(@"m\:ss");

            pbImage.Tag = question.CorrectAnswerIndex;
            pbImage.AllowDrop = true;

            lblQuestionNumber.Text = $"{Session.Quiz.CurrentQuestionIndex + 1}/{Session.Quiz.BaseQuestions.Count}";

            ppbCharge.Value = (Session.Player.TFClass.Ability.ChargeLevel * 100) / Session.Player.TFClass.Ability.ChargesRequired;
            pbAbility.Image = TFClass.Assets[Session.Player.TFClass.Id].Emblem;

            tmrQuiz.Start();

            int i = 0;

            foreach (Label label in tlpAnswers.Controls)
            {
                label.AllowDrop = true;
                label.Text = question.Answers[i];
                i++;

                if (Session.Quiz.IsDisguised)
                {
                    label.ForeColor = UI.ColourPalette["Blue"];
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

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;

            lbl.DoDragDrop(lbl.Text, DragDropEffects.Copy);
        }

        private void image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void image_DragDrop(object sender, DragEventArgs e)
        {
            string? result = String.Empty;

            if (e.Data != null)
            {
                result = (string?)e.Data.GetData(DataFormats.Text);
            }

            if (result == question.Answers[question.CorrectAnswerIndex])
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

        #endregion
    }
}
