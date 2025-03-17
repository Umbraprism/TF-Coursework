using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;
using System.ComponentModel;
namespace Coursework.Forms
{
    public partial class SplashScreen : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form OnWayTo { get; set; }

        private Random rnd = new();

        public SplashScreen(Form OnWayTo)
        {
            InitializeComponent();
            this.OnWayTo = OnWayTo;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            uint randomClass = (uint)rnd.Next(1, 10);

            Tip[] tfClassTips = FormHelper.Tips.Where(tip => tip.TFClassId == randomClass).ToArray();
            lblTipText.Text = tfClassTips[rnd.Next(0, tfClassTips.Length - 1)].Text;

            lblOnWayTo.Text = OnWayTo.Text;

            lblTFClassName.Text = TFClass.Assets[randomClass].Name.ToUpper();

            pbClassImage.Image = TFClass.Assets[randomClass].Portrait;

            tmrLoading.Start();
        }

        private void SplashScreen_VisibleChanged(object sender, EventArgs e)
        {
            ppbLoading.Value = ppbLoading.Minimum;
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            ppbLoading.Increment(1);
            Application.DoEvents();

            if (ppbLoading.Value >= ppbLoading.Maximum)
            {
                Thread.Sleep(1000);

                OnWayTo.Show();
                this.Close();

                tmrLoading.Stop();
            }
        }
    }
}
