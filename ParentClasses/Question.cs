using System.Text.Json;
using Coursework.ChildClasses;

namespace Coursework.ParentClasses
{
    public abstract class Question
    {
        public Dictionary<int, Bitmap?> idToPhoto = new()
        {
            {0, null},
            {1, Properties.Resources.soldierEmblem}
        };

        public string QuestionText { get; set; }
        public string Type { get; set; }
        public uint ImageId { get; set; } 

        public Question() { }

        public Question(string questionText, string type, uint imageId)
        {
            QuestionText = questionText;
            Type = type;
            ImageId = imageId;
        }

        public Question JsonToQuestion(string jsonToDeserialize)
        {
            try
            {
                string jsonDirectory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Quizzes\{jsonToDeserialize}.bin";

                using (BinaryReader br = new(File.Open(jsonDirectory, FileMode.Open)))
                {
                    string json = br.ReadString();
                    List<Question> questionList = JsonSerializer.Deserialize<List<Question>>(json);

                    foreach (Question question in questionList)
                    {
                        switch (question.Type)
                        {
                            case "MultipleChoice":
                                return (MultipleChoiceQuestion)question;
                            case "TrueFalse":
                                return (TrueFalseQuestion)question;
                            case "DragDrop":
                                return (DragDropQuestion)question;
                            default:
                                throw new FormatException($"Question type: {question.Type} does not exist. Please ensure the question is either MultipleChoice, TrueFalse, or DragDrop.");
                        }
                    }
                }

            }
            catch (IOException)
            {
                throw new Exception("File not found. Please ensure the file is present and has not been deleted. If you have accidentally deleted the file, please recover from the Recycle Bin it and place it in the Quizzes folder in the main directory.");
            }

            throw new Exception("i dunno tbh");
        }
    }
}
