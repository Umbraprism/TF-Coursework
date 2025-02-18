using Coursework.ParentClasses;
using Coursework.Helpers;
using Coursework.UserControls;
using System.Text.Json;

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

            pbPfp.Image = TFClass.Assets[FormHelper.QuizPlayer.TFClass.Id].Avatar;
            lblUsername.Text = FormHelper.QuizPlayer.Username;
            lblAchievementCount.Text = $"{FormHelper.QuizPlayer.Achievements.Count(achievement => achievement.IsAchieved)} Achievements";
            lblHighestScore.Text = $"Highest Score - {FormHelper.QuizPlayer.GetHighestScore()}";
            lblClass.Text = $"The {FormHelper.QuizPlayer.TFClass.Name}";

            lblTipText.Text = FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Length - 1)].Text;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult quitQuery = TFMessageBox.Show("Are you sure you would like to quit?", "Quit", TFMessageBoxButtons.YesAndNo);

            if (quitQuery == DialogResult.Yes)
            {
                int playerToReplace = FormHelper.PlayerList.FindIndex(player => player.Id == FormHelper.QuizPlayer.Id);
                FormHelper.PlayerList[playerToReplace] = FormHelper.QuizPlayer;

                using (BinaryWriter bw = new(File.Open(FormHelper.PlayersJsonPath, FileMode.Create)))
                {
                    string json = JsonSerializer.Serialize(FormHelper.PlayerList);
                    bw.Write(json);
                }

                Application.Exit();
            }
        }

        private void btnNextTip_Click(object sender, EventArgs e)
        {
            if (lblTipText.Text == FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Length - 1)].Text)
            {
                btnNextTip_Click(sender, e);
            }
            else
            {
                lblTipText.Text = FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Length - 1)].Text;
            }
        }

        private void btnWeaponsQuiz_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(Path.Combine(FormHelper.QuizJsonPath, $"WeaponsQuiz.json"));
            FormHelper.CurrentQuiz = JsonSerializer.Deserialize<Quiz>(json);

            TFMessageBox.Show($"{FormHelper.CurrentQuiz.CurrentDifficulty.Count}", "eee");

            Question question = FormHelper.CurrentQuiz.CurrentDifficulty[FormHelper.CurrentQuiz.CurrentQuestionIndex];

            switch (question.Type)
            {
                case QuestionType.MultipleChoice:
                    new MultipleChoiceScreen(ref question).Show();
                    break;
                case QuestionType.TrueFalse:
                    new TrueFalseScreen(ref question).Show();
                    break;
                case QuestionType.DragDrop:
                    new DragDropScreen(ref question).Show();
                    break;
                default:
                    throw new FormatException("Question is not of a valid type.");
            }
            this.Hide();
        }

        private void btnTFClassQuiz_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(Path.Combine(FormHelper.QuizJsonPath, $"TFClassQuiz.json"));
            FormHelper.CurrentQuiz = JsonSerializer.Deserialize<Quiz>(json);
            //FormHelper.s_currentQuiz.CreateQuizForms();

            //new SplashScreen(FormHelper.s_currentQuiz.currentDifficulty[FormHelper.s_currentQuiz.currentQuestionIndex]).Show();
            this.Hide();
        }

        private void btnHistoryQuiz_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(Path.Combine(FormHelper.QuizJsonPath, $"HistoryQuiz.json"));
            FormHelper.CurrentQuiz = JsonSerializer.Deserialize<Quiz>(json);
            //FormHelper.s_currentQuiz.CreateQuizForms();

            //new SplashScreen(FormHelper.s_currentQuiz.currentDifficulty[FormHelper.s_currentQuiz.currentQuestionIndex]).Show();
            this.Hide();
        }

        private void btnGuessingGame_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = TFMessageBox.Show("Would you like to guess today's weapon in the 'Daily' mode, or test your ability to identify weapons endlessly 'TF∞' mode?", "Select a mode", TFMessageBoxButtons.Custom, new string[] { "Daily", "TF∞" });

            if (dialogResult == DialogResult.Yes)
            {
                throw new NotImplementedException();
            }
            else if (dialogResult == DialogResult.No)
            {
                throw new NotImplementedException();
            }
            else { }
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.AchievementScreen.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.LeaderboardScreen.Show();
        }
    }
}
