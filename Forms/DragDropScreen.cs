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
            this.Text = $"{FormHelper.CurrentQuiz.Name} Quiz";
            score = FormHelper.CurrentQuiz.Score;
        }

        private void MultipleChoiceScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            lblQuizName.Text = $"{Text.ToUpper()} QUIZ";
            lblQuestionText.Text = question.Text;

            lblScore.Text = score.ToString();
            lblTimeRemaining.Text = FormHelper.CurrentQuiz.TimeRemaining.ToString();

            if (question.ImageId != 0)
            {
                pbImage.Image = question.IdToImage[question.ImageId];
            }

            pbImage.Tag = question.CorrectAnswerIndex;
            pbImage.AllowDrop = true;

            if (PlayerHelper.QuizPlayer.TFClass.TFClassAbility.ChargeLevel < PlayerHelper.QuizPlayer.TFClass.TFClassAbility.ChargesRequired)
            {
                pbAbility.Visible = false;
            }

            tmrQuiz.Start();

            int i = 0;

            foreach (Label label in tlpAnswers.Controls)
            {
                label.AllowDrop = true;
                label.Text = question.Answers[i];
                i++;

                if (FormHelper.CurrentQuiz.IsDisguised)
                {
                    label.ForeColor = FormHelper.ColourPalette["Blue"];
                }
            }

            lblScore.Text = score.ToString();
            pbAbility.Image = TFClass.Assets[PlayerHelper.QuizPlayer.TFClass.Id].Emblem;
        }

        private void pbAbility_Click(object sender, EventArgs e)
        {
            PlayerHelper.QuizPlayer.TFClass.TFClassAbility.UseAbility(this, ref FormHelper.CurrentQuiz, ref question);

            if (question.IsCorrect)
            {
                double scoreAddition = FormHelper.CurrentQuiz.ScoreMultiplier != 0 ? 20 * FormHelper.CurrentQuiz.ScoreMultiplier : 20;

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
            string result = String.Empty;

            if (e.Data != null)
            {
                result = (string)e.Data.GetData(DataFormats.Text);
            }

            if (result == question.Answers[question.CorrectAnswerIndex])
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
                if (PlayerHelper.QuizPlayer.TFClass.Id == 4)
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
