using Coursework.ParentClasses;
using Coursework.Forms;

namespace Coursework.Helpers
{
    public static class FormHelper
    {
        public static string s_playerJsonPath = Path.Combine(Environment.CurrentDirectory, "playerData.bin");
        public static string s_tipJsonPath = Path.Combine(Environment.CurrentDirectory, "tips.json");
        public static string s_achievementsJsonPath = Path.Combine(Environment.CurrentDirectory, "achievements.json");
        public static string s_quizJsonPath = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Quizzes\";

        public static List<Player> s_playerList;
        public static Player s_quizPlayer;

        public static Dictionary<string, Color> s_ColourHashmap = new()
        {
            { "Background", Color.FromArgb(0, 0, 0) },
            { "BackgroundDark", Color.FromArgb(0, 0, 0) },
            { "BackgroundDarker", Color.FromArgb(0, 0, 0) },
            { "Text", Color.FromArgb(0, 0, 0) },
            { "Red", Color.FromArgb(189, 59, 59) },
            { "Green", Color.FromArgb(114, 158, 66) },
            { "Blue", Color.FromArgb(100, 142, 170) },
            { "Gold", Color.FromArgb(234, 185, 59) },
            { "Silver", Color.FromArgb(183, 173, 173) },
            { "Bronze", Color.FromArgb(171, 101, 71) },
            { "Unusual", Color.FromArgb(134, 80, 172) },
            { "Strange", Color.FromArgb(207, 106, 50) },
            { "Genuine", Color.FromArgb(77, 116, 85) },
            { "Vintage", Color.FromArgb(134, 80, 172) },
            { "Unique", Color.FromArgb(255, 215, 0) },
            { "Basic", Color.FromArgb(250, 250, 250) },
            { "Junk", Color.FromArgb(178, 178, 178) }
        };

        public static Tip[] s_tips;
        public static Quiz s_currentQuiz;

        public static RegisterScreen s_registerScreen = new();
        public static LoginScreen s_loginScreen = new();
        public static AnswerIndicationScreen s_answerIndicationScreen = new(0);
        public static AchievementsScreen s_achievementsScreen = new();
        public static GuessingGameScreen s_guessingGameScreen = new();
        public static LeaderboardScreen s_leaderboardScreen = new();
        public static MainMenuScreen s_mainMenuScreen = new();
        public static SplashScreen s_splashScreen = new(s_registerScreen);
        public static StatsScreen s_statsScreen = new();

        public static void Shuffle<T>(this List<T> toShuffle)
        {
            Random rnd = new();

            for (int i = 0; i < toShuffle.Count; i++)
            {
                T store = toShuffle[i];
                toShuffle[i] = toShuffle[rnd.Next(0, toShuffle.Count)];
                toShuffle[rnd.Next(0, toShuffle.Count)] = store;
            }
        }
    }
}
