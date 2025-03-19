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
        private int timeOnScreen = 10;

        private string Rank
        {
            get
            {
                double percentage = (noCorrect * 100) / FormHelper.Quiz.BaseQuestions.Count;

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
        }

        private int Placement
        {
            get
            {
                List<Player> players = PlayerHelper.PlayerList;

                players.OrderBy(player => player.ScoresHashmap[FormHelper.Quiz.QuizType].LatestScore);

                return players.IndexOf(PlayerHelper.Player) + 1;
            }
        }

        public EndScreen()
        {
            noCorrect = FormHelper.Quiz.BaseQuestions.Where(question => question.IsCorrect && question.IsAnswered).Count() + FormHelper.Quiz.EasyQuestions.Where(question => question.IsCorrect && question.IsAnswered).Count();
            noIncorrect = FormHelper.Quiz.BaseQuestions.Where(question => !question.IsCorrect && question.IsAnswered).Count() + FormHelper.Quiz.EasyQuestions.Where(question => !question.IsCorrect && question.IsAnswered).Count();
            InitializeComponent();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            CheckAchievements();

            if (FormHelper.Quiz.Score > PlayerHelper.Player.ScoresHashmap[FormHelper.Quiz.QuizType].HighestScore)
            {
                PlayerHelper.Player.ScoresHashmap[FormHelper.Quiz.QuizType].HighestScore = FormHelper.Quiz.Score;
            }

            PlayerHelper.Player.ScoresHashmap[FormHelper.Quiz.QuizType].LatestScore = FormHelper.Quiz.Score;

            PlayerHelper.Player.ScoresHashmap[FormHelper.Quiz.QuizType].Rank = Rank;

            lblUsername.Text = $"{PlayerHelper.Player.Username} wins!".ToUpper();
            lblCorrect.Text = $"{noCorrect} Correct";
            lblIncorrect.Text = $"{noIncorrect} Incorrect";
            lblScore.Text = $"Score - {FormHelper.Quiz.Score}";

            lblGrade.Text = Rank.ToUpper();
            lblGrade.ForeColor = FormHelper.ColourPalette[Rank];

            lblPlacement.Text = $"#{Placement}";
        }

        private void tmrEnd_Tick(object sender, EventArgs e)
        {
            timeOnScreen--;

            if (timeOnScreen >= 0)
            {
                new MainMenuScreen().Show();
                this.Close();
                tmrEnd.Stop();
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            FormHelper.Quiz = new();
            this.Close();
            new MainMenuScreen().Show();
        }

        private void CheckAchievements()
        {
            if (((double)FormHelper.Quiz.TimeRemaining / (double)FormHelper.Quiz.TotalTime) * 100 >= 50)
            {
                UnlockAchievement("Race For The Pennant");
            }
            if (((double)FormHelper.Quiz.TimeRemaining / (double)FormHelper.Quiz.TotalTime) * 100 >= 25)
            {
                UnlockAchievement("Charge n' Targe");
            }
            if (Rank == "Unusual" && FormHelper.Quiz.QuizType == QuizScores.Weapons)
            {
                UnlockAchievement("Top Gun");
            }
            if (Rank == "Unusual" && FormHelper.Quiz.QuizType == QuizScores.TFClass)
            {
                UnlockAchievement("Top of the Class");
            }
            if (Rank == "Unusual" && FormHelper.Quiz.QuizType == QuizScores.History)
            {
                UnlockAchievement("Time Machine");
            }
            if (PlayerHelper.Player.TFClass.TFClassAbility.TimesUsed == 0)
            {
                UnlockAchievement("Specialist");
            }
            if (PlayerHelper.Player.TFClass.Id == 9 && FormHelper.Quiz.IsDisguised)
            {
                UnlockAchievement("A Perfect Disguise");
            }
        }

        private void UnlockAchievement(string name)
        {
            Achievement achievement = PlayerHelper.Player.Achievements.Where(achievement => achievement.Name == name).First();

            if (!achievement.IsAchieved)
            {
                PlayerHelper.Player.Achievements.Where(achievement => achievement.Name == name).First().IsAchieved = true;

                flpAchievementsUnlocked.Controls.Add(new AchievementView(achievement));
            }
        }
    }
}
