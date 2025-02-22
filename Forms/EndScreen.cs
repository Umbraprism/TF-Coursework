using System.Data;
using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class EndScreen : Form
    {
        private int noCorrect = 0;
        private int noIncorrect = 0;
        private int noAnswered = 0;
        private int timeOnScreen = 10;

        private string rank = String.Empty;
        private int placement = 0;

        public EndScreen()
        {
            noCorrect = FormHelper.CurrentQuiz.BaseQuestions.Where(question => question.IsCorrect && question.IsAnswered).Count();
            noIncorrect = FormHelper.CurrentQuiz.EasyQuestions.Where(question => question.IsCorrect && question.IsAnswered).Count();
            noAnswered = FormHelper.CurrentQuiz.BaseQuestions.Where(question => question.IsAnswered == true).Count();

            rank = SetRank();
            placement = SetPlacement();
            InitializeComponent();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            lblUsername.Text = FormHelper.QuizPlayer.Username;

            lblCorrect.Text = noCorrect.ToString();
            lblIncorrect.Text = noIncorrect.ToString();
            lblScore.Text = $"Score - {FormHelper.CurrentQuiz.Score}";

            lblGrade.Text = rank.ToUpper();
            lblGrade.ForeColor = FormHelper.ColourPalette[rank];

            lblPlacement.Text = $"#{placement}";

            CheckAchievements();
        }

        private void tmrEnd_Tick(object sender, EventArgs e)
        {
            timeOnScreen--;

            if (timeOnScreen >= 0)
            {
                FormHelper.MainMenuScreen.Show();
                this.Close();
                tmrEnd.Stop();
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            FormHelper.CurrentQuiz = null;
            this.Close();
            FormHelper.MainMenuScreen.Show();
        }

        private string SetRank()
        {
            int percentage = noCorrect / noAnswered * 100;

            if (percentage == 100)
            {
                return "Unusual";
            }
            else if (percentage >= 80)
            {
                return "Strange";
            }
            else if (percentage >= 60)
            {
                return "Genuine";
            }
            else if (percentage >= 40)
            {
                return "Vintage";
            }
            else if (percentage >= 20)
            {
                return "Unique";
            }
            else if (percentage >= 10)
            {
                return "Basic";
            }
            else
            {
                return "Junk";
            }
        }

        private int SetPlacement()
        {
            List<Player> players = FormHelper.PlayerList;

            players.OrderBy(player => player.ScoresHashmap[FormHelper.CurrentQuiz.QuizType]);

            return players.IndexOf(FormHelper.QuizPlayer);
        }

        private void CheckAchievements()
        {
            if (((double)FormHelper.CurrentQuiz.TimeRemaining / (double)FormHelper.CurrentQuiz.TotalTime) * 100 >= 50)
            {
                UnlockAchievement("Race For The Pennant");
            }
            if (rank == "Unusual" && FormHelper.CurrentQuiz.QuizType == QuizScores.Weapons)
            {
                UnlockAchievement("Top Gun");
            }

        }

        private void UnlockAchievement(string name)
        {
            Achievement achievement = FormHelper.QuizPlayer.Achievements.Where(achievement => achievement.Name == name).First();

            if (!achievement.IsAchieved)
            {
                FormHelper.QuizPlayer.Achievements.Where(achievement => achievement.Name == name).First().IsAchieved = true;

                flpAchievementsUnlocked.Controls.Add(new AchievementView(achievement));
            }
        }
    }
}
