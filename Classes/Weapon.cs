using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    public class Weapon
    {
        private Dictionary<uint, Bitmap> idToWeaponImage = new()
        {
            {1, Properties.Resources.tfLogo}
        };

        public string Name { get; set; }
        public string Slot {  get; set; }
        public uint UsedBy { get; set; }
        public string Update { get; set; }
        public Bitmap? Image { get; set; }

        [JsonInclude]
        private uint ImageId { get; set; }

        [JsonConstructor]
        public Weapon(string name, string slot, uint usedBy, string update, uint imageId)
        {
            Name = name;
            Slot = slot;
            UsedBy = usedBy;
            Update = update;
            ImageId = imageId;
            Image = idToWeaponImage[imageId];
        }
    }
}
