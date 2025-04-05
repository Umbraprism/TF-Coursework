using System.Data;
using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class EndScreen : Form
    {
        #region Field declarations

        private int noCorrect = 0;
        private int noIncorrect = 0;
        private int timeOnScreen = 10;

        private string Rank
        {
            get
            {
                double percentage = (noCorrect * 100) / Session.Quiz.BaseQuestions.Count;

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
                List<int> scores = new();

                foreach (Player player in Session.PlayerList)
                {
                    scores.Add(player.ScoresHashmap[Session.Quiz.QuizType].LatestScore);
                }

                scores.Sort();
                scores.Reverse();

                return scores.IndexOf(Session.Player.ScoresHashmap[Session.Quiz.QuizType].LatestScore) + 1;
            }
        }

        #endregion

        #region Constructor

        public EndScreen()
        {
            noCorrect = Session.Quiz.BaseQuestions.Where(question => question.IsCorrect && question.IsAnswered).Count() + Session.Quiz.EasyQuestions.Where(question => question.IsCorrect && question.IsAnswered).Count();
            noIncorrect = Session.Quiz.BaseQuestions.Where(question => !question.IsCorrect && question.IsAnswered).Count() + Session.Quiz.EasyQuestions.Where(question => !question.IsCorrect && question.IsAnswered).Count();
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void EndScreen_Load(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            CheckAchievements();

            if (Session.Quiz.Score > Session.Player.ScoresHashmap[Session.Quiz.QuizType].HighestScore)
            {
                Session.Player.ScoresHashmap[Session.Quiz.QuizType].HighestScore = Session.Quiz.Score;
            }

            Session.Player.ScoresHashmap[Session.Quiz.QuizType].LatestScore = Session.Quiz.Score;

            Session.Player.ScoresHashmap[Session.Quiz.QuizType].Rank = Rank;

            lblUsername.Text = $"{Session.Player.Username} wins!".ToUpper();
            lblCorrect.Text = $"{noCorrect} Correct";
            lblIncorrect.Text = $"{noIncorrect} Incorrect";
            lblScore.Text = $"Score - {Session.Quiz.Score}";

            lblGrade.Text = Rank.ToUpper();
            lblGrade.ForeColor = UI.ColourPalette[Rank];

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
            Session.Quiz = new();
            this.Close();
            new MainMenuScreen().Show();
        }

        #endregion

        #region Methods

        private void CheckAchievements()
        {
            if (((double)Session.Quiz.TimeRemaining / (double)Session.Quiz.TotalTime) * 100 >= 50)
            {
                UnlockAchievement("Race For The Pennant");
            }
            if (((double)Session.Quiz.TimeRemaining / (double)Session.Quiz.TotalTime) * 100 >= 25)
            {
                UnlockAchievement("Charge n' Targe");
            }
            if (Rank == "Unusual" && Session.Quiz.QuizType == QuizScores.Weapons)
            {
                UnlockAchievement("Top Gun");
            }
            if (Rank == "Unusual" && Session.Quiz.QuizType == QuizScores.TFClass)
            {
                UnlockAchievement("Top of the Class");
            }
            if (Rank == "Unusual" && Session.Quiz.QuizType == QuizScores.History)
            {
                UnlockAchievement("Time Machine");
            }
            if (Session.Player.TFClass.Ability.TimesUsed == 0)
            {
                UnlockAchievement("Specialist");
            }
            if (Session.Player.TFClass.Id == 9 && Session.Quiz.IsDisguised)
            {
                UnlockAchievement("A Perfect Disguise");
            }
            if (CheckLeaderboards())
            {
                UnlockAchievement("Iron Kurtain");
            }
        }

        private void UnlockAchievement(string name)
        {
            Achievement achievement = Session.Player.Achievements.Where(achievement => achievement.Name == name).First();

            if (!achievement.IsAchieved)
            {
                Session.Player.Achievements.Where(achievement => achievement.Name == name).First().IsAchieved = true;

                flpAchievementsUnlocked.Controls.Add(new AchievementView(achievement));
            }
        }

        private bool CheckLeaderboards()
        {
            int[] placements = new int[3];

            for (int i = 0; i < 4; i++)
            {
                List<int> scores = new();

                foreach (Player player in Session.PlayerList)
                {
                    scores.Add(player.ScoresHashmap[(QuizScores)i].LatestScore);
                }

                scores.Sort();
                scores.Reverse();

                placements[i] = scores.IndexOf(Session.Player.ScoresHashmap[Session.Quiz.QuizType].LatestScore) + 1;
            }

            return placements.All(place => place == 1);
        }

        #endregion
    }
}
