using System.Diagnostics;
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

            Question question = new("Test question text", new string[] {"True", "False"}, "TrueFalse", 1);
            Question question2 = new("Test question text 2", new string[] { "1", "2", "3", "4" }, "MultipleChoice", 1);
            Question question3 = new("Test question text 3", new string[] { "1", "2", "3", "4" }, "DragDrop", 1);

            List<Question> list = new List<Question>()
            {
                question,
                question2,
                question3
            };

            string json = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "test.json"));
            List<Question> questionL = JsonSerializer.Deserialize<List<Question>>(json);

            Debug.WriteLine(questionL[1].GetType());

            Application.Run(FormHelper.s_splashScreen);
        }
    }
}