using Coursework.Helpers;
using Coursework.Classes;
using System.Text.Json;

namespace Coursework
{
    public partial class RegisterScreen : Form
    {
        List<Player>? playerList;
        uint classId = 0;

        public RegisterScreen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {
            FontHelper.ApplyFonts(this);
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
            // Checks if file either doesn't exist or is empty to start JSON formatting (the square brackets are required as this will be deserialized into a list of objects of type Player). Also uses a binary file for security of user's credentials
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
                playerList = JsonSerializer.Deserialize<List<Player>>(json);
            }

            // Checks if the entered password isnt the same as the re-entered password, removes click event to prevent making an incorrect account, and shows an error label.
            if (tbPassword.Text != tbReenter.Text)
            {
                lblPassMatch.Visible = true;

                tbPassword.Clear();
                tbReenter.Clear();

                btnRegister.Click -= btnRegister_Click;

                await Task.Delay(1000);

                lblPassMatch.Visible = false;
                btnRegister.Click += btnRegister_Click;
            }

            /* uses a LINQ quetry to check every user in the database and ensure the entered usenrame is not already registered, the method Any() returns a boolean value if the list contains the value found in tbUsername.Text
               an anonymous method here is defined here with a lambda expression (=>) as this will only be used once here, so a full named method is not needed.
               to the left of the => is a temporary parameter used for the anonmyous method, and to the right is the logic of the method.
               i utilised a lambda expression here as it provides more readablity for the code and this is a one off condition which will not be re-used. */
            else if (playerList.Any(u => u.Username == tbUsername.Text))
            {
                lblAccExists.Visible = true;

                tbUsername.Clear();

                btnRegister.Click -= btnRegister_Click;

                await Task.Delay(1000);

                lblAccExists.Visible = false;
                btnRegister.Click += btnRegister_Click;
            }

            // checks whether a username and password have been entered and class has been selected
            else if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                lblPleaseEnter.Visible = true;

                btnRegister.Click -= btnRegister_Click;

                await Task.Delay(1000);

                lblPleaseEnter.Visible = false;
                btnRegister.Click += btnRegister_Click;
            }

            else if (classId == 0)
            {
                lblPleaseEnter.Text = "Please select a class.";
                lblPleaseEnter.Visible = true;

                btnRegister.Click -= btnRegister_Click;

                await Task.Delay(1000);

                lblPleaseEnter.Visible = false;
                lblPleaseEnter.Text = "Please enter a username and password.";
                btnRegister.Click += btnRegister_Click;
            }

            // if everything is correct, the user is written to the file
            else
            {
                using (BinaryWriter bw = new(File.Open(FormHelper.s_playerJsonPath, FileMode.Create)))
                {
                    Player player = new(tbUsername.Text, tbPassword.Text, new TFClass(classId), playerList.Count + 1);
                    playerList.Add(player);

                    string updatedJson = JsonSerializer.Serialize(playerList);
                    bw.Write(updatedJson);

                    MessageBox.Show(updatedJson);

                    tbUsername.Clear();
                    tbPassword.Clear();
                    tbReenter.Clear();
                }
            }
        }

        private void classSelect_Click(object sender, EventArgs e)
        {
            PictureBox selectedClass = (PictureBox)sender;

            classId = UInt32.Parse(selectedClass.Tag.ToString()); // gets the Tag defined in the designer (which will be a number from 1 to 9) into a variable
            pbClassSelected.Image = TFClass.classToImage[classId].Item3;
        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHelper.s_loginScreen.Show();
            Hide();
        }
    }
}
