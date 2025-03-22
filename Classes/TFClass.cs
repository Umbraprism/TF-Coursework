using System.Text.Json.Serialization;

namespace Coursework.ParentClasses
{
    public struct TFClassAssets
    {
        #region Field declarations
        public Bitmap Avatar { get; set; }
        public Bitmap Portrait { get; set; }
        public Bitmap Emblem { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public TFClassAssets(Bitmap avatar, Bitmap portrait, Bitmap emblem, string name)
        {
            Avatar = avatar;
            Portrait = portrait;
            Emblem = emblem;
            Name = name;
        }
        #endregion
    }

    [Serializable]
    public class TFClass
    {
        #region Field declarations
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Ability Ability { get; set; }
        public static Dictionary<uint, TFClassAssets> Assets
        {
            get
            {
                return assetsHashmap;
            }
        }

        private static Dictionary<uint, TFClassAssets> assetsHashmap = new()
        {
            {0, new(Properties.Resources.starburst, Properties.Resources.achieved, Properties.Resources.starburst, "Multiclass")},
            {1, new(Properties.Resources.scoutAva, Properties.Resources.achieved, Properties.Resources.scoutEmblem, "The Scout")},
            {2, new(Properties.Resources.soldierAva, Properties.Resources.soldierPortrait, Properties.Resources.soldierEmblem, "The Soldier")},
            {3, new(Properties.Resources.pyroAva, Properties.Resources.achieved, Properties.Resources.pyroEmblem, "The Pyro")},
            {4, new(Properties.Resources.demoAva, Properties.Resources.achieved, Properties.Resources.demoEmblem, "The Demoman")},
            {5, new(Properties.Resources.hwgAva, Properties.Resources.hwgPortrait, Properties.Resources.hwgEmblem, "The Heavy")},
            {6, new(Properties.Resources.engineerAva, Properties.Resources.achieved, Properties.Resources.engineerEmblem, "The Engineer")},
            {7, new(Properties.Resources.medicAva, Properties.Resources.achieved, Properties.Resources.medicEmblem, "The Medic")},
            {8, new(Properties.Resources.sniperAva, Properties.Resources.achieved, Properties.Resources.sniperEmblem, "The Sniper")},
            {9, new(Properties.Resources.spyAva, Properties.Resources.achieved, Properties.Resources.spyEmblem, "The Spy")}
        };
        #endregion

        #region Constructor
        [JsonConstructor]
        public TFClass(uint Id)
        {
            this.Id = Id;

            switch (Id)
            {
                case 1:
                    this.Name = "Scout";
                    this.Description = "A fast running hooligan from Boston; Complete with bad attitude.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 2:
                    this.Name = "Soldier";
                    this.Description = "A lead poisoned military-man who has, in fact, never been in the military at all.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 3:
                    this.Name = "Pyro";
                    this.Description = "A fire-loving mercenary of origins unknown. In fact, the only thing known about him is his penchant for setting things alight.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 4:
                    this.Name = "Demoman";
                    this.Description = "Uses his one good eye for well timed explosions. Uses his liver to distil alcohol.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 5:
                    this.Name = "Heavy";
                    this.Description = "Some people think they can outsmart him. Maybe. He has yet to meet someone who can outsmart a bullet.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 6:
                    this.Name = "Engineer";
                    this.Description = "A soft-spoken Texan with a knack for automatic machine gun turrets.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 7:
                    this.Name = "Medic";
                    this.Description = "A 'doctor' from Germany who frequently breaks the Hippocratic oath. In fact, he doesn't even have his medical license.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 8:
                    this.Name = "Sniper";
                    this.Description = "Coming from the sunken and lost land of New Zealand - but raised in the outback - he has a keen eye which is usually found planted in a scope.";
                    this.Ability = new("Double Jump", "Skip the question you're currently on and get it right immediately. Get 3 answers right to charge it again!", 3);
                    break;
                case 9:
                    this.Name = "Spy";
                    this.Description = "A dashing rogue hailing from who-knows-where in France. He has a penchant for dapper suits and even dapper-ier disguises.";
                    this.Ability = new("Disguise Kit", "'Disguise' to switch to  an easier set of BLU questions, but be careful - if you get a question wrong, your disguise will break and you will return to the normal questions.", 100);
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
        #endregion
    }
}
