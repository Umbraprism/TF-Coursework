namespace Coursework.ParentClasses
{
    [Serializable]
    public class Tip
    {
        public string Text { get; set; }
        public uint TFClassId { get; set; }

        public Tip() { }

        public Tip(string text, uint tfClassId) 
        { 
            Text = text;
            TFClassId = tfClassId;
        }
    }
}
