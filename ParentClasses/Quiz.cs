using Coursework.Forms;
using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    public class Quiz
    {
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
            quizPath = Path.Combine(@$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Quizzes\", $"{quizType}.json");
        }

        public void CreateQuizForms()
        {
            foreach (Question question in baseQuestions)
            {
                switch (question.Type)
                {
                    case QuestionType.MultipleChoice:
                        baseQuizForms.Add(new MultipleChoiceScreen(question));
                        break;
                    case QuestionType.TrueFalse:
                        baseQuizForms.Add(new TrueFalseScreen(question));
                        break;
                    case QuestionType.DragDrop:
                        baseQuizForms.Add(new DragDropScreen(question));
                        break;
                    default:
                        break;
                }
            }

            foreach (Question question in easyQuestions)
            {
                switch (question.Type)
                {
                    case QuestionType.MultipleChoice:
                        easyQuizForms.Add(new MultipleChoiceScreen(question));
                        break;
                    case QuestionType.TrueFalse:
                        easyQuizForms.Add(new TrueFalseScreen(question));
                        break;
                    case QuestionType.DragDrop:
                        easyQuizForms.Add(new DragDropScreen(question));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
