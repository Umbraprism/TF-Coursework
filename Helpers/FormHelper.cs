using Coursework.ParentClasses;
using Coursework.Forms;

namespace Coursework.Helpers
{
    public static class FormHelper
    {
        public static Dictionary<string, Color> ColourPalette { get; } = new()
        {
            { "Background", Color.FromArgb(0, 0, 0) },
            { "BackgroundDark", Color.FromArgb(0, 0, 0) },
            { "BackgroundDarker", Color.FromArgb(0, 0, 0) },
            { "Text", Color.FromArgb(0, 0, 0) },
            { "Red", Color.FromArgb(189, 59, 59) },
            { "Green", Color.FromArgb(114, 158, 66) },
            { "Blue", Color.FromArgb(100, 142, 170) },
            { "Gold", Color.FromArgb(234, 185, 59) },
            { "Silver", Color.FromArgb(183, 173, 173) },
            { "Bronze", Color.FromArgb(171, 101, 71) },
            { "Unusual", Color.FromArgb(134, 80, 172) },
            { "Strange", Color.FromArgb(207, 106, 50) },
            { "Genuine", Color.FromArgb(77, 116, 85) },
            { "Vintage", Color.FromArgb(71, 98, 145) },
            { "Unique", Color.FromArgb(255, 215, 0) },
            { "Basic", Color.FromArgb(250, 250, 250) },
            { "Junk", Color.FromArgb(178, 178, 178) }
        };

        public static List<Tip> Tips { get; set; } = new();
        public static Quiz Quiz = new();
    }
}
