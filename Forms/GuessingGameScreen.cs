using System.Text.Json;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class GuessingGameScreen : Form
    {
        private Random rnd = new Random();

        private List<Weapon> weaponsList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText("Quizzes/GuessingGame.json"));

        private bool isEndless;
        private Weapon? weapon;
        private int guesses = 0;

        public GuessingGameScreen(bool isEndless)
        {
            InitializeComponent();
            this.isEndless = isEndless;

            if (!isEndless)
            {
                DateTime date = DateTime.Today.Date;
                rnd = new(date.Day + date.Month + date.Year);

                if (weaponsList != null)
                {
                    weapon = weaponsList[rnd.Next(0, weaponsList.Count - 1)];
                }
                else
                {
                    throw new FormatException("GuessingGame.json is formatted incorrectly.");
                }
            }
            else
            {
                if (weaponsList != null)
                {
                    weapon = weaponsList[rnd.Next(0, weaponsList.Count - 1)];
                }
            }
        }
    }
}
