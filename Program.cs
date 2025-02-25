using System.Text.Json;
using Coursework.Forms;
using Coursework.Helpers;
using Coursework.ParentClasses;

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
            UIHelper.MakeFont();

            // Reads all text from 'tips.json' and deserializes the json string into an array of Tip objects
            using (StreamReader sr = new("tips.json"))
            {
                FormHelper.Tips = JsonSerializer.Deserialize<List<Tip>>(sr.ReadToEnd());
            }

            // Allows main form (in this case the first SplashScreen) to be closed without killing the application.
            // See https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.close?view=windowsdesktop-9.0x for more info about the Form.Close() method.
            new SplashScreen(FormHelper.RegisterScreen).Show();
            Application.Run();
        }
    }
}