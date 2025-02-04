using Coursework.ParentClasses;
using Coursework.Forms;

namespace Coursework.Helpers
{
    public static class FormHelper
    {
        public static string s_playerJsonPath = Path.Combine(Environment.CurrentDirectory, "playerData.bin");
        public static string s_tipJsonPath = Path.Combine(Environment.CurrentDirectory, "tips.json");
        public static string s_achievementsJsonPath = Path.Combine(Environment.CurrentDirectory, "achievements.json");

        public static List<Player> s_playerList;
        public static Player s_quizPlayer;

        public static Dictionary<string, Color> s_ColourHashmap = new()
        {
            { "Background", Color.FromArgb(0, 0, 0) },
            { "BackgroundDark", Color.FromArgb(0, 0, 0) },
            { "BackgroundDarker", Color.FromArgb(0, 0, 0) },
            { "ButtonFace", Color.FromArgb(0, 0, 0) },
            { "Green", Color.FromArgb(0, 0, 0) },
            { "Text", Color.FromArgb(0, 0, 0) },
            { "Gold", Color.FromArgb(234, 185, 59) },
            { "Silver", Color.FromArgb(0, 0, 0) },
            { "Bronze", Color.FromArgb(0, 0, 0) }
        };

        public static Tip[] s_tips;

        public static RegisterScreen s_registerScreen = new();
        public static LoginScreen s_loginScreen = new();
        public static AnswerIndicationScreen s_answerIndicationScreen = new(0);
        public static AchievementsScreen s_achievementsScreen = new();
        public static GuessingGameScreen s_guessingGameScreen = new();
        public static LeaderboardScreen s_leaderboardScreen = new();
        public static MainMenuScreen s_mainMenuScreen = new();
        public static SplashScreen s_splashScreen = new(s_registerScreen);
        public static StatsScreen s_statsScreen = new();
    }
}
