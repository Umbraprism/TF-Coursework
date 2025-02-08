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
                score += FormHelper.s_currentQuiz.scoreMultiplier != 0 ? 20 * FormHelper.s_currentQuiz.scoreMultiplier : 20;
                new AnswerIndicationScreen(score).Show();
                this.Close();
            }
            else
            {
                if (FormHelper.s_quizPlayer.TFClass.Id == 4)
                {
                    FormHelper.s_currentQuiz.scoreMultiplier = 0;
                }

                FormHelper.s_currentQuiz.isDisguised = false;

                TFMessageBox.Show("you wrong", "L");
                new AnswerIndicationScreen(score).Show();
                FormHelper.s_currentQuiz.currentDifficulty[FormHelper.s_currentQuiz.currentQuestionIndex].Show();
                this.Close();
            }
        }
    }
}
