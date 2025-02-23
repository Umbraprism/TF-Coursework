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
                    lblGuessedWeapon.BackColor = FormHelper.ColourPalette["Red"];
                }
                if (guessedWeapon.UsedBy != guessedWeapon.UsedBy)
                {
                    rpnlUsedBy.PanelColour = FormHelper.ColourPalette["Red"];
                    lblUsedBy.BackColor = FormHelper.ColourPalette["Red"];
                }
                if (guessedWeapon.Slot != correctWeapon.Slot)
                {
                    rpnlSlot.PanelColour = FormHelper.ColourPalette["Red"];
                    lblSlot.BackColor = FormHelper.ColourPalette["Red"];
                }
                if (guessedWeapon.Update != correctWeapon.Update)
                {
                    rpnlUpdate.PanelColour = FormHelper.ColourPalette["Red"];
                    lblUpdate.BackColor = FormHelper.ColourPalette["Red"];
                }
            }

            return false;
        }
    }
}
