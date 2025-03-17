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
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

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
                    rpnlGuessedWeapon.PanelColour = FormHelper.ColourPalette["Red"];
                    rpnlGuessedWeapon.BorderColour = FormHelper.ColourPalette["Red"];
                }
                if (guessedWeapon.UsedBy != correctWeapon.UsedBy)
                {
                    rpnlUsedBy.PanelColour = FormHelper.ColourPalette["Red"];
                    rpnlUsedBy.BorderColour = FormHelper.ColourPalette["Red"];
                }
                if (guessedWeapon.Slot != correctWeapon.Slot)
                {
                    rpnlSlot.PanelColour = FormHelper.ColourPalette["Red"];
                    rpnlSlot.BorderColour = FormHelper.ColourPalette["Red"];
                }
                if (guessedWeapon.Update != correctWeapon.Update)
                {
                    rpnlUpdate.PanelColour = FormHelper.ColourPalette["Red"];
                    rpnlUpdate.BorderColour = FormHelper.ColourPalette["Red"];
                }
            }

            return false;
        }
    }
}
