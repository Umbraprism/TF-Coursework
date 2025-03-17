using System.Diagnostics;
using System.Text.Json;
using Coursework.ParentClasses;
using Coursework.Helpers;

namespace Coursework.Forms
{
    public partial class LoginScreen : Form
    {
        private Random rnd = new();

        public LoginScreen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.Default);
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterScreen().Show();
            Hide();
        }

        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            if (!File.Exists("playerData.bin") || File.ReadAllLines("playerData.bin").Length == 0)
            {
                using (BinaryWriter bw = new(File.Open("playerData.bin", FileMode.Create)))
                {
                    bw.Write("[]");
                }
            }

            // Reads from file and deserializes JSON into a list of Player objects
            using (BinaryReader br = new(File.Open("playerData.bin", FileMode.Open)))
            {
                string json = br.ReadString();
                PlayerHelper.PlayerList = JsonSerializer.Deserialize<List<Player>>(json);
            }

            if (PlayerHelper.PlayerList != null)
            {
                if (PlayerHelper.PlayerList.Any(player => player.Username == tbUsername.Text.Trim() && player.Password == tbPassword.Text.Trim()))
                {
                    PlayerHelper.Player = PlayerHelper.PlayerList.Where(user => user.Username == tbUsername.Text.Trim() && user.Password == tbPassword.Text.Trim()).First();
                    new SplashScreen(new MainMenuScreen()).Show();
                    Hide();
                }
                else
                {
                    lblPasswordIncorrect.Visible = true;

                    tbPassword.Clear();

                    btnLogin.Click -= btnLogin_Click;

                    await Task.Delay(1000);

                    lblPasswordIncorrect.Visible = false;
                    btnLogin.Click += btnLogin_Click;
                }
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginScreen_Activated(object sender, EventArgs e)
        {
            uint tfRandomClass = (uint)rnd.Next(1, 9);
            pbClassImage.Image = TFClass.Assets[tfRandomClass].Portrait;
        }
    }
}
