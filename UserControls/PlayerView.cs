using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.UserControls
{
    public partial class PlayerView : UserControl
    {
        private Player player;

        public PlayerView(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void PlayerView_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            pbAvatar.Image = TFClass.Assets[player.TFClass.Id].Avatar;
            lblUsername.Text = player.Username;
            lblRank.Text = player.OnlineRank;

            lblRank.ForeColor = UI.ColourPalette[lblRank.Text];
        }
    }
}
