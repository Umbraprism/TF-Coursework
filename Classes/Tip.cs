using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Tip
    {
        public string Text { get; set; }
        public uint TFClassId { get; set; }

        [JsonConstructor]
        public Tip(string text, uint tfClassId) 
        { 
            Text = text;
            TFClassId = tfClassId;
        }
    }
}
