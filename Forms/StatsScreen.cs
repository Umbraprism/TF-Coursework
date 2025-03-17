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

            pbAvatar.Image = TFClass.Assets[PlayerHelper.Player.TFClass.Id].Avatar;
            lblUsername.Text = PlayerHelper.Player.Username;
            lblTFClass.Text = $"The {PlayerHelper.Player.TFClass.Name}";
            lblOnlineRank.Text = PlayerHelper.Player.OnlineRank;
            lblOnlineRank.ForeColor = FormHelper.ColourPalette[lblOnlineRank.Text];
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            this.Close();
            new LeaderboardScreen().Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            QuizScores quizScore = (QuizScores)Enum.Parse(typeof(QuizScores), btn.Tag.ToString());

            if (quizScore != QuizScores.GuessingGame)
            {
                lblQuizType.Text = $"{btn.Text.ToUpper()} QUIZ";

                lblHighestScore.Text = $"Highest Score - {PlayerHelper.Player.ScoresHashmap[quizScore].HighestScore}";
                lblLatestScore.Text = $"Latest Score - {PlayerHelper.Player.ScoresHashmap[quizScore].LatestScore}";

                lblQuizRank.Text = $"Latest Rank - {PlayerHelper.Player.ScoresHashmap[quizScore].Rank}";
                lblQuizRank.ForeColor = FormHelper.ColourPalette[lblQuizRank.Text.Replace("Latest Rank - ", String.Empty)];

                pnlGuessingGame.Visible = false;
                pnlQuizStats.Visible = true;
            }
            else
            {
                lblLowestGuesses.Text = $"Lowest Guesses - {PlayerHelper.Player.ScoresHashmap[quizScore].LowestGuessAmount}";
                lblLatestGuesses.Text = $"Latest Guesses - {PlayerHelper.Player.ScoresHashmap[quizScore].LatestGuessAmount}";
                lblHighestStreak.Text = $"Highest Streak - {PlayerHelper.Player.ScoresHashmap[quizScore].HighestStreak}";
                lblCurrentStreak.Text = $"Current Streak - {PlayerHelper.Player.ScoresHashmap[quizScore].CurrentStreak}";

                pnlGuessingGame.Visible = true;
                pnlQuizStats.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenuScreen().Show();
        }
    }
}
