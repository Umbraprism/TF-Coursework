using Coursework.ParentClasses;
using Coursework.Helpers;
using Coursework.UserControls;
using System.Text.Json;
using System.Net.Sockets;
using System.Text;

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

            pbPfp.Image = TFClass.Assets[PlayerHelper.QuizPlayer.TFClass.Id].Avatar;
            lblUsername.Text = PlayerHelper.QuizPlayer.Username;
            lblAchievementCount.Text = $"{PlayerHelper.QuizPlayer.Achievements.Count(achievement => achievement.IsAchieved)} Achievements";
            lblHighestScore.Text = $"Highest Score - {PlayerHelper.QuizPlayer.GetHighestScore()}";
            lblClass.Text = $"The {PlayerHelper.QuizPlayer.TFClass.Name}";

            lblTipText.Text = FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Count - 1)].Text;

            lblOnlineRank.Text = PlayerHelper.QuizPlayer.OnlineRank;
            lblOnlineRank.ForeColor = FormHelper.ColourPalette[lblOnlineRank.Text];
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult quitQuery = TFMessageBox.Show("Are you sure you would like to quit?", "Quit", TFMessageBoxButtons.YesAndNo);

            if (quitQuery == DialogResult.Yes)
            {
                int playerToReplace = PlayerHelper.PlayerList.FindIndex(player => player.Id == PlayerHelper.QuizPlayer.Id);
                PlayerHelper.PlayerList[playerToReplace] = PlayerHelper.QuizPlayer;

                using (BinaryWriter bw = new(File.Open(FormHelper.PlayersJsonPath, FileMode.Create)))
                {
                    string json = JsonSerializer.Serialize(PlayerHelper.PlayerList);
                    bw.Write(json);
                }

                Application.Exit();
            }
        }

        private void btnNextTip_Click(object sender, EventArgs e)
        {
            if (lblTipText.Text == FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Count - 1)].Text)
            {
                btnNextTip_Click(sender, e);
            }
            else
            {
                lblTipText.Text = FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Count - 1)].Text;
            }
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string json = File.ReadAllText(@$"Quizzes\{btn.Tag}Quiz.json");
            FormHelper.CurrentQuiz = JsonSerializer.Deserialize<Quiz>(json);

            if (FormHelper.CurrentQuiz != null)
            {
                Question question = FormHelper.CurrentQuiz.CurrentDifficulty[FormHelper.CurrentQuiz.CurrentQuestionIndex];

                switch (question.Type)
                {
                    case QuestionType.MultipleChoice:
                        new SplashScreen(new MultipleChoiceScreen(ref question)).Show();
                        break;
                    case QuestionType.TrueFalse:
                        new SplashScreen(new TrueFalseScreen(ref question)).Show();
                        break;
                    case QuestionType.DragDrop:
                        new SplashScreen(new DragDropScreen(ref question)).Show();
                        break;
                    default:
                        throw new FormatException("Question is not of a valid type.");
                }

                this.Hide();
            }
            else
            {
                throw new FormatException();
            }
        }

        private void btnGuessingGame_Click(object sender, EventArgs e)
        {
            DialogResult modeSelect = TFMessageBox.Show("Would you like to guess today's weapon in the 'Daily' mode, or test your ability to identify weapons endlessly 'TF∞' mode?", "Select a mode", TFMessageBoxButtons.Custom, new string[] { "Daily", "TF∞" });

            if (modeSelect == DialogResult.Yes)
            {
                this.Hide();
                new GuessingGameScreen(false).Show();
            }
            else if (modeSelect == DialogResult.No)
            {
                this.Hide();
                new GuessingGameScreen(true).Show();
            }
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.AchievementScreen.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.StatsScreen.Show();
        }

        private void btnHostOrJoin_Click(object sender, EventArgs e)
        {
            TcpClient client = new();

            DialogResult hostOrJoinQuery = TFMessageBox.Show("Would you like to host a match for others to join or join an already existing match?", "Select a mode", TFMessageBoxButtons.Custom, new string[] { "Host", "Join" });

            if (hostOrJoinQuery == DialogResult.Yes)
            {
                new SplashScreen(new ServerHostScreen()).Show();
                this.Hide();
            }
            else if (hostOrJoinQuery == DialogResult.No)
            {
                try
                {
                    client.Connect("127.0.0.1", 5001);

                    string json = JsonSerializer.Serialize(PlayerHelper.QuizPlayer);

                    ServerHelper.SendPacket(client.GetStream(), Encoding.Unicode.GetBytes(json));
                }
                catch (SocketException)
                {
                    string msg = Encoding.Unicode.GetString(ServerHelper.ReadStream(client.GetStream()));

                    TFMessageBox.Show(msg, "Connection Error");
                }
            }
        }
    }
}
