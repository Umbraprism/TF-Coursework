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
        DragDrop
    }

    /// <summary>
    /// Holds information about each question in the quiz.
    /// </summary>
    public class Question
    {
        // Takes the question's image ID and outputs the corresponding image.
        private Dictionary<uint, Bitmap?> IdToImage { get; } = new()
        {
            {0, null },
            {1, Properties.Resources.soldierEmblem}
        };

        // Text of the question.
        public string Text { get; set; }

        // Type of the question used to create the correct type of screen.
        public QuestionType Type { get; set; }
        
        // Array of the possible answers for the question.
        public string[] Answers { get; set; }

        // Index of the correct answer to the question.
        public uint CorrectAnswerIndex { get; set; }

        // Holds the question's image, if necessary.
        public Bitmap? Image { get; set; }

        // Marks if the question is answered correctly.
        public bool IsCorrect { get; set; } = false;

        // Marks if the question is answered.
        public bool IsAnswered { get; set; } = false;

        // Backing field for the Image instantiation. Must be included so System.Text.Json can bind the property within the json to it.
        [JsonInclude]
        private uint imageId = 0;

        [JsonConstructor] // Marks this as the constructor used by System.Json.Text
        public Question(string text, string[] answers, QuestionType type, uint imageId)
        {
            Text = text;
            Answers = answers;
            Type = type;
            Image = IdToImage[imageId];
        }
    }
}
