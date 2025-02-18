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

            Tip[] tfClassTips = FormHelper.Tips.Where(tip => tip.TFClassId == randomClass).ToArray();
            lblTipText.Text = tfClassTips[rnd.Next(0, tfClassTips.Length - 1)].Text;

            lblOnWayTo.Text = OnWayTo.Text;
            lblOnWayTo.Left = (pnlOnWayTo.Width / 2 - (TextRenderer.MeasureText(lblOnWayTo.Text, lblOnWayTo.Font).Width / 2));
            lblOnWayTo.Top = (pnlOnWayTo.Height / 2 - (TextRenderer.MeasureText(lblOnWayTo.Text, lblOnWayTo.Font).Height / 2));

            lblTFClassName.Text = TFClass.Assets[randomClass].Name;
            lblTFClassName.Left = (pnlClassName.Width / 2 - (TextRenderer.MeasureText(lblTFClassName.Text, lblTFClassName.Font).Width / 2));

            pbClassImage.Image = TFClass.Assets[randomClass].Portrait;

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
