using Coursework.Helpers;

namespace Coursework.Forms
{
    public partial class SplashScreen : Form
    {
        public Form OnWayTo { get; set; }

        public SplashScreen(Form OnWayTo)
        {
            InitializeComponent();
            FontHelper.ApplyFonts(this);
            this.OnWayTo = OnWayTo;
        }

        private void ppbLoading_Click(object sender, EventArgs e)
        {
            ppbLoading.Value += 5;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            label1.Text = OnWayTo.Text;
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
                this.Hide();
                FormHelper.s_registerScreen.Show();
            }
        }
    }
}
