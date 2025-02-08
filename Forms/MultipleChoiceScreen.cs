using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class MultipleChoiceScreen : Form
    {
        public Question question;
        private int score;

        public MultipleChoiceScreen(ref Question question)
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
            FormHelper.s_quizPlayer.TFClass.TFClassAbility.UseAbility(this, ref FormHelper.s_currentQuiz, ref question);

            if (question.isCorrect)
            {
                int scoreAddition = FormHelper.s_currentQuiz.scoreMultiplier != 0 ? 20 * FormHelper.s_currentQuiz.scoreMultiplier : 20;

                score += scoreAddition;

                question.isCorrect = true;

                new AnswerIndicationScreen(scoreAddition).Show();
                this.Hide();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (UInt32.Parse(btn.Tag.ToString()) == question.CorrectAnswerIndex)
            {
                int scoreAddition = FormHelper.s_currentQuiz.scoreMultiplier != 0 ? 20 * FormHelper.s_currentQuiz.scoreMultiplier : 20;

                score += scoreAddition;

                question.isCorrect = true;

                new AnswerIndicationScreen(scoreAddition).Show();
                this.Close();
            }
            else
            {
                if (FormHelper.s_quizPlayer.TFClass.Id == 4)
                {
                    FormHelper.s_currentQuiz.scoreMultiplier = 0;
                }

                FormHelper.s_currentQuiz.isDisguised = false;

                new AnswerIndicationScreen(0).Show();
                this.Close();
            }
        }
    }
}
