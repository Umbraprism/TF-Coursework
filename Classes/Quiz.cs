using Coursework.Extensions;
using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// Holds info on a quiz within the program.
    /// </summary>
    public class Quiz
    {
        #region Field declarations
        // Name of the quiz - e.g. Weapons Quiz.
        public string Name { get; set; } = String.Empty;

        // Type of the quiz used to apply appropriate scores.
        public QuizScores QuizType { get; set; }

        // Holds the time remaining in the quiz.
        public int TimeRemaining { get; set; }

        // The total time allocated for the quiz.
        public int TotalTime { get; set; }

        // Score gained in the quiz.
        public int Score { get; set; } = 0;

        // Marks if the user is 'disguised' (doing easier questions) - Used by the Spy TFClass.
        public bool IsDisguised { get; set; } = false;

        // Multiplier for score, which can be affected by some abilities.
        public double ScoreMultiplier { get; set; } = 0;

        // Index of the current question.
        public int CurrentQuestionIndex { get; set; } = 0;

        // Normal questions in the quiz.
        public List<Question> BaseQuestions { get; set; } = new();

        // Easier 'BLU' questions. Used by the Spy TFClass.
        public List<Question> EasyQuestions { get; set; } = new();

        // Holds a reference to the current difficulty.
        public List<Question> CurrentDifficulty { get; set; }

        // Used for RNG for shuffling questions.
        private Random rnd = new();
        #endregion

        #region Constructor
        // Constructor overload to hold an unassigned quiz.
        public Quiz() { CurrentDifficulty = BaseQuestions; }

        [JsonConstructor] // Marks this as the constructor used by System.Json.Text
        public Quiz(string name, QuizScores quizType,int timeRemaining, List<Question> baseQuestions, List<Question> easyQuestions)
        {
            Name = name;
            QuizType = quizType;
            TimeRemaining = timeRemaining;
            TotalTime = timeRemaining;

            // Shuffles the questions using an extension method.
            BaseQuestions = baseQuestions.Shuffle();
            EasyQuestions = easyQuestions.Shuffle();

            // Sets the current difficulty.
            CurrentDifficulty = BaseQuestions;
        }
        #endregion
    }
}
