using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{

    public enum QuestionType
    {
        MultipleChoice,
        TrueFalse,
        DragDrop
    }
    public class Question
    {
        private Dictionary<uint, Bitmap?> IdToImage { get; } = new()
        {
            {1, Properties.Resources.soldierEmblem}
        };

        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public string[] Answers { get; set; }
        public uint CorrectAnswerIndex { get; set; }
        public Bitmap? Image { get; set; }
        public bool IsCorrect { get; set; } = false;
        public bool IsAnswered { get; set; } = false;

        [JsonConstructor]
        public Question(string text, string[] answers, QuestionType type, uint imageId)
        {
            Text = text;
            Answers = answers;
            Type = type;
            Image = IdToImage[imageId];
        }
    }
}
