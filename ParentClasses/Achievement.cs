namespace Coursework.ParentClasses
{
    public class Achievement
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsRareAchievement { get; set; }
        public bool IsAchieved { get; set; }

        public Achievement() { }

        public Achievement(string name, string description, bool isRareAchievement, bool isAchieved)
        {
            Name = name;
            Description = description;
            IsRareAchievement = isRareAchievement;
            IsAchieved = isAchieved;
        }
    }
}
