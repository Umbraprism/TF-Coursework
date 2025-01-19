using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Classes
{
    public class Weapon
    {
        public Dictionary<int, Bitmap> idToWeaponImage = new()
        {
            {0, Properties.Resources.tfLogo}
        };

        public int UsedBy { get; set; }
        public string Name { get; set; }
        public string Slot {  get; set; }
        public string Update { get; set; }
        public uint ImageId { get; set; }
    }
}
