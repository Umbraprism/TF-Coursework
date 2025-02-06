using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.Helpers;

namespace Coursework.UserControls
{
    public enum TFMessageBoxButtons
    {
        OK,
        YesAndNo
    }
    public partial class TFMessageBox : Form
    {
        public TFMessageBox(string title, string message, TFMessageBoxButtons buttons)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            this.lblMessage.Text = message;
        }

        private void TFMessageBox_Load(object sender, EventArgs e)
        {
            FontHelper.ApplyFonts(this);
            FontHelper.ApplyCursor(this, CursorStyle.TFClass);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DROPSHADOW;
                return cp;
            }
        }

        public static void Show(string title, string description, TFMessageBoxButtons buttons)
        {
            using (TFMessageBox msg = new(title, description, buttons))
            {

            }
        }
    }
}
