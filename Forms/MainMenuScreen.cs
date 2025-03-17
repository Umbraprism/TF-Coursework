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
        private static bool dailyPlayed = false;

        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void MainMenuScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            PlayerHelper.Player.TFClass.TFClassAbility.Reset();

            pbPfp.Image = TFClass.Assets[PlayerHelper.Player.TFClass.Id].Avatar;
            lblUsername.Text = PlayerHelper.Player.Username;
            lblAchievementCount.Text = $"{PlayerHelper.Player.Achievements.Count(achievement => achievement.IsAchieved)} Achievements";
            lblHighestScore.Text = $"Highest Score - {PlayerHelper.Player.GetHighestScore()}";
            lblClass.Text = $"The {PlayerHelper.Player.TFClass.Name}";

            lblTipText.Text = FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Count - 1)].Text;

            lblOnlineRank.Text = PlayerHelper.Player.OnlineRank;
            lblOnlineRank.ForeColor = FormHelper.ColourPalette[lblOnlineRank.Text];
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult quitQuery = TFMessageBox.Show("Are you sure you would like to quit?", "Quit", TFMessageBoxButtons.YesAndNo);

            if (quitQuery == DialogResult.Yes)
            {
                int playerToReplace = PlayerHelper.PlayerList.FindIndex(player => player.Id == PlayerHelper.Player.Id);
                PlayerHelper.PlayerList[playerToReplace] = PlayerHelper.Player;

                using (BinaryWriter bw = new(File.Open("playerData.bin", FileMode.Create)))
                {
                    string json = JsonSerializer.Serialize(PlayerHelper.PlayerList);
                    bw.Write(json);
                }

                Application.Exit();
            }
        }

        private void btnNextTip_Click(object sender, EventArgs e)
        {
            if (lblTipText.Text == FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Count)].Text)
            {
                btnNextTip_Click(sender, e);
            }
            else
            {
                lblTipText.Text = FormHelper.Tips[rnd.Next(0, FormHelper.Tips.Count)].Text;
            }
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string json = File.ReadAllText(@$"Quizzes\{btn.Tag}Quiz.json");
            FormHelper.Quiz = JsonSerializer.Deserialize<Quiz>(json);

            if (FormHelper.Quiz != null)
            {
                Question question = FormHelper.Quiz.CurrentDifficulty[FormHelper.Quiz.CurrentQuestionIndex];

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

                this.Close();
            }
            else
            {
                throw new FormatException();
            }
        }

        private void btnGuessingGame_Click(object sender, EventArgs e)
        {
            DialogResult modeSelect = TFMessageBox.Show("Would you like to guess today's weapon in the 'Daily' mode, or test your ability to identify weapons endlessly 'TF∞' mode?", "Select a mode", TFMessageBoxButtons.Custom, new string[] { "Daily", "TF∞" });

            if (modeSelect == DialogResult.Yes && !dailyPlayed)
            {
                dailyPlayed = true;

                this.Close();
                new GuessingGameScreen(false).Show();
            }
            else if (modeSelect == DialogResult.No)
            {
                this.Close();
                new GuessingGameScreen(true).Show();
            }
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Close();
            new AchievementsScreen().Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Close();
            new StatsScreen().Show();
        }

        private void btnHostOrJoin_Click(object sender, EventArgs e)
        {
            TcpClient client = new();

            DialogResult hostOrJoinQuery = TFMessageBox.Show("Would you like to host a match for others to join or join an already existing match?", "Select a mode", TFMessageBoxButtons.Custom, new string[] { "Host", "Join" });

            if (hostOrJoinQuery == DialogResult.Yes)
            {
                new SplashScreen(new ServerHostScreen()).Show();
                this.Close();
            }
            else if (hostOrJoinQuery == DialogResult.No)
            {
                try
                {
                    client.Connect("127.0.0.1", 5001);

                    string json = JsonSerializer.Serialize(PlayerHelper.Player);

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
