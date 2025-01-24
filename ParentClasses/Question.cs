namespace Coursework.ParentClasses
{
    public class Question
    {
        public Dictionary<int, Bitmap?> idToPhoto = new()
        {
            {0, null},
            {1, Properties.Resources.soldierEmblem}
        };

        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public string[] Answers { get; set; }
        public uint ImageId { get; set; }

        private string questionText;
        private string questionType;
        private string[] answers;
        private uint correctAnswerIndex;
        private uint imageId;

        public Question() { }

        public Question(string questionText, string[] answers, string questionType, uint imageId)
        {
            QuestionText = questionText;
            Answers = answers;
            QuestionType = questionType;
            ImageId = imageId;
        }
    }
}
