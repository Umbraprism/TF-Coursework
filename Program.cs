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

            UIHelper.MakeFont();
            using (StreamReader sr = new(FormHelper.s_tipJsonPath))
            {
                FormHelper.s_tips = JsonSerializer.Deserialize<Tip[]>(sr.ReadToEnd());
            }
            
            Application.Exit();
            string json = File.ReadAllText(Path.Combine(@$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Quizzes\", $"WeaponsQuiz.json"));
            Quiz testQuiz = JsonSerializer.Deserialize<Quiz>(json);
            testQuiz.CreateQuizForms();

            // Allows main form (in this case the first SplashScreen) to be closed without killing the application.
            // See https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.close?view=windowsdesktop-9.0x for more info about the Form.Close() method.
            //new SplashScreen(FormHelper.s_registerScreen).Show();
            new SplashScreen(FormHelper.s_registerScreen).Show();
            Application.Run();
        }
    }
}