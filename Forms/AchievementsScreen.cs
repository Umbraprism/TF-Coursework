using Coursework.Helpers;
using Coursework.UserControls;
using Coursework.ParentClasses;
using System.Drawing.Text;

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
            FontHelper.ApplyCursor(this, CursorStyle.TFClass);
            ttMyAchievementProgress.OwnerDraw = true;
            ttMyAchievementProgress.BackColor = Color.Green;

            ppbAchievementProgress.Maximum = FormHelper.s_quizPlayer.Achievements.Count;

            if (ppbAchievementProgress.Value == ppbAchievementProgress.Maximum)
            {
                ppbAchievementProgress.TextColour = FormHelper.s_ColourHashmap["Gold"];
                ppbAchievementProgress.ProgressColour = FormHelper.s_ColourHashmap["Gold"];
            }

            foreach (Achievement achievement in FormHelper.s_quizPlayer.Achievements)
            {
                flpAchievements.Controls.Add(new AchievementView(achievement));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.s_mainMenuScreen.Show();
        }

        private void ttMyAchievementProgress_Draw(object sender, DrawToolTipEventArgs e)
        {
            ToolTip toolTip = (ToolTip)sender;
            SolidBrush textBrush = new(toolTip.ForeColor);

            using (StringFormat sf = new())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                sf.HotkeyPrefix = HotkeyPrefix.None;
                sf.FormatFlags = StringFormatFlags.NoWrap;

                e.Graphics.Clear(toolTip.BackColor);
                e.Graphics.DrawString(e.ToolTipText, FontHelper.TF2Secondary, textBrush, new PointF(0, 0), sf);
            }
        }
    }
}
