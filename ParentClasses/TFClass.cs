using System.Text.Json.Serialization;

namespace Coursework.Classes
{
    public class TFClass
    {
        public static Dictionary<uint, Tuple<Bitmap?, Bitmap?, Bitmap?>> classToImage = new()
        {
            {0, new(null, null, null)},
            {1, new(Properties.Resources.scoutAva, null, Properties.Resources.scoutEmblem)},
            {2, new(Properties.Resources.soldierAva, null, Properties.Resources.soldierEmblem)},
            {3, new(Properties.Resources.pyroAva, null, Properties.Resources.pyroEmblem)},
            {4, new(Properties.Resources.demoAva, null, Properties.Resources.demoEmblem)},
            {5, new(Properties.Resources.hwgAva, null, Properties.Resources.hwgEmblem)},
            {6, new(Properties.Resources.engineerAva, null, Properties.Resources.engineerEmblem)},
            {7, new(Properties.Resources.medicAva, null, Properties.Resources.medicEmblem)},
            {8, new(Properties.Resources.sniperAva, null, Properties.Resources.sniperEmblem)},
            {9, new(Properties.Resources.spyAva, null, Properties.Resources.spyEmblem)}
        };

        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Ability ClassAbility { get; set; }

        public TFClass() { }

        public TFClass(uint Id)
        {
            this.Id = Id;

            switch (Id)
            {
                case 1:
                    this.Name = "Scout";
                    this.Description = "A fast running hooligan from Boston; Complete with bad attitude.";
                    this.ClassAbility = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!");
                    break;
                case 2:
                    this.Name = "Soldier";
                    this.Description = "A lead poisoned military-man who has, in fact, never been in the U.S. Army.";
                    break;
                case 3:
                    this.Name = "Pyro";
                    this.Description = "[REDACTED BY MANN. CO]";
                    break;
                case 4:
                    this.Name = "Demoman";
                    this.Description = "Uses his one good eye for well timed explosions. Uses his liver to distil alcohol.";
                    break;
                case 5:
                    this.Name = "Heavy";
                    this.Description = "Some people think they can outsmart him. Maybe. He has yet to meet someone who can outsmart a bullet.";
                    break;
                case 6:
                    this.Name = "Engineer";
                    this.Description = "A soft-spoken Texan with a knack for automatic machine gun turrets.";
                    break;
                case 7:
                    this.Name = "Medic";
                    this.Description = "A 'doctor' from Germany who frequently breaks the Hippocratic oath. In fact, he doesn't even have his medical license.";
                    break;
                case 8:
                    this.Name = "Sniper";
                    this.Description = "Coming from the sunken and lost land of New Zealand - but raised in the outback - he has a keen eye which is usually found planted in a scope.";
                    break;
                case 9:
                    this.Name = "Spy";
                    this.Description = "A dashing rogue hailing from who-knows-where in France. He has a penchant for dapper suits and even dapper-ier disguises.";
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
