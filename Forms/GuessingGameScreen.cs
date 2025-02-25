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
        private int guessCount = 1;
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

        private void GuessingGameScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            if  (weapon != null && weapon.Image != null)
            {
                Bitmap silhouette = (Bitmap)weapon.Image.Clone();

                pbImage.Image = silhouette.Silhoutte(Color.Black);
            }
        }

        private void tbGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && weapon != null)
            {
                if (guessCount >= 3)
                {
                    pbImage.Image = weapon.Image;
                }

                try
                {
                    guess = new(weaponsList.Where(weapon => weapon.Name.ToUpper() == tbGuess.Text.ToUpper()).First(), weapon);
                }
                catch (InvalidOperationException)
                {
                    TFMessageBox.Show("invalid", "bruh!");
                    tbGuess.Text = String.Empty;

                    return;
                }

                bool isCorrect = guess.CheckGuess();

                if (isCorrect)
                {
                    tlpGuesses.Controls.Add(guess);

                    tbGuess.Text = String.Empty;
                    guessCount++;

                    if (guessCount < PlayerHelper.QuizPlayer.ScoresHashmap[QuizScores.GuessingGame].LowestGuessAmount)
                    {
                        PlayerHelper.QuizPlayer.ScoresHashmap[QuizScores.GuessingGame].HighestScore = guessCount;
                    }

                    PlayerHelper.QuizPlayer.ScoresHashmap[QuizScores.GuessingGame].LatestGuessAmount = guessCount;

                    if (isEndless)
                    {
                        DialogResult keepGuessingQuery = TFMessageBox.Show($"Well done! You guessed the weapon {weapon.Name} correctly! Would you like to keep guessing?", "Congrats!", TFMessageBoxButtons.YesAndNo);

                        if (keepGuessingQuery == DialogResult.Yes)
                        {
                            // Assigns new weapon
                        }
                        else
                        {
                            streak++;

                            if (streak > PlayerHelper.QuizPlayer.ScoresHashmap[QuizScores.GuessingGame].HighestStreak)
                            {
                                PlayerHelper.QuizPlayer.ScoresHashmap[QuizScores.GuessingGame].HighestStreak = streak;
                            }

                            PlayerHelper.QuizPlayer.ScoresHashmap[QuizScores.GuessingGame].CurrentStreak = streak;

                            this.Close();
                            FormHelper.MainMenuScreen.Show();
                        }
                    }
                    else
                    {
                        TFMessageBox.Show($"Well done! You guessed the weapon {weapon.Name} correctly! Click 'OK' to return to the main menu.", "Congrats!");

                        this.Close();
                        FormHelper.MainMenuScreen.Show();
                    }
                }
                else
                {
                    tlpGuesses.Controls.Add(guess);

                    tbGuess.Text = String.Empty;
                    guessCount++;
                }
            }
        }
    }
}
