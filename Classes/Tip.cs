using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Tip
    {
        #region Field declarations
        public string Text { get; set; }
        public uint TFClassId { get; set; }
        #endregion

        #region Constructor
        [JsonConstructor]
        public Tip(string text, uint tfClassId) 
        { 
            Text = text;
            TFClassId = tfClassId;
        }
        #endregion
    }
}
