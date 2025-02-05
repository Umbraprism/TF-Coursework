using Coursework.Helpers;
using Coursework.ParentClasses;

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
            uint randomClass = (uint)rnd.Next(1, 10);

            FontHelper.ApplyFonts(this);

            //FontHelper.ApplyCursor(this, CursorStyle.Default);

            lblTipText.Text = FormHelper.s_tips[rnd.Next(0, FormHelper.s_tips.Length - 1)].Text;

            lblOnWayTo.Text = OnWayTo.Text;
            lblOnWayTo.Left = (pnlOnWayTo.Width / 2 - (TextRenderer.MeasureText(lblOnWayTo.Text, lblOnWayTo.Font).Width / 2));
            lblOnWayTo.Top = (pnlOnWayTo.Height / 2 - (TextRenderer.MeasureText(lblOnWayTo.Text, lblOnWayTo.Font).Height / 2));

            lblClassName.Text = TFClass.assetsHashmap[randomClass].Item4;
            lblClassName.Left = (pnlClassName.Width / 2 - (TextRenderer.MeasureText(lblClassName.Text, lblClassName.Font).Width / 2));

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
