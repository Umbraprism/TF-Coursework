namespace Coursework.ParentClasses
{
    public class Achievement
    {
        public string AchievementName { get; set; }
        public string AchievementDescription { get; set; }
        public bool IsRareAchievement { get; set; }
        public bool IsAchieved { get; set; }

        private string achievementName;
        private string achievementDescription;
        private bool isRareAchievement;
        private bool isAchieved;

        public Achievement(string achievementName, string achievementDescription, bool isRareAchievement, bool isAchieved)
        {
            AchievementName = achievementName;
            AchievementDescription = achievementDescription;
            IsRareAchievement = isRareAchievement;
            IsAchieved = isAchieved;
        }
    }
}
