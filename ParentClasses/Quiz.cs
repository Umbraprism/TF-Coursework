using Coursework.Extensions;
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
        public int TotalTime { get; set; }
        public int Score { get; set; } = 0;
        public bool IsDisguised { get; set; } = false;
        public double ScoreMultiplier { get; set; } = 0;
        public int CurrentQuestionIndex { get; set; } = 0;

        public List<Question> BaseQuestions { get; set; } = new List<Question>();
        public List<Question> EasyQuestions { get; set; } = new List<Question>();
        public List<Question> CurrentDifficulty { get; set; }

        private Random rnd = new();

        [JsonConstructor]
        public Quiz(string name, QuizScores quizType,int timeRemaining, List<Question> baseQuestions, List<Question> easyQuestions)
        {
            Name = name;
            QuizType = quizType;
            TimeRemaining = timeRemaining;
            TotalTime = timeRemaining;

            for (int i = 0; i < 5; i++)
            {
                int rndQuestionIndex = rnd.Next(i, baseQuestions.Count - 1);

                BaseQuestions.Add(baseQuestions[rndQuestionIndex]);
                //EasyQuestions.Add(easyQuestions[rndQuestionIndex]);

                baseQuestions.RemoveAt(rndQuestionIndex);
                //easyQuestions.RemoveAt(rndQuestionIndex);
            }

            BaseQuestions.Shuffle();
            EasyQuestions.Shuffle();

            CurrentDifficulty = BaseQuestions;
        }
    }
}
