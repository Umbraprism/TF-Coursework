using System.Drawing.Text;
using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.UserControls
{
    public partial class AchievementView : UserControl
    {
        public AchievementView(Achievement achievement)
        {
            InitializeComponent();

            this.lblAchievementName.Text = achievement.Name;
            this.lblAchievementDescription.Text = achievement.Description;

            if (achievement.IsAchieved)
            {
                this.pbIsAchieved.Image = Properties.Resources.achieved;
            }

            if (achievement.IsRareAchievement)
            {
                this.ttRareAchievement.SetToolTip(pbIsAchieved, "This is a Rare Achievement. Less than 10% of players have achieved it.");
                this.pbIsAchieved.BackgroundImage = Properties.Resources.starburst;
                this.lblAchievementName.ForeColor = FormHelper.s_ColourHashmap["Gold"];
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                this.BackColor = this.Parent.BackColor;
            }

            base.OnParentChanged(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                this.BackColor = this.Parent.BackColor;
            }
            base.OnParentBackColorChanged(e);
        }

        private void AchievementView_Load(object sender, EventArgs e)
        {
            FontHelper.ApplyFonts(this);
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
                sf.HotkeyPrefix = HotkeyPrefix.None;
                sf.FormatFlags = StringFormatFlags.NoWrap;

                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                e.Graphics.Clear(toolTip.BackColor);
                e.Graphics.DrawString(e.ToolTipText, FontHelper.TF2Secondary, textBrush, e.Bounds);
            }
        }

        private void ttRareAchievement_Popup(object sender, PopupEventArgs e)
        {
            string toolTip = ((ToolTip)sender).GetToolTip(e.AssociatedControl);

            Size textSize = TextRenderer.MeasureText(toolTip, FontHelper.TF2Secondary);

            e.ToolTipSize = textSize;
        }
    }
}
