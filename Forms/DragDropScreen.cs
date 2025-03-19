using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class DragDropScreen : Form
    {
        private Question question;
        private int score;

        public DragDropScreen(ref Question question)
        {
            InitializeComponent();
            this.question = question;
            this.Text = $"{FormHelper.Quiz.Name} Quiz";
            score = FormHelper.Quiz.Score;
        }

        private void DragDropScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            lblQuizName.Text = $"{FormHelper.Quiz.Name.ToUpper()} QUIZ";
            lblQuestionText.Text = question.Text;

            lblScore.Text = score.ToString();
            lblTimeRemaining.Text = TimeSpan.FromSeconds(FormHelper.Quiz.TimeRemaining).ToString(@"m\:ss");

            pbImage.Tag = question.CorrectAnswerIndex;
            pbImage.AllowDrop = true;

            tmrQuiz.Start();

            int i = 0;

            foreach (Label label in tlpAnswers.Controls)
            {
                label.AllowDrop = true;
                label.Text = question.Answers[i];
                i++;

                if (FormHelper.Quiz.IsDisguised)
                {
                    label.ForeColor = FormHelper.ColourPalette["Blue"];
                }
            }

            lblScore.Text = score.ToString();
            pbAbility.Image = TFClass.Assets[PlayerHelper.Player.TFClass.Id].Emblem;
        }

        private void pbAbility_Click(object sender, EventArgs e)
        {
            PlayerHelper.Player.TFClass.TFClassAbility.UseAbility(this, ref FormHelper.Quiz, ref question);

            if (question.IsCorrect)
            {
                double scoreAddition = FormHelper.Quiz.ScoreMultiplier != 0 ? 20 * FormHelper.Quiz.ScoreMultiplier : 20;

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
