using System.Text.Json;
using Coursework.Exceptions;
using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// References the type of score to be drawn.
    /// </summary>
    public enum QuizScores
    {
        Weapons,
        TFClass,
        History,
        GuessingGame
    }

    /// <summary>
    /// Holds information on a Player within the quiz.
    /// </summary>
    [Serializable] // Allows serialization to binary file so it is not easily edited by the end-user.
    public class Player
    {
        // Holds a primary key, which is the user's ID.
        public uint Id { get; set; }

        // Holds the Player's username, whilst checking if it is valid.
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

        // Holds the Player's password, whilst checking if it is valid.
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

        // Holds the Player's TFClass, holding info on their selection during registration.
        public TFClass TFClass { get; set; }

        // Holds the Player's achievements.
        public List<Achievement> Achievements { get; set; } = new();

        // Allows getting and setting of the hashmap responsible for holding the Player's scores. Takes a QuizScores as the key and outputs a Scores object.
        public Dictionary<QuizScores, Scores> ScoresHashmap 
        {
            get { return scoresHashmap; } 
            set { scoresHashmap = value; }
        }

        // Holds the user's rank in the online mode. Starts at 3, but can be progressed through peer to peer LAN matches.
        public string OnlineRank { get; set; } = "Junk";


        // Backing fields for Username and Password properties
        private string username = String.Empty;
        private string password = String.Empty;

        // Backing hashmap for the ScoresHashmap property.
        private Dictionary<QuizScores, Scores> scoresHashmap = new()
        {
            { QuizScores.Weapons, new(0, 0, "Junk", 0, 0, 0, 0) },
            { QuizScores.TFClass, new(0, 0, "Junk", 0, 0, 0, 0) },
            { QuizScores.History, new(0, 0, "Junk", 0, 0, 0, 0) },
            { QuizScores.GuessingGame, new(0, 0, "Junk", 0, 0, 0, 0) }
        };

        [JsonConstructor] // Marks this as the constructor used by System.Json.Text
        public Player(string username, string password, TFClass tfClass, uint id, Dictionary<QuizScores, Scores>? scoresHashmap, List<Achievement> achievements)
        {
            Username = username;
            Password = password;
            TFClass = tfClass;
            Id = id;

            Achievements = achievements;

            // Checks if scoresHashmap is null, otherwise takes from parameter. (Will be null at registration to give default values).
            if (scoresHashmap == null)
            { 
                ScoresHashmap = this.scoresHashmap;
            }
            else
            {
                ScoresHashmap = scoresHashmap;
            }
        }

        /// <summary>
        /// Gets the highest score out of every quiz.
        /// </summary>
        public int GetHighestScore()
        {
            List<Int32> scores = new() { scoresHashmap[QuizScores.Weapons].HighestScore, scoresHashmap[QuizScores.Weapons].HighestScore, scoresHashmap[QuizScores.Weapons].HighestScore };

            return (int)scores.Max();
        }

        /// <summary>
        /// Checks if the username entered is valid.
        /// </summary>
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

        /// <summary>
        /// Checks if the password entered is valid.
        /// </summary>
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

    public class Scores
    {
        public int LatestScore { get; set; } = 0;
        public int HighestScore { get; set; } = 0;
        public string Rank { get; set; } = "Junk";

        public int LatestGuessAmount { get; set; } = 0;
        public int LowestGuessAmount { get; set; } = 0;
        public int CurrentStreak { get; set; } = 0;
        public int HighestStreak { get; set; } = 0;

        public Scores(int latestScore, int highestScore, string rank, int latestGuessAmount, int lowestGuessAmount, int currentStreak, int highestStreak)
        {
            LatestScore = latestScore;
            HighestScore = highestScore;
            Rank = rank;

            LatestGuessAmount = latestGuessAmount;
            LowestGuessAmount = lowestGuessAmount;
            CurrentStreak = currentStreak;
            HighestStreak = highestStreak;
        }
    }
}
