using System.Text.Json;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Player
    {
        public uint Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public TFClass TFClass { get; set; }
        public List<Achievement> Achievements { get; set; }

        public int WeaponsLatestScore { get; set; }
        public int WeaponsHighestScore { get; set; }
        public string WeaponsRank { get; set; }
        public int TFClassLatestScore { get; set; }
        public int TFClassHighestScore { get; set; }
        public string TFClassRank { get; set; }
        public int HistoryLatestScore { get; set; }
        public int HistoryHighestScore { get; set; }
        public string HistoryRank { get; set; }
        public int GuessingGameLowestGuesses { get; set; }

        public Player() { }

        public Player(string username, string password, TFClass tfClass, uint id)
        {
            Username = username;
            Password = password;
            TFClass = tfClass;
            Id = id;

            string json = File.ReadAllText(FormHelper.s_achievementsJsonPath);
            Achievements = JsonSerializer.Deserialize<List<Achievement>>(json);

            WeaponsLatestScore = 0;
            WeaponsHighestScore = 0;
            WeaponsRank = String.Empty;
            HistoryLatestScore = 0;
            HistoryHighestScore = 0;
            HistoryRank = String.Empty;
            TFClassLatestScore = 0;
            TFClassHighestScore = 0;
            TFClassRank = String.Empty;
            GuessingGameLowestGuesses = 0;
        }

        public int GetHighestScore()
        {
            List<Int32> scores = new() {WeaponsHighestScore, TFClassHighestScore, HistoryHighestScore};

            return scores.Max();
        }
    }
}
