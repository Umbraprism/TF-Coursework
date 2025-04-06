using Coursework.Helpers;

namespace Coursework.UserControls
{
    /// <summary>
    /// Enumerator used to allow types of buttons to be input.
    /// </summary>
    public enum TFMessageBoxButtons
    {
        OK,
        YesAndNo,
        Custom
    }

    /// <summary>
    /// The form used by TFMessageBox to show itself.
    /// </summary>
    public partial class TFMessageBox : Form
    {
        #region Field declarations
        private static DialogResult result;
        #endregion

        public TFMessageBox(string message, string title, TFMessageBoxButtons? buttons, string[] buttonText)
        {
            InitializeComponent();
            this.Text = title;

            this.lblMessage.Text = message;
            this.lblTitle.Text = title.ToUpper();

            switch (buttons)
            {
                case TFMessageBoxButtons.OK:
                    tlpYesAndNo.Visible = false;
                    btnOk.Visible = true;
                    break;
                case TFMessageBoxButtons.YesAndNo:
                    tlpYesAndNo.Visible = true;
                    btnOk.Visible = false;
                    break;
                case TFMessageBoxButtons.Custom:
                    tlpYesAndNo.Visible = true;
                    btnOk.Visible = false;
                    btnYes.Text = buttonText[0].ToUpper();
                    btnNo.Text = buttonText[1].ToUpper();
                    break;
                default:
                    tlpYesAndNo.Visible = false;
                    btnOk.Visible = true;
                    break;
            }
        }

        private void TFMessageBox_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = 0x00020000;
                return cp;
            }
        }

        public static DialogResult Show(string message, string title, TFMessageBoxButtons buttons = TFMessageBoxButtons.OK, params string[] buttonText)
        {
            if (buttonText.Length > 2)
            {
                throw new ArgumentException("The amount of items in the 'buttonText' parameter should not exceed 2.");
            }

            using (Form backDrop = new()
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackColor = Color.Black,
                Opacity = 0.5,
                ShowInTaskbar = false,
                Enabled = false
            })
            using (TFMessageBox msg = new(message, title, buttons, buttonText))
            {
                backDrop.Show();
                msg.ShowDialog();
                return result;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Close();
        }
    }
}
