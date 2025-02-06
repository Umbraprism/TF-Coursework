namespace Coursework.ParentClasses
{
    public class Weapon
    {
        public Dictionary<int, Bitmap> idToWeaponImage = new()
        {
            {0, Properties.Resources.tfLogo}
        };

        public string Name { get; set; }
        public string Slot {  get; set; }
        public uint UsedBy { get; set; }
        public string Update { get; set; }
        public uint ImageId { get; set; }

        public Weapon() { }

        public Weapon(string name, string slot, uint usedBy, string update, uint imageId)
        {
            Name = name;
            Slot = slot;
            UsedBy = usedBy;
            Update = update;
            ImageId = imageId;
        }
    }
}
