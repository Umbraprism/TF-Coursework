namespace Coursework.Classes
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
        public int ClassLatestScore { get; set; }
        public int ClassHighestScore { get; set; }
        public int HistoryLatestScore { get; set; }
        public int HistoryHighestScore { get; set; }

        public Player() { }
        public Player(string username, string password, TFClass tfClass, int id)
        {
            Username = username;
            Password = password;
            TFClass = tfClass;
            Id = id;
            Achievements = new List<Achievement>();
        }

        public int GetHighestScore()
        {
            List<Int32> scores = new() {WeaponsHighestScore, ClassHighestScore, HistoryHighestScore};

            return scores.Max();
        }
    }
}
