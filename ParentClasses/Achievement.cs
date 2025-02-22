using System.Text.Json.Serialization;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    public class Achievement
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsRareAchievement { get; set; } = false;
        public bool IsAchieved { get; set; }

        [JsonConstructor]
        public Achievement(string name, string description, bool isAchieved)
        {
            Name = name;
            Description = description;
            IsAchieved = isAchieved;
        }
    }
}
