using System.Text.Json;
using Coursework.Helpers;
using Coursework.Exceptions;
using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    public enum QuizScores
    {
        Weapons,
        TFClass,
        History,
        GuessingGame
    }

    public class Scores
    {
        public int LatestScore { get; set; } = 0;
        public int HighestScore { get; set; } = 0;
        public string Rank { get; set; } = String.Empty;

        public Scores(int latestScore, int highestScore, string rank)
        {
            LatestScore = latestScore;
            HighestScore = highestScore;
            Rank = rank;
        }
    }

    [Serializable]
    public class Player
    {
        public uint Id { get; set; }

        public string Username 
        { 
            get
            {
                if (username != null)
                {
                    return username;
                }

                return String.Empty;
            }
            set
            {
                if (IsValidUsername(value))
                {
                    username = value;
                }
                else
                {
                    throw new InvalidUsernameException();
                }
            }
        }

        public string Password
        {
            get
            {
                if (password != null)
                {
                    return password;
                }

                return String.Empty;
            }
            set
            {
                if (IsValidPassword(value))
                {
                    password = value;
                }
                else
                {
                    throw new InvalidPasswordException();
                }
            }
        }

        public TFClass TFClass { get; set; }
        public List<Achievement>? Achievements { get; set; }
        public Dictionary<QuizScores, Scores> ScoresHashmap 
        {
            get { return scoresHashmap; } 
            set { scoresHashmap = value; }
        }

        private string? username;
        private string? password;

        private Dictionary<QuizScores, Scores> scoresHashmap = new()
        {
            { QuizScores.Weapons, new(0, 0, String.Empty) },
            { QuizScores.TFClass, new(0, 0, String.Empty) },
            { QuizScores.History, new(0, 0, String.Empty) },
            { QuizScores.GuessingGame, new(0, 0, String.Empty) }
        };

        [JsonConstructor]
        public Player(string username, string password, TFClass tfClass, uint id, Dictionary<QuizScores, Scores>? scoresHashmap)
        {
            Username = username;
            Password = password;
            TFClass = tfClass;
            Id = id;

            string json = File.ReadAllText(FormHelper.AchievementsJsonPath);
            Achievements = JsonSerializer.Deserialize<List<Achievement>>(json);

            if (scoresHashmap == null)
            { 
                ScoresHashmap = this.scoresHashmap;
            }
            else
            {
                ScoresHashmap = scoresHashmap;
            }
        }

        public int GetHighestScore()
        {
            List<Int32?> scores = new() { scoresHashmap[QuizScores.Weapons].HighestScore, scoresHashmap[QuizScores.Weapons].HighestScore, scoresHashmap[QuizScores.Weapons].HighestScore };

            return (int)scores.Max();
        }

        private bool IsValidUsername(string value)
        {
            if (!String.IsNullOrEmpty(value) && value.Length >= 3 && value.Length < 20)
            {
                return true;
            }
            
            foreach (char character in value)
            {
                if (character == ' ')
                {
                    return false;
                }
            }

            return false;
        }

        private bool IsValidPassword(string value)
        {
            int capitalCount = 0;
            int lowercaseCount = 0;
            int numberCount = 0;
            int specialCount = 0;

            if (String.IsNullOrEmpty(value) || value.Length < 8)
            {
                return false;
            }

            foreach(char character in value)
            {
                if (Char.IsDigit(character))
                {
                    numberCount++;
                }
                if (Char.IsSymbol(character) || Char.IsPunctuation(character))
                {
                    specialCount++;
                }
                if (Char.IsUpper(character))
                {
                    capitalCount++;
                }
                if (Char.IsLower(character))
                {
                    lowercaseCount++;
                }
            }

            if (capitalCount > 0 && lowercaseCount > 0 && numberCount > 0 && specialCount > 0)
            {
                return true;
            }

            return false;
        }

        public int CompareTo(object? obj)
        {
            try
            {
                Player? player = (Player?)obj;

                return 0;
            }
            catch (InvalidCastException)
            {
                throw;
            }
        }
    }
}
