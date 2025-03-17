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
            UIHelper.MakeUIElements();

            // Reads all text from 'tips.json' and deserializes the json string into an array of Tip objects
            using (StreamReader sr = new("tips.json"))
            {
                FormHelper.Tips = JsonSerializer.Deserialize<List<Tip>>(sr.ReadToEnd());
            }

            WindowsMediaPlayer wmp = new();

            wmp.settings.volume = 25;

            string[] music = Directory.GetFiles(@"Sounds/Music").Shuffle();

            IWMPPlaylist playlist = wmp.playlistCollection.newPlaylist("songs");

            foreach (string song in music)
            {
                playlist.appendItem(wmp.newMedia(song));
            }

            wmp.currentPlaylist = playlist;

            wmp.settings.setMode("shuffle", true);

            wmp.controls.play();

            // Allows main form (in this case the first SplashScreen) to be closed without killing the application.
            // See https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.close?view=windowsdesktop-9.0x for more info about the Form.Close() method.
            new SplashScreen(new RegisterScreen()).Show();
            Application.Run();
        }
    }
}