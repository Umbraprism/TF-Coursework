namespace Coursework.ParentClasses
{
    public class Weapon
    {
        public Dictionary<int, Bitmap> idToWeaponImage = new()
        {
            {0, Properties.Resources.tfLogo}
        };

        public uint UsedBy { get; set; }
        public string Name { get; set; }
        public string Slot {  get; set; }
        public string Update { get; set; }
        public uint ImageId { get; set; }

        private uint usedBy;
        private string name;
        private string slot;
        private string update;
        private uint imageId;

        public Weapon() { }

        public Weapon(uint usedBy, string name, string slot, string update, uint imageId)
        {
            UsedBy = usedBy;
            Name = name;
            Slot = slot;
            Update = update;
            ImageId = imageId;
        }
    }
}
