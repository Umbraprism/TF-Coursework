using System.Drawing.Text;
using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.UserControls
{
    public partial class AchievementView : UserControl
    {
        private int percAchieved = 0;
        private Achievement achievement;

        public AchievementView(Achievement achievement)
        {
            InitializeComponent();

            this.achievement = achievement;

            this.lblAchievementName.Text = achievement.Name;
            this.lblAchievementDescription.Text = achievement.Description;

            foreach (Player player in Session.PlayerList)
            {
                if (PercentageAchieved() <= 10)
                {
                    achievement.IsRareAchievement = true;
                }
                else
                {
                    achievement.IsRareAchievement = false;
                }
            }

            if (achievement.IsAchieved)
            {
                this.pbIsAchieved.Image = Properties.Resources.achieved;
            }

            if (achievement.IsRareAchievement)
            {
                this.ttRareAchievement.SetToolTip(pbIsAchieved, $"This is a Rare Achievement. Less than 10% of players have achieved it./n/n{percAchieved}% of players have achieved this achievement.".Replace("/n", Environment.NewLine));
                this.pbIsAchieved.BackgroundImage = Properties.Resources.starburst;
                this.lblAchievementName.ForeColor = UI.ColourPalette["Gold"];
            }
        }

        private void AchievementView_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            pbIsAchieved.Height = 121; // ensures unlock indicator remains a consistent size
            pbIsAchieved.Width = 121;
        }

        private void ttRareAchievement_Draw(object sender, DrawToolTipEventArgs e)
        {
            ToolTip toolTip = (ToolTip)sender;
            SolidBrush textBrush = new(toolTip.ForeColor);

            using (StringFormat sf = new())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                e.Graphics.Clear(toolTip.BackColor);
                e.Graphics.DrawString(e.ToolTipText, UI.TF2Secondary, textBrush, e.Bounds, sf);
            }
        }

        private void ttRareAchievement_Popup(object sender, PopupEventArgs e)
        {
            string toolTip = ((ToolTip)sender).GetToolTip(e.AssociatedControl);

            Size textSize = TextRenderer.MeasureText(toolTip, UI.TF2Secondary);

            e.ToolTipSize = textSize;
        }

        private int PercentageAchieved()
        {
            int numAchieved = 0;

            for (int i = 0; i < Session.PlayerList.Count; i++)
            {
                Player player = Session.PlayerList[i];
                Achievement currentAchievement = player.Achievements.First(ach => ach.Name == achievement.Name);

                if (currentAchievement.IsAchieved)
                {
                    numAchieved++;
                }
            }

            percAchieved = (numAchieved * 100) / Session.PlayerList.Count;

            return percAchieved;
        }
    }
}
