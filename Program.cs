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

            FontHelper.MakeFont();
            using (StreamReader sr = new(FormHelper.s_tipJsonPath))
            {
                FormHelper.s_tips = JsonSerializer.Deserialize<Tip[]>(sr.ReadToEnd());
            }

            Application.Run(FormHelper.s_splashScreen);
        }
    }
}