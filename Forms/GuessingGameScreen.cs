namespace Coursework.Forms
{
    public partial class GuessingGameScreen : Form
    {
        private bool isEndless;
        public GuessingGameScreen(bool isEndless)
        {
            InitializeComponent();
            this.isEndless = isEndless;
        }
    }
}
