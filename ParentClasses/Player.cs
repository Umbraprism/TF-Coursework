using System.Text.Json;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    public enum QuizScores
    {
        Weapons,
        TFClass,
        History,
        GuessingGame
    }

    public struct Scores
    {
        public int LatestScore { get; set; }
        public int HighestScore { get; set; }
        public string Rank { get; set; }

        public Scores(int latestScore, int highestScore, string? rank)
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
        public string Username { get; set; }
        public string Password { get; set; }
        public TFClass TFClass { get; set; }
        public List<Achievement> Achievements { get; set; }
        public Dictionary<QuizScores, Scores> ScoresHashmap 
        {
            get { return scoresHashmap; } 
            set { scoresHashmap = value; }
        }

        public Dictionary<QuizScores, Scores> scoresHashmap = new()
        {
            { QuizScores.Weapons, new(0, 0, String.Empty) },
            { QuizScores.TFClass, new(0, 0, String.Empty) },
            { QuizScores.History, new(0, 0, String.Empty) },
            { QuizScores.GuessingGame, new(0, 0, String.Empty) }
        };

        public Player() { }

        public Player(string username, string password, TFClass tfClass, uint id)
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
            List<Int32?> scores = new() { scoresHashmap[QuizScores.Weapons].HighestScore, scoresHashmap[QuizScores.Weapons].HighestScore, scoresHashmap[QuizScores.Weapons].HighestScore };

            return (int)scores.Max();
        }
    }
}
