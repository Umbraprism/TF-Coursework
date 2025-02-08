using Coursework.Helpers;

namespace Coursework.UserControls
{
    /// <summary>
    /// Enumerator used to allow types of buttons to be input.
    /// </summary>
    public enum TFMessageBoxButtons
    {
        OK,
        YesAndNo
    }

    /// <summary>
    /// The form used by TFMessageBox to show itself.
    /// </summary>
    public partial class TFMessageBox : Form
    {
        private static DialogResult _result;

        public TFMessageBox(string message, string title, TFMessageBoxButtons? buttons)
        {
            InitializeComponent();
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
                default:
                    tlpYesAndNo.Visible = false;
                    btnOk.Visible = true;
                    break;
            }
        }

        private void TFMessageBox_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);
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

        public static DialogResult Show(string message, string title, TFMessageBoxButtons buttons = TFMessageBoxButtons.OK)
        {
            using (TFMessageBox msg = new(message, title, buttons))
            {
                msg.ShowDialog();
                return _result;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
             _result = DialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            this.Close();
        }
    }
}
