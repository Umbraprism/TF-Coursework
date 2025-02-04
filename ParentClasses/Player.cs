using System.Text.Json;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Player
    {
        public int Id { get; set; }
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

        private int id;
        private string username;
        private string password;
        private TFClass tfClass;
        private List<Achievement> achievements;

        private int weaponsLatestScore;
        public int weaponsHighestScore;
        public int tfClassLatestScore;
        public int tfClassHighestScore;
        public int historyLatestScore;
        public int historyHighestScore;

        public Player() { }
        public Player(string username, string password, TFClass tfClass, int id)
        {
            Username = username;
            Password = password;
            TFClass = tfClass;
            Id = id;

            string json = File.ReadAllText(FormHelper.s_achievementsJsonPath);
            Achievements = JsonSerializer.Deserialize<List<Achievement>>(json);
        }

        public int GetHighestScore()
        {
            List<Int32> scores = new() {weaponsHighestScore, tfClassHighestScore, historyHighestScore};

            return scores.Max();
        }
    }
}
