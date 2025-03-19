using System.Text.Json.Serialization;
using Coursework.Extensions;

namespace Coursework.ParentClasses
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Slot {  get; set; }
        public uint UsedBy { get; set; }
        public string Update { get; set; }
        public Bitmap? Image { get; set; }

        [JsonConstructor]
        public Weapon(string name, string slot, uint usedBy, string update)
        {
            Name = name;
            Slot = slot;
            UsedBy = usedBy;
            Update = update;
            Image = (Bitmap?)Bitmap.FromFile(@$"Weapons/{name.Replace(" ", "").ToLower()}.png");
        }
    }
}
