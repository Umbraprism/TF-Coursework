using System.Diagnostics;
using System.Text.Json;
using Coursework.ParentClasses;
using Coursework.Helpers;

namespace Coursework.Forms
{
    public partial class LoginScreen : Form
    {
        Random rnd = new();
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
            FormHelper.s_registerScreen.Show();
            Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FormHelper.s_playerJsonPath) || File.ReadAllLines(FormHelper.s_playerJsonPath).Length == 0)
            {
                using (BinaryWriter bw = new(File.Open(FormHelper.s_playerJsonPath, FileMode.Create)))
                {
                    bw.Write("[]");
                }
            }

            // Reads from file and deserializes JSON into a list of Player objects
            using (BinaryReader br = new(File.Open(FormHelper.s_playerJsonPath, FileMode.Open)))
            {
                string json = br.ReadString();
                FormHelper.s_playerList = JsonSerializer.Deserialize<List<Player>>(json);
            }

            if (FormHelper.s_playerList.Any(player => player.Username == tbUsername.Text && player.Password == tbPassword.Text))
            {
                FormHelper.s_quizPlayer = FormHelper.s_playerList.Where(u => u.Username == tbUsername.Text && u.Password == tbPassword.Text).First();
                FormHelper.s_mainMenuScreen.Show();
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
            pbClassImage.Image = TFClass.assetsHashmap[tfRandomClass].Item2;
        }
    }
}
