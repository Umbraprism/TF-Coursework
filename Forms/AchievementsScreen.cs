using Coursework.Helpers;
using Coursework.UserControls;
using Coursework.ParentClasses;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class AchievementsScreen : Form
    {
        private int achieved = 0;

        public AchievementsScreen()
        {
            InitializeComponent();
        }

        private void AchievementsScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);
            ttMyAchievementProgress.OwnerDraw = true;

            ppbAchievementProgress.Value = (PlayerHelper.Player.Achievements.Where(achievement => achievement.IsAchieved).Count() * 100) / PlayerHelper.Player.Achievements.Count;

            if (ppbAchievementProgress.Value == ppbAchievementProgress.Maximum)
            {
                ppbAchievementProgress.TextColour = FormHelper.ColourPalette["Gold"];
                ppbAchievementProgress.ProgressColour = FormHelper.ColourPalette["Gold"];
            }

            foreach (Achievement achievement in PlayerHelper.Player.Achievements)
            {
                flpAchievements.Controls.Add(new AchievementView(achievement));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenuScreen().Show();
        }

        private void ttMyAchievementProgress_Draw(object sender, DrawToolTipEventArgs e)
        {
            UIHelper.DrawToolTip(sender, e);
        }

        private void ttMyAchievementProgress_Popup(object sender, PopupEventArgs e)
        {
            UIHelper.SizeToolTip(sender, e);
        }
    }
}
