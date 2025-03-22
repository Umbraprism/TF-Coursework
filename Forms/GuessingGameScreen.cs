using System.Text.Json;
using Coursework.Extensions;
using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class GuessingGameScreen : Form
    {
        private Random rnd = new Random();

        private List<Weapon> weaponsList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText("Quizzes/GuessingGame.json"));

        private bool isEndless;

        private Weapon? weapon;
        private Bitmap? silhouette;

        private int guessCount = 0;
        private int streak = 0;

        private Guess? guess;

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
                    weapon = weaponsList[rnd.Next(0, weaponsList.Count)];
                }
                else
                {
                    throw new FormatException("GuessingGame.json is formatted incorrectly.");
                }
            }
            else
            {
                btnBack.Visible = true;

                if (weaponsList != null)
                {
                    weapon = weaponsList[rnd.Next(0, weaponsList.Count)];
                }
            }

            AutoCompleteStringCollection autoCompleteWeapon = [];

            foreach (Weapon weapon in weaponsList)
            {
                autoCompleteWeapon.Add(weapon.Name);
            }

            cbGuess.DataSource = autoCompleteWeapon;

            cbGuess.AutoCompleteCustomSource = autoCompleteWeapon;
            cbGuess.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbGuess.AutoCompleteMode = AutoCompleteMode.Append;

            ResetLabels();
        }

        private void GuessingGameScreen_Load(object? sender, EventArgs? e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            cbGuess.Text = String.Empty;

            if (weapon != null && weapon.Image != null)
            {
                silhouette = (Bitmap)weapon.Image.Silhoutte(Color.Black);

                pbImage.Image = silhouette;
            }
        }

        private void cbGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && weapon != null)
            {
                try
                {
                    guess = new(weaponsList.Where(weapon => weapon.Name.ToUpper() == cbGuess.Text.ToUpper()).First(), weapon);
                }
                catch (InvalidOperationException)
                {
                    TFMessageBox.Show("The weapon guessed does not exist.", "Invalid Weapon");
                    return;
                }

                guessCount++;

                ResetLabels();

                if (guessCount >= 3)
                {
                    pbImage.Image = weapon.Image;
                    lblGuessesUntilImage.Visible = false;
                }

                cbGuess.Text = String.Empty;

                bool isCorrect = guess.CheckGuess();

                tlpGuesses.Controls.Add(guess);
                tlpGuesses.Controls.SetChildIndex(guess, 0);

                if (isCorrect && isEndless)
                {
                    TFMessageBox.Show($"Congratulations! You have guessed the weapon correctly in {guessCount} guesses.", "Congratulations!");

                    int rndIndex = rnd.Next(0, weaponsList.Count);

                    weapon = weaponsList[rndIndex];

                    streak++;

                    ApplyScores();

                    guessCount = 0;

                    ResetLabels();

                    tlpGuesses.Controls.Clear();

                    return;
                }
                else if (isCorrect)
                {
                    TFMessageBox.Show($"Congratulations! You have guessed the weapon correctly in {guessCount} guesses.", "Congratulations!");

                    ApplyScores();

                    ResetLabels();

                    this.Close();
                    new MainMenuScreen().Show();
                }
            }
        }

        private void ApplyScores()
        {
            if (guessCount < PlayerHelper.Player.ScoresHashmap[QuizScores.GuessingGame].LowestGuessAmount || PlayerHelper.Player.ScoresHashmap[QuizScores.GuessingGame].LowestGuessAmount == 0)
            {
                PlayerHelper.Player.ScoresHashmap[QuizScores.GuessingGame].LowestGuessAmount = guessCount;
            }

            if (streak > PlayerHelper.Player.ScoresHashmap[QuizScores.GuessingGame].HighestStreak)
            {
                PlayerHelper.Player.ScoresHashmap[QuizScores.GuessingGame].HighestStreak = streak;
            }

            PlayerHelper.Player.ScoresHashmap[QuizScores.GuessingGame].LatestGuessAmount = guessCount;
            PlayerHelper.Player.ScoresHashmap[QuizScores.GuessingGame].CurrentStreak = streak;

            guessCount = 0;
        }

        private void ResetLabels()
        {
            lblGuessesUntilImage.Visible = true;
            lblGuessesUntilImage.Text = $"Weapon image will be fully revealed in {3 - guessCount} guesses.";
            lblGuessCount.Text = guessCount.ToString();

            if (weapon.Image != null)
            {
                silhouette = weapon.Image.Silhoutte(Color.Black);

                pbImage.Image = silhouette;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isEndless)
            {
                DialogResult backQuery = TFMessageBox.Show("Would you like to stop guessing weapons and return to the main menu?", "Are you sure?", TFMessageBoxButtons.YesAndNo);

                if (backQuery == DialogResult.Yes)
                {
                    ApplyScores();

                    this.Close();
                    new MainMenuScreen().Show();
                }
            }
        }
    }
}
