using Coursework.Forms;
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
        private string quizPath;

        private List<Question> baseQuestions = new();
        private List <Question> easyQuestions = new();

        public bool isDisguised = false;
        public int scoreMultiplier = 0;
        public int currentQuestionIndex = 0;
        public List<Form> currentDifficulty;

        public Quiz() { }

        public Quiz(string name, List<Question> baseQuestions, List<Question> easyQuestions)
        {
            this.Name = name;
            this.BaseQuestions = baseQuestions;
            this.EasyQuestions = easyQuestions;
            currentDifficulty = baseQuizForms;
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
