using Coursework.ParentClasses;
using Coursework.Forms;

namespace Coursework.Helpers
{
    public static class FormHelper
    {
        public static string s_playerJsonPath = Path.Combine(Environment.CurrentDirectory, "playerData.bin");
        public static string s_tipJsonPath = Path.Combine(Environment.CurrentDirectory, "tips.json");
        public static Player s_quizPlayer;

        public static Tip[] s_tips;

        public static RegisterScreen s_registerScreen = new();
        public static LoginScreen s_loginScreen = new();
        public static DragDropScreen s_dragDropScreen = new();
        public static AnswerIndicationScreen s_answerIndicationScreen = new();
        public static AchievementsScreen s_achievementsScreen = new();
        public static GuessingGameScreen s_guessingGameScreen = new();
        public static LeaderboardScreen s_leaderboardScreen = new();
        public static MainMenuScreen s_mainMenuScreen = new();
        public static MultipleChoiceScreen s_multipleChoiceScreen = new();
        public static SplashScreen s_splashScreen = new(s_registerScreen);
        public static StatsScreen s_statsScreen = new();
        public static TrueFalseScreen s_trueFalseScreen = new();
    }
}
