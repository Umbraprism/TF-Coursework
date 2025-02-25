using Coursework.Helpers;
using Coursework.ParentClasses;
using System.Text.Json;
using Coursework.UserControls;
using System.Diagnostics;
using Coursework.Exceptions;

namespace Coursework
{
    public partial class RegisterScreen : Form
    {
        private Player? player;
        private List<Player> playerList = new();
        private uint classId = 0;

        public RegisterScreen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.Default);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbReenter.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbReenter.UseSystemPasswordChar = true;
            }
        }

        private async void btnRegister_Click(object? sender, EventArgs e)
        {
            if (!File.Exists(FormHelper.PlayersJsonPath) || File.ReadAllLines(FormHelper.PlayersJsonPath).Length == 0)
            {
                using (BinaryWriter bw = new(File.Open(FormHelper.PlayersJsonPath, FileMode.Create)))
                {
                    bw.Write("[]");
                }
            }

            using (BinaryReader br = new(File.Open(FormHelper.PlayersJsonPath, FileMode.Open)))
            {
                string json = br.ReadString();
                playerList = JsonSerializer.Deserialize<List<Player>>(json);
            }

            if (tbPassword.Text != tbReenter.Text)
            {
                ErrorMessage(lblPassMatch.Text);
            }

            else if (playerList.Any(player => player.Username == tbUsername.Text))
            {
                ErrorMessage(lblAccExists.Text);
            }

            else if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                ErrorMessage(lblPleaseEnter.Text);
            }

            else if (classId == 0)
            {
                ErrorMessage(lblPleaseSelectClass.Text);
            }

            else
            {
                using (BinaryWriter bw = new(File.Open(FormHelper.PlayersJsonPath, FileMode.Create)))
                {
                    while (player == null)
                    {
                        try
                        {
                            List<Achievement> achievements = JsonSerializer.Deserialize<List<Achievement>>(File.ReadAllText("achievements.json"));

                            player = new(tbUsername.Text, tbPassword.Text, new TFClass(classId), (uint)playerList.Count + 1, null, achievements);
                            playerList.Add(player);
                        }
                        catch (InvalidUsernameException ex)
                        {
                            ErrorMessage(ex.Message);
                            return;
                        }
                        catch (InvalidPasswordException ex)
                        {
                            ErrorMessage(ex.Message);
                            return;
                        }
                    }

                    string updatedJson = JsonSerializer.Serialize(playerList, new JsonSerializerOptions { WriteIndented = true }); // writes indented so the debug output is easier to read
                    bw.Write(updatedJson);
                    Debug.WriteLine(updatedJson);

                    tbUsername.Clear();
                    tbPassword.Clear();
                    tbReenter.Clear();
                    classId = 0;
                    pbClassSelected.Image = null;

                    btnRegister.BackColor = Color.FromArgb(114, 158, 66);
                    TFMessageBox.Show($"Thank you for registering! The account '{player.Username}' has been registered succesfully.", "Registration Successful");

                    await Task.Delay(1000);

                    btnRegister.BackColor = Color.FromArgb(189, 59, 59);

                    PlayerHelper.PlayerList = playerList;

                    this.Hide();
                    FormHelper.LoginScreen.Show();
                }
            }
        }

        private void classSelect_Click(object sender, EventArgs e)
        {
            PictureBox selectedClass = (PictureBox)sender;

            classId = UInt32.Parse(selectedClass.Tag.ToString()); // gets the Tag defined in the designer (which will be a number from 1 to 9) into a variable
            pbClassSelected.Image = TFClass.Assets[classId].Portrait;
        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHelper.LoginScreen.Show();
            Hide();
        }

        private void RegisterScreen_Deactivate(object sender, EventArgs e)
        {
            player = null;
        }

        private void ErrorMessage(string text)
        {
            btnRegister.Click -= btnRegister_Click;

            TFMessageBox.Show(text, "Error");

            btnRegister.Click += btnRegister_Click;
        }
    }
}
