using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class StatsScreen : Form
    {
        public StatsScreen()
        {
            InitializeComponent();
        }

        private void StatsScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            pbAvatar.Image = TFClass.Assets[PlayerHelper.QuizPlayer.TFClass.Id].Avatar;
            lblUsername.Text = PlayerHelper.QuizPlayer.Username;
            lblTFClass.Text = $"The {PlayerHelper.QuizPlayer.TFClass.Name}";
            lblOnlineRank.Text = PlayerHelper.QuizPlayer.OnlineRank;
            lblOnlineRank.ForeColor = FormHelper.ColourPalette[lblOnlineRank.Text];
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.LeaderboardScreen.Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            QuizScores quizScore = (QuizScores)Enum.Parse(typeof(QuizScores), btn.Tag.ToString());

            if (quizScore != QuizScores.GuessingGame)
            {
                lblQuizType.Text = $"{btn.Text.ToUpper()} QUIZ";

                lblHighestScore.Text = $"Highest Score - {PlayerHelper.QuizPlayer.ScoresHashmap[quizScore].HighestScore}";
                lblLatestScore.Text = $"Highest Score - {PlayerHelper.QuizPlayer.ScoresHashmap[quizScore].LatestScore}";

                lblQuizRank.Text = $"{PlayerHelper.QuizPlayer.ScoresHashmap[quizScore].Rank}";
                lblQuizRank.ForeColor = FormHelper.ColourPalette[lblQuizRank.Text];

                pnlGuessingGame.Visible = false;
                pnlQuizStats.Visible = true;
            }
            else
            {
                lblLowestGuesses.Text = $"Lowest Guesses = {PlayerHelper.QuizPlayer.ScoresHashmap[quizScore].LowestGuessAmount}";
                lblLatestGuesses.Text = $"Latest Guesses = {PlayerHelper.QuizPlayer.ScoresHashmap[quizScore].LatestGuessAmount}";
                lblHighestStreak.Text = $"Highest Streak = {PlayerHelper.QuizPlayer.ScoresHashmap[quizScore].HighestStreak}";
                lblCurrentStreak.Text = $"Current Streak = {PlayerHelper.QuizPlayer.ScoresHashmap[quizScore].CurrentStreak}";

                pnlQuizStats.Visible = false;
                pnlGuessingGame.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.MainMenuScreen.Show();
        }
    }
}
