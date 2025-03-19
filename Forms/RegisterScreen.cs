using Coursework.Helpers;
using Coursework.ParentClasses;
using System.Text.Json;
using Coursework.UserControls;
using System.Diagnostics;
using Coursework.Exceptions;
using Coursework.Forms;
using System.Media;

namespace Coursework
{
    public partial class RegisterScreen : Form
    {
        private Player? player;
        private List<Player>? playerList = new();
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
                tbPassword.PasswordChar = '\0';
                tbReenter.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '●';
                tbReenter.PasswordChar = '●';
            }
        }

        private async void btnRegister_Click(object? sender, EventArgs e)
        {
            if (!File.Exists("playerData.bin") || File.ReadAllLines("playerData.bin").Length == 0)
            {
                using (BinaryWriter bw = new(File.Open("playerData.bin", FileMode.Create)))
                {
                    bw.Write("[]");
                }
            }

            using (BinaryReader br = new(File.Open("playerData.bin", FileMode.Open)))
            {
                string json = br.ReadString();
                playerList = JsonSerializer.Deserialize<List<Player>>(json);
            }

            if (tbPassword.Text != tbReenter.Text)
            {
                ErrorMessage(lblPassMatch.Text);
            }

            else if (playerList.Any(player => player.Username == tbUsername.Text.Trim()))
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
                using (BinaryWriter bw = new(File.Open("playerData.bin", FileMode.Create)))
                {
                    while (player == null)
                    {
                        try
                        {
                            List<Achievement> achievements = JsonSerializer.Deserialize<List<Achievement>>(File.ReadAllText("achievements.json"));

                            player = new(tbUsername.Text.Trim(), tbPassword.Text.Trim(), new TFClass(classId), (uint)playerList.Count + 1, null, achievements);
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

                    this.Close();
                    new LoginScreen().Show();
                }
            }
        }

        private void classSelect_Click(object sender, EventArgs e)
        {
            PictureBox selectedClass = (PictureBox)sender;

            classId = UInt32.Parse(selectedClass.Tag.ToString()); // gets the Tag defined in the designer (which will be a number from 1 to 9) into a variable

            pbClassSelected.Image = TFClass.Assets[classId].Portrait;
        }

        private void classSelect_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selectedClass = (PictureBox)sender;

            classId = UInt32.Parse(selectedClass.Tag.ToString()); // gets the Tag defined in the designer (which will be a number from 1 to 9) into a variable

            SoundPlayer player = new();

            try
            {
                player.SoundLocation = @$"Sounds/SFX/tfclassSelect{classId}.wav";

                player.Play();
            }
            catch (FileNotFoundException)
            {

            }
        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginScreen().Show();
            Hide();
        }

        private void ErrorMessage(string text)
        {
            btnRegister.Click -= btnRegister_Click;

            TFMessageBox.Show(text, "Error");

            btnRegister.Click += btnRegister_Click;
        }
    }
}
