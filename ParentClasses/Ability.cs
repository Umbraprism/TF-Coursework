using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Coursework.Forms;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Ability
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int ChargesRequired { get; set; }


        public int chargeLevel;
        private static int timesUsed = 0;

        [JsonConstructor]
        public Ability(string name, string info, int chargesRequired)
        {
            Name = name;
            Info = info;
            ChargesRequired = chargesRequired;
            chargeLevel = this.ChargesRequired;
        }

        public virtual void UseAbility(Form form, ref Quiz quiz, ref Question question)
        {
            switch (FormHelper.s_quizPlayer.TFClass.Id)
            {
                case 1:
                    if (chargeLevel == ChargesRequired)
                    {
                        question.isCorrect = true;
                        chargeLevel = 0;
                        timesUsed++;
                    }
                    break;

                    // skip question - 3 charge
                case 2:
                    if (chargeLevel == ChargesRequired)
                    {
                        quiz.scoreMultiplier = 2;
                        chargeLevel = 0;
                        timesUsed++;
                    }
                    break;
                // double points for three qus - 4 charge
                case 3:
                    if (chargeLevel == ChargesRequired)
                    {
                        if (quiz.CurrentDifficulty[quiz.currentQuestionIndex - 1].isCorrect)
                        {
                            quiz.scoreMultiplier = 2;
                            chargeLevel = 0;
                            timesUsed++;
                        }
                    }
                    break;
                // if previous qu correct triple points - 3 charge
                case 4:
                    break;
                    // plus 25% more points per question right but gone if answer wrong - passive
                case 5:
                    if (chargeLevel == ChargesRequired)
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

                        chargeLevel = 0;
                    }
                    break;
                //remove two incorrect - 2 charge
                case 6:
                    chargeLevel = 0;
                    throw new NotImplementedException();
                    // teleport to any qu - 3x uses
                case 7:
                    chargeLevel = 0;
                    throw new NotImplementedException();
                    // immunity for next three qus - once
                case 8:
                    chargeLevel = 0;
                    throw new NotImplementedException();
                    // immunity for one qu - 1 charge
                case 9:
                    quiz.CurrentDifficulty = quiz.EasyQuestions;
                    quiz.isDisguised = true;
                    break;
                    // 'disguise' to blu until question wrong - once
            }
        }
    }
}
