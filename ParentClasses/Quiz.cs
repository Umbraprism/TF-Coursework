using Coursework.Forms;
using Coursework.Helpers;
using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    public class Quiz
    {
        public string Name { get; set; }
        public QuizScores QuizType { get; set; }
        public int TimeRemaining { get; set; }
        public int Score { get; set; } = 0;
        public bool IsDisguised { get; set; } = false;
        public double ScoreMultiplier { get; set; } = 0;
        public int CurrentQuestionIndex { get; set; } = 0;

        public List<Question> BaseQuestions { get; set; }
        public List<Question> EasyQuestions { get; set; }
        public List<Question> CurrentDifficulty { get; set; }

        [JsonConstructor]
        public Quiz(string name, QuizScores quizType,int timeRemaining, List<Question> baseQuestions, List<Question> easyQuestions)
        {
            Name = name;
            QuizType = quizType;
            TimeRemaining = timeRemaining;
            BaseQuestions = baseQuestions;
            EasyQuestions = easyQuestions;

            BaseQuestions.Shuffle();
            EasyQuestions.Shuffle();

            CurrentDifficulty = BaseQuestions;
        }
    }
}
