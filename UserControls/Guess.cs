using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.UserControls
{
    public partial class Guess : UserControl
    {
        private Weapon guessedWeapon;
        private Weapon correctWeapon;

        public Guess(Weapon guessedWeapon, Weapon correctWeapon)
        {
            InitializeComponent();
            this.guessedWeapon = guessedWeapon;
            this.correctWeapon = correctWeapon;

            this.Anchor = AnchorStyles.Top;
        }

        private void Guess_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            lblGuessedWeapon.Text = guessedWeapon.Name;
            lblUsedBy.Text = TFClass.Assets[guessedWeapon.UsedBy].Name;
            lblSlot.Text = guessedWeapon.Slot;
            lblUpdate.Text = guessedWeapon.Update;
        }

        public bool CheckGuess()
        {
            if (guessedWeapon == correctWeapon)
            {
                return true;
            }

            else
            {
                if (guessedWeapon.Name != correctWeapon.Name)
                {
                    rpnlGuessedWeapon.PanelColour = UI.ColourPalette["Red"];
                    rpnlGuessedWeapon.BorderColour = UI.ColourPalette["Red"];
                }
                if (guessedWeapon.UsedBy != correctWeapon.UsedBy)
                {
                    rpnlUsedBy.PanelColour = UI.ColourPalette["Red"];
                    rpnlUsedBy.BorderColour = UI.ColourPalette["Red"];
                }
                if (guessedWeapon.Slot != correctWeapon.Slot)
                {
                    rpnlSlot.PanelColour = UI.ColourPalette["Red"];
                    rpnlSlot.BorderColour = UI.ColourPalette["Red"];
                }
                if (guessedWeapon.Update != correctWeapon.Update)
                {
                    rpnlUpdate.PanelColour = UI.ColourPalette["Red"];
                    rpnlUpdate.BorderColour = UI.ColourPalette["Red"];
                }
            }

            return false;
        }
    }
}
