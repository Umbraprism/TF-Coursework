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
        public Dictionary<int, Bitmap?> idToPhoto = new()
        {
            {0, null},
            {1, Properties.Resources.soldierEmblem}
        };

        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public string[] Answers { get; set; }
        public uint ImageId { get; set; }

        private string questionText;
        private string questionType;
        private string[] answers;
        private uint correctAnswerIndex;
        private uint imageId;

        public Question() { }

        public Question(string questionText, string[] answers, QuestionType questionType, uint imageId)
        {
            Text = questionText;
            Answers = answers;
            Type = questionType;
            ImageId = imageId;
        }
    }
}
