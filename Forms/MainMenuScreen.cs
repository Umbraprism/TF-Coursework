using Coursework.ParentClasses;
using Coursework.Helpers;
using Coursework.UserControls;
using System.Text.Json;
using System.Net.Sockets;
using System.Text;
using System.Net;

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
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            tbVolume.Value = Program.WMP.settings.volume;

            Session.Player.TFClass.Ability.Reset();

            pbPfp.Image = TFClass.Assets[Session.Player.TFClass.Id].Avatar;
            lblUsername.Text = Session.Player.Username;
            lblAchievementCount.Text = $"{Session.Player.Achievements.Count(achievement => achievement.IsAchieved)} Achievements";
            lblHighestScore.Text = $"Highest Score - {Session.Player.GetHighestScore()}";
            lblClass.Text = $"The {Session.Player.TFClass.Name}";

            lblTipText.Text = Session.Tips[rnd.Next(0, Session.Tips.Count - 1)].Text;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult quitQuery = TFMessageBox.Show("Are you sure you would like to quit?", "Quit", TFMessageBoxButtons.YesAndNo);

            if (quitQuery == DialogResult.Yes)
            {
                int playerToReplace = Session.PlayerList.FindIndex(player => player.Id == Session.Player.Id);
                Session.PlayerList[playerToReplace] = Session.Player;

                using (BinaryWriter bw = new(File.Open("playerData.bin", FileMode.Create)))
                {
                    string json = JsonSerializer.Serialize(Session.PlayerList);
                    bw.Write(json);
                }

                Application.Exit();
            }
        }

        private void btnNextTip_Click(object sender, EventArgs e)
        {
            if (lblTipText.Text == Session.Tips[rnd.Next(0, Session.Tips.Count)].Text)
            {
                btnNextTip_Click(sender, e);
            }
            else
            {
                lblTipText.Text = Session.Tips[rnd.Next(0, Session.Tips.Count)].Text;
            }
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string json = File.ReadAllText(@$"Quizzes\{btn.Tag}Quiz.json");
            Session.Quiz = JsonSerializer.Deserialize<Quiz>(json);

            if (Session.Quiz != null)
            {
                Question question = Session.Quiz.CurrentDifficulty[Session.Quiz.CurrentQuestionIndex];

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
                    case QuestionType.GapFill:
                        new SplashScreen(new GapFillScreen(ref question)).Show();
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
            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            string ip = ipHostEntry.AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault().ToString();

            DialogResult hostOrJoinQuery = TFMessageBox.Show("Would you like to host a chatroom for others to join or join an already existing match?", "Select a mode", TFMessageBoxButtons.Custom, new string[] { "Host", "Join" });

            if (hostOrJoinQuery == DialogResult.Yes && nudPort.Value > 1024)
            {
                new ServerHostScreen((int)nudPort.Value).Show();

                TFMessageBox.Show($"Server created on IP Address {ip} with the port number {nudPort.Value}", "Server Created!");
            }
            else if (hostOrJoinQuery == DialogResult.No)
            {
                try
                {
                    TcpClient client = new();

                    string json = JsonSerializer.Serialize(Session.Player);

                    client.Connect(tbIPAddress.Text, (int)nudPort.Value);

                    Server.SendPacket(client.GetStream(), Encoding.Unicode.GetBytes(json));
                    client.GetStream().FlushAsync();

                    new SplashScreen(new ServerClientScreen(client, client.GetStream())).Show();
                    this.Close();
                }
                catch (SocketException ex)
                {
                    TFMessageBox.Show(ex.Message, "Connection Error");
                }
            }
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            tbVolume.Value = 0;
        }

        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            ttVolume.SetToolTip(tbVolume, $"Current Volume - {tbVolume.Value}");

            if (tbVolume.Value > 51)
            {
                btnMute.Text = "🔊";
            }
            if (tbVolume.Value <= 50)
            {
                btnMute.Text = "🔉";
            }
            if (tbVolume.Value == 0)
            {
                btnMute.Text = "🔈";
            }

            Program.WMP.settings.volume = tbVolume.Value;
        }

        private void ttVolume_Draw(object sender, DrawToolTipEventArgs e)
        {
            UI.DrawToolTip(sender, e);
        }

        private void ttVolume_Popup(object sender, PopupEventArgs e)
        {
            UI.SizeToolTip(sender, e);
        }
    }
}
