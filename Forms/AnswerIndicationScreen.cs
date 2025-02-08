using Coursework.Helpers;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class AnswerIndicationScreen : Form
    {
        private int score;

        public AnswerIndicationScreen(int score)
        {
            this.score = score;
            InitializeComponent();
        }

        private void AnswerIndicationScreen_Load(object sender, EventArgs e) // change to appropriate colours soon
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            lblIndicator.Width = this.Width / 2;
            lblIndicator.Height = this.Height / 2;

            lblScore.Width = this.Width / 2;
            lblScore.Height = this.Height / 2;
            
            if (score > 0)
            {
                lblIndicator.Text = "CORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = Color.FromArgb(1, 1, 1);
            }
            else
            {
                lblIndicator.Text = "INCORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = Color.FromArgb(0, 0, 0);
            }

            Task.Delay(2000);

            try
            {
                //FormHelper.s_currentQuiz.currentDifficulty.RemoveAt(FormHelper.s_currentQuiz.currentQuestionIndex);
                FormHelper.s_currentQuiz.currentQuestionIndex++;
                FormHelper.s_currentQuiz.currentDifficulty[FormHelper.s_currentQuiz.currentQuestionIndex].Show();
            }
            catch (Exception ex)
            {
                TFMessageBox.Show($"you #win you must've been taught face to face instead of being handed a #freakinpacketyo", "end");
            }

            this.Close();
        }
    }
}
