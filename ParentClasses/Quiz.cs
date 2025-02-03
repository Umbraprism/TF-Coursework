using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Coursework.ParentClasses
{
    public class Quiz
    {
        public List<Question> BaseQuestions { get; set; }
        public List<Question> EasyQuestions { get; set; }

        [JsonIgnore]
        private List<Form> baseQuizForms = new();
        [JsonIgnore]
        private List<Form> easyQuizForms = new();
        [JsonIgnore]
        private string quizPath;

        private List<Question> baseQuestions = new();
        private List <Question> easyQuestions = new();

        public Quiz() { }

        public Quiz(string quizType)
        {
            quizPath = Path.Combine(@$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Quizzes\", $"{quizType}.bin");
        }

        public void CreateQuizForms()
        {
            foreach (Question question in baseQuestions)
            {
                switch (question.QuestionType)
                {
                    case "MutlipleChoice":

                    default:
                        break;
                }
            }
        }
    }
}
