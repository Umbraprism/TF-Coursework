using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Coursework.Forms;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Ability
    {
        public string Name { get; private set; }
        public string Info { get; private set; }
        public int ChargesRequired { get; set; }
        public int ChargeLevel { get; set; }
        public int TimesUsed { get; set; }

        [JsonConstructor]
        public Ability(string name, string info, int chargesRequired)
        {
            Name = name;
            Info = info;
            ChargesRequired = chargesRequired;
            ChargeLevel = this.ChargesRequired;
        }

        public virtual void UseAbility(Form form, ref Quiz quiz, ref Question question)
        {
            switch (FormHelper.QuizPlayer.TFClass.Id)
            {
                case 1:
                    if (ChargeLevel == ChargesRequired)
                    {
                        question.IsCorrect = true;
                        ChargeLevel = 0;
                        TimesUsed++;
                    }
                    break;

                case 2:
                    if (ChargeLevel == ChargesRequired)
                    {
                        quiz.ScoreMultiplier = 2;
                        ChargeLevel = 0;
                        TimesUsed++;
                    }
                    break;
                case 3:
                    if (ChargeLevel == ChargesRequired)
                    {
                        if (quiz.CurrentDifficulty[quiz.CurrentQuestionIndex - 1].IsCorrect)
                        { 
                            quiz.ScoreMultiplier = 2;
                            ChargeLevel = 0;
                            TimesUsed++;
                        }
                    }
                    break;
                case 4:
                    quiz.ScoreMultiplier += 0.5;
                    break;
                case 5:
                    if (ChargeLevel == ChargesRequired)
                    {
                        int i = 0;

                        foreach (Control control in form.Controls)
                        {
                            if (control.Controls.Count > 0 && control.GetType() == typeof(TableLayoutPanel))
                            {
                                foreach (Button button in control.Controls)
                                {
                                    if (UInt32.Parse(control.Controls[i].Tag.ToString()) != question.CorrectAnswerIndex)
                                    {
                                        control.Controls[i].BackgroundImage = Properties.Resources.achieved;
                                    }

                                    i++;
                                }
                            }
                        }

                        ChargeLevel = 0;
                    }
                    break;
                case 6:
                    ChargeLevel = 0;
                    throw new NotImplementedException();
                    // teleport to any qu - 3x uses
                case 7:
                    ChargeLevel = 0;
                    throw new NotImplementedException();
                    // immunity for next three qus - once
                case 8:
                    ChargeLevel = 0;
                    throw new NotImplementedException();
                    // immunity for one qu - 1 charge
                case 9:
                    quiz.CurrentDifficulty = quiz.EasyQuestions;
                    quiz.IsDisguised = true;
                    break;
                    // 'disguise' to blu until question wrong - once
            }
        }
    }
}
