using System.Text.Json.Serialization;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// Holds info on achievements.
    /// </summary>
    public class Achievement
    {
        // Holds the name of the achievement.
        public string Name { get; set; }

        // Holds the description of the achievement.
        public string Description { get; set; }

        // Marks if the achievement is 'rare' (achieved by < 10% of players).
        public bool IsRareAchievement { get; set; } = false;

        // Marks if the user has achieved the achievement by meeting its conditions.
        public bool IsAchieved { get; set; }

        [JsonConstructor] // Marks this as the constructor used by System.Json.Text
        public Achievement(string name, string description, bool isAchieved)
        {
            Name = name;
            Description = description;
            IsAchieved = isAchieved;
        }
    }
}
