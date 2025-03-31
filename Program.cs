using System.Text.Json;
using WMPLib;
using Coursework.Forms;
using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.Extensions;

namespace Coursework
{
    internal static class Program
    {
        public static WindowsMediaPlayer WMP { get; set; } = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Instantiates the custom fonts that will be utilised throughout the program
            UI.MakeUIElements();

            // Reads all text from 'tips.json' and deserializes the json string into an array of Tip objects
            using (StreamReader sr = new("tips.json"))
            {
                Session.Tips = JsonSerializer.Deserialize<List<Tip>>(sr.ReadToEnd());
            }

            WMP.settings.volume = 25;

            string[] music = Directory.GetFiles(@"Sounds/Music").Shuffle();

            IWMPPlaylist playlist = WMP.playlistCollection.newPlaylist("songs");

            foreach (string song in music)
            {
                playlist.appendItem(WMP.newMedia(song));
            }

            WMP.currentPlaylist = playlist;

            WMP.settings.setMode("shuffle", true);

            WMP.controls.play();

            // Allows main form (in this case the first SplashScreen) to be closed without killing the application.
            // See https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.close?view=windowsdesktop-9.0x for more info about the Form.Close() method.
            new SplashScreen(new RegisterScreen()).Show();
            Application.Run();
        }
    }
}