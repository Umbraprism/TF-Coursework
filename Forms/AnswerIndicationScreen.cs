using Coursework.Helpers;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class AnswerIndicationScreen : Form
    {
        private int score;
        private int sleepTime = 0;

        public AnswerIndicationScreen(int score)
        {
            this.score = score;
            InitializeComponent();
        }

        private async void AnswerIndicationScreen_Load(object sender, EventArgs e) // change to appropriate colours soon
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
                lblScore.ForeColor = FormHelper.s_ColourHashmap["Green"];
            }
            else
            {
                lblIndicator.Text = "INCORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = FormHelper.s_ColourHashmap["Red"];
            }

            await Task.Delay(2000);

            try
            {
                FormHelper.s_currentQuiz.currentQuestionIndex++;
                FormHelper.s_currentQuiz.currentDifficulty[FormHelper.s_currentQuiz.currentQuestionIndex].Show();
            }
            catch (Exception ex)
            {
                TFMessageBox.Show($"{ex.Message}{Environment.NewLine}you #win you must've been taught face to face instead of being handed a #freakinpacketyo", "end");
            }

            Close();
        }
    }
}
