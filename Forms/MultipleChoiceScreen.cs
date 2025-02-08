using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class MultipleChoiceScreen : Form
    {
        private Question question;
        public int score;

        public MultipleChoiceScreen(Question question)
        {
            InitializeComponent();
            this.question = question;
            this.Text = $"{FormHelper.s_currentQuiz.Name} Quiz";
        }

        private void MultipleChoiceScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            lblQuestionText.Text = question.Text;

            //lblQuestionText.Left = (this.Width / 2 - (TextRenderer.MeasureText(lblQuestionText.Text, lblQuestionText.Font).Width / 2));

            int i = 0;

            foreach (Button button in this.tlpAnswers.Controls)
            {
                button.Text = question.Answers[i];
                i++;

                if (FormHelper.s_currentQuiz.isDisguised)
                {
                    button.BackColor = FormHelper.s_ColourHashmap["Blue"];
                }
            }

            lblScore.Text = score.ToString();
            pbAbility.Image = TFClass.assetsHashmap[FormHelper.s_quizPlayer.TFClass.Id].Item1;
        }

        private void pbAbility_Click(object sender, EventArgs e)
        {
            FormHelper.s_quizPlayer.TFClass.TFClassAbility.UseAbility(FormHelper.s_currentQuiz);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            uint test = UInt32.Parse(btn.Tag.ToString());

            if (UInt32.Parse(btn.Tag.ToString()) == question.CorrectAnswerIndex)
            {
                TFMessageBox.Show("you right!", "W");

                int scoreAddition = FormHelper.s_currentQuiz.scoreMultiplier != 0 ? 20 * FormHelper.s_currentQuiz.scoreMultiplier : 20;

                score += scoreAddition;

                if (FormHelper.s_currentQuiz.currentQuestionIndex != FormHelper.s_currentQuiz.currentDifficulty.Count - 1)
                {
                    new AnswerIndicationScreen(scoreAddition).Show();
                    this.Hide();
                }
                else
                {
                    TFMessageBox.Show("you have been tuaght face to face", "freakin packet yo");
                }
            }
            else
            {
                if (FormHelper.s_quizPlayer.TFClass.Id == 4)
                {
                    FormHelper.s_currentQuiz.scoreMultiplier = 0;
                }

                FormHelper.s_currentQuiz.isDisguised = false;

                TFMessageBox.Show("you wrong", "L");

                if (FormHelper.s_currentQuiz.currentQuestionIndex != FormHelper.s_currentQuiz.currentDifficulty.Count)
                {
                    new AnswerIndicationScreen(0).Show();
                    this.Hide();
                }
                else
                {
                    TFMessageBox.Show("you have been tuaght face to face", "freakin packet yo");
                }
            }
        }
    }
}
