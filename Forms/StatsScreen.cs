using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class StatsScreen : Form
    {
        #region Constructor

        public StatsScreen()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void StatsScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            pbAvatar.Image = TFClass.Assets[Session.Player.TFClass.Id].Avatar;
            lblUsername.Text = Session.Player.Username;
            lblTFClass.Text = $"The {Session.Player.TFClass.Name}";
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

                lblHighestScore.Text = $"Highest Score - {Session.Player.ScoresHashmap[quizScore].HighestScore}";
                lblLatestScore.Text = $"Latest Score - {Session.Player.ScoresHashmap[quizScore].LatestScore}";

                lblQuizRank.Text = $"Latest Rank - {Session.Player.ScoresHashmap[quizScore].Rank}";
                lblQuizRank.ForeColor = UI.ColourPalette[lblQuizRank.Text.Replace("Latest Rank - ", String.Empty)];

                pnlGuessingGame.Visible = false;
                pnlQuizStats.Visible = true;
            }
            else
            {
                lblLowestGuesses.Text = $"Lowest Guesses - {Session.Player.ScoresHashmap[quizScore].LowestGuessAmount}";
                lblLatestGuesses.Text = $"Latest Guesses - {Session.Player.ScoresHashmap[quizScore].LatestGuessAmount}";
                lblHighestStreak.Text = $"Highest Streak - {Session.Player.ScoresHashmap[quizScore].HighestStreak}";
                lblCurrentStreak.Text = $"Current Streak - {Session.Player.ScoresHashmap[quizScore].CurrentStreak}";

                pnlGuessingGame.Visible = true;
                pnlQuizStats.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenuScreen().Show();
        }

        private void btnAbilityInfo_Click(object sender, EventArgs e)
        {
            TFMessageBox.Show($"{Session.Player.TFClass.Ability.Name}\n\n{Session.Player.TFClass.Ability.Info}\n\nCharges Required - {Session.Player.TFClass.Ability.ChargesRequired}", "Ability Info");
        }

        #endregion
    }
}
