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
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);
            ttMyAchievementProgress.OwnerDraw = true;

            ppbAchievementProgress.Maximum = FormHelper.QuizPlayer.Achievements.Count;

            if (ppbAchievementProgress.Value == ppbAchievementProgress.Maximum)
            {
                ppbAchievementProgress.TextColour = FormHelper.ColourPalette["Gold"];
                ppbAchievementProgress.ProgressColour = FormHelper.ColourPalette["Gold"];
            }

            foreach (Achievement achievement in FormHelper.QuizPlayer.Achievements)
            {
                flpAchievements.Controls.Add(new AchievementView(achievement));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.MainMenuScreen.Show();
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
