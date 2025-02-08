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
            string json = File.ReadAllText(Path.Combine(FormHelper.s_quizJsonPath, $"WeaponsQuiz.json"));
            FormHelper.s_currentQuiz = JsonSerializer.Deserialize<Quiz>(json);
            //FormHelper.s_currentQuiz.CreateQuiz();

            TFMessageBox.Show($"{FormHelper.s_currentQuiz.CurrentDifficulty.Count}", "eee");

            Question question = FormHelper.s_currentQuiz.CurrentDifficulty[FormHelper.s_currentQuiz.currentQuestionIndex];

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
            string json = File.ReadAllText(Path.Combine(FormHelper.s_quizJsonPath, $"TFClassQuiz.json"));
            FormHelper.s_currentQuiz = JsonSerializer.Deserialize<Quiz>(json);
            //FormHelper.s_currentQuiz.CreateQuizForms();

            //new SplashScreen(FormHelper.s_currentQuiz.currentDifficulty[FormHelper.s_currentQuiz.currentQuestionIndex]).Show();
            this.Hide();
        }

        private void btnHistoryQuiz_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(Path.Combine(FormHelper.s_quizJsonPath, $"HistoryQuiz.json"));
            FormHelper.s_currentQuiz = JsonSerializer.Deserialize<Quiz>(json);
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
            FormHelper.s_achievementsScreen.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.s_leaderboardScreen.Show();
        }
    }
}
