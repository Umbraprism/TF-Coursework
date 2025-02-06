using Coursework.ParentClasses;
using Coursework.Helpers;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class MainMenuScreen : Form
    {
        private Random rnd = new();

        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void MainMenuScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            pbPfp.Image = TFClass.assetsHashmap[FormHelper.s_quizPlayer.TFClass.Id].Item1;
            lblUsername.Text = FormHelper.s_quizPlayer.Username;
            lblAchievementCount.Text = $"{FormHelper.s_quizPlayer.Achievements.Count(achievement => achievement.IsAchieved)} Achievements";
            lblHighestScore.Text = $"Highest Score - {FormHelper.s_quizPlayer.GetHighestScore()}";
            lblClass.Text = $"The {FormHelper.s_quizPlayer.TFClass.Name}";

            lblTipText.Text = FormHelper.s_tips[rnd.Next(0, FormHelper.s_tips.Length - 1)].Text;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult quitQuery = TFMessageBox.Show("Are you sure you would like to quit?", "Quit", TFMessageBoxButtons.YesAndNo);

            if (quitQuery == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNextTip_Click(object sender, EventArgs e)
        {
            if (lblTipText.Text == FormHelper.s_tips[rnd.Next(0, FormHelper.s_tips.Length - 1)].Text)
            {
                btnNextTip_Click(sender, e);
            }
            else
            {
                lblTipText.Text = FormHelper.s_tips[rnd.Next(0, FormHelper.s_tips.Length - 1)].Text;
            }
        }

        private void btnWeaponsQuiz_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnTFClassQuiz_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnHistoryQuiz_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGuessingGame_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.s_achievementsScreen.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.s_leaderboardScreen.Show();
        }
    }
}
