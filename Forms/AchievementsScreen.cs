using Coursework.Helpers;
using Coursework.UserControls;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class AchievementsScreen : Form
    {
        public AchievementsScreen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void AchievementsScreen_Load(object sender, EventArgs e)
        {
            FontHelper.ApplyFonts(this);

            if (ppbAchievementProgress.Value == ppbAchievementProgress.Maximum)
            {
                ppbAchievementProgress.TextColour = FormHelper.s_ColourHashmap["Gold"];
                ppbAchievementProgress.ProgressColour = FormHelper.s_ColourHashmap["Gold"];
            }

            for (int i = 0; i < 100; i++)
            {
                Achievement achieve = new Achievement($"{i}", "This is the achievement's description.", false, false);
                Random rnd = new Random();
                int chance = rnd.Next(0, 2);

                if (chance == 0)
                {
                    achieve.IsAchieved = true;
                }

                chance = rnd.Next(0, 2);

                if (chance == 0)
                {
                    achieve.IsRareAchievement = true;
                }

                AchievementView view = new(achieve);

                flpAchievements.Controls.Add(view);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.s_mainMenuScreen.Show();
        }
    }
}
