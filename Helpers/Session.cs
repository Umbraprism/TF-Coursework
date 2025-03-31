using Coursework.ParentClasses;

namespace Coursework.Helpers
{
    public static class Session
    {
        public static Player Player { get; set; }
        public static List<Player> PlayerList { get; set; } = new();
        public static List<Tip> Tips { get; set; } = new();
        public static Quiz Quiz = new();
    }
}
