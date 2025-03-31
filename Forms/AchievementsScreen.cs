using Coursework.Helpers;
using Coursework.UserControls;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class AchievementsScreen : Form
    {
        #region Constructor

        public AchievementsScreen()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void AchievementsScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);
            ttMyAchievementProgress.OwnerDraw = true;

            ppbAchievementProgress.Value = (Session.Player.Achievements.Where(achievement => achievement.IsAchieved).Count() * 100) / Session.Player.Achievements.Count;

            if (ppbAchievementProgress.Value == ppbAchievementProgress.Maximum)
            {
                ppbAchievementProgress.TextColour = UI.ColourPalette["Gold"];
                ppbAchievementProgress.ProgressColour = UI.ColourPalette["Gold"];
            }

            foreach (Achievement achievement in Session.Player.Achievements)
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
            UI.DrawToolTip(sender, e);
        }

        private void ttMyAchievementProgress_Popup(object sender, PopupEventArgs e)
        {
            UI.SizeToolTip(sender, e);
        }

        #endregion
    }
}
