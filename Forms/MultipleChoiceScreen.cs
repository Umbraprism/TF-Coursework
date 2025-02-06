using Coursework.Helpers;
using Coursework.ParentClasses;

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
        }

        private void MultipleChoiceScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            lblTipText.Left = (this.Width / 2 - (TextRenderer.MeasureText(lblTipText.Text, lblTipText.Font).Width / 2));
        }

        private void pbAbility_Click(object sender, EventArgs e)
        {
            FormHelper.s_quizPlayer.TFClass.TFClassAbility.UseAbility(FormHelper.s_currentQuiz);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (UInt32.Parse(btn.Tag.ToString()) == question.CorrectAnswerIndex)
            {
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

                new AnswerIndicationScreen(score).Show();
                this.Close();
            }
        }
    }
}
