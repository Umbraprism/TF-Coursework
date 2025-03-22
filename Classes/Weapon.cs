using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    public class Weapon
    {
        #region Field declarations
        public string Name { get; set; }
        public string Slot {  get; set; }
        public uint UsedBy { get; set; }
        public string Update { get; set; }
        public Bitmap? Image { get; set; }
        #endregion

        #region Constructor
        [JsonConstructor]
        public Weapon(string name, string slot, uint usedBy, string update)
        {
            Name = name;
            Slot = slot;
            UsedBy = usedBy;
            Update = update;
            Image = (Bitmap?)Bitmap.FromFile(@$"Weapons/{name.Replace(" ", "").ToLower()}.png");
        }
        #endregion
    }
}
