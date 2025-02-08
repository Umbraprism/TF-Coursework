using Coursework.Forms;
using Coursework.Helpers;
using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    public class Quiz
    {
        public string Name { get; set; }
        public List<Question> BaseQuestions
        {
            get { return baseQuestions; }
            set { baseQuestions = value; }
        }
        public List<Question> EasyQuestions
        {
            get { return easyQuestions; }
            set { easyQuestions = value; }
        }

        public List<Form> baseQuizForms = new();
        public List<Form> easyQuizForms = new();

        public List<Question> baseQuestions = new();
        public List<Question> easyQuestions = new();

        public bool isDisguised = false;
        public int scoreMultiplier = 0;
        public int currentQuestionIndex = 0;

        public List<Question> CurrentDifficulty { get; set;  }

        [JsonConstructor]
        public Quiz(string name, List<Question> baseQuestions, List<Question> easyQuestions)
        {
            this.Name = name;
            this.BaseQuestions = baseQuestions;
            this.EasyQuestions = easyQuestions;

            baseQuestions.Shuffle();
            easyQuestions.Shuffle();

            CurrentDifficulty = BaseQuestions;
        }

        public void CreateQuiz()
        {
            baseQuestions.Shuffle();
            easyQuestions.Shuffle();

            CurrentDifficulty = BaseQuestions;
        }
    }
}
