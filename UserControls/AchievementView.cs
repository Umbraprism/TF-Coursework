using System.Drawing.Text;
using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.UserControls
{
    public partial class AchievementView : UserControl
    {
        //private int percAchieved;

        public AchievementView(Achievement achievement)
        {
            InitializeComponent();

            this.lblAchievementName.Text = achievement.Name;
            this.lblAchievementDescription.Text = achievement.Description;

            foreach (Player player in FormHelper.PlayerList)
            {

            }

            if (achievement.IsAchieved)
            {
                this.pbIsAchieved.Image = Properties.Resources.achieved;
            }

            if (achievement.IsRareAchievement)
            {
                this.ttRareAchievement.SetToolTip(pbIsAchieved, "This is a Rare Achievement. Less than 10% of players have achieved it./n/n{percAchieved} of players have achieved this achievement.");
                this.pbIsAchieved.BackgroundImage = Properties.Resources.starburst;
                this.lblAchievementName.ForeColor = FormHelper.ColourPalette["Gold"];
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                this.BackColor = this.Parent.BackColor;
                this.ForeColor = this.Parent.ForeColor;
            }

            base.OnParentChanged(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                this.BackColor = this.Parent.BackColor;
                this.ForeColor = this.Parent.ForeColor;
            }
            base.OnParentBackColorChanged(e);
        }

        private void AchievementView_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            pbIsAchieved.Height = 121; // ensures unlock indicator remains a consistent size
            pbIsAchieved.Width = 121;
            this.BackColor = this.Parent.BackColor;
            this.ForeColor = this.Parent.ForeColor;
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
                e.Graphics.DrawString(e.ToolTipText, UIHelper.TF2Secondary, textBrush, e.Bounds, sf);
            }
        }

        private void ttRareAchievement_Popup(object sender, PopupEventArgs e)
        {
            string toolTip = ((ToolTip)sender).GetToolTip(e.AssociatedControl);

            Size textSize = TextRenderer.MeasureText(toolTip, UIHelper.TF2Secondary);

            e.ToolTipSize = textSize;
        }
    }
}
