using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// References the type of the question.
    /// </summary>
    public enum QuestionType
    {
        MultipleChoice,
        TrueFalse,
        DragDrop,
        GapFill
    }

    /// <summary>
    /// Holds information about each question in the quiz.
    /// </summary>
    public class Question
    {
        // Text of the question.
        public string Text { get; set; }

        // Type of the question used to create the correct type of screen.
        public QuestionType Type { get; set; }
        
        // Array of the possible answers for the question.
        public string[] Answers { get; set; }

        // Index of the correct answer to the question.
        public uint CorrectAnswerIndex { get; set; }

        // Marks if the question is answered correctly.
        public bool IsCorrect { get; set; } = false;

        // Marks if the question is answered.
        public bool IsAnswered { get; set; } = false;

        [JsonConstructor] // Marks this as the constructor used by System.Json.Text
        public Question(string text, string[] answers, QuestionType type, uint imageId)
        {
            Text = text;
            Answers = answers;
            Type = type;
        }
    }
}
