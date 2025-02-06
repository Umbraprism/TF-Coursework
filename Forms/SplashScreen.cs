using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;
namespace Coursework.Forms
{
    public partial class SplashScreen : Form
    {
        public Form OnWayTo { get; set; }
        private Random rnd = new();

        public SplashScreen(Form OnWayTo)
        {
            InitializeComponent();
            this.OnWayTo = OnWayTo;
        }

        private void ppbLoading_Click(object sender, EventArgs e)
        {
            ppbLoading.Value += 5;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            uint randomClass = (uint)rnd.Next(1, 10);

            Tip[] tfClassTips = FormHelper.s_tips.Where(tip => tip.TFClassId == randomClass).ToArray();
            lblTipText.Text = tfClassTips[rnd.Next(0, tfClassTips.Length - 1)].Text;

            lblOnWayTo.Text = OnWayTo.Text;
            lblOnWayTo.Left = (pnlOnWayTo.Width / 2 - (TextRenderer.MeasureText(lblOnWayTo.Text, lblOnWayTo.Font).Width / 2));
            lblOnWayTo.Top = (pnlOnWayTo.Height / 2 - (TextRenderer.MeasureText(lblOnWayTo.Text, lblOnWayTo.Font).Height / 2));

            lblTFClassName.Text = TFClass.assetsHashmap[randomClass].Item4;
            lblTFClassName.Left = (pnlClassName.Width / 2 - (TextRenderer.MeasureText(lblTFClassName.Text, lblTFClassName.Font).Width / 2));

            pbClassImage.Image = TFClass.assetsHashmap[randomClass].Item3;

            tmrLoading.Start();
        }

        private void SplashScreen_VisibleChanged(object sender, EventArgs e)
        {
            ppbLoading.Value = ppbLoading.Minimum;
        }

        private async void tmrLoading_Tick(object sender, EventArgs e)
        {
            try
            {
                tmrLoading.Interval -= (int)Math.Ceiling((double)ppbLoading.Value / 100);
                ppbLoading.Increment(1);

            }
            catch (ArgumentOutOfRangeException)
            {
                tmrLoading.Interval = 1;
                ppbLoading.Value = ppbLoading.Maximum;
            }

            if (ppbLoading.Value >= ppbLoading.Maximum)
            {
                await Task.Delay(1000);

                tmrLoading.Stop();
                OnWayTo.Show();
                this.Close();
            }
        }
    }
}
