using System.Media;
using System.Text.Json.Serialization;
using Coursework.Helpers;
using WMPLib;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// Holds info on the user's TFCLass' ability, including a method to use it.
    /// </summary>
    [Serializable] // Allows serialization to binary file so it is not easily edited by the end-user. UNNEEDED?
    public class Ability
    {
        #region Field declarations

        public string Name { get; private set; }
        public string Info { get; private set; }
        public int ChargesRequired { get; set; }
        public int ChargeLevel { get; set; }
        public int TimesUsed { get; set; }

        #endregion

        #region Constructor

        [JsonConstructor] // Marks this as the constructor used by System.Json.Text
        public Ability(string name, string info, int chargesRequired)
        {
            Name = name;
            Info = info;
            ChargesRequired = chargesRequired;
            ChargeLevel = this.ChargesRequired;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Passes the quiz and question by reference, and enacts an ability dependent on the user's TFClass on the current question.
        /// </summary>
        public virtual void UseAbility(Form form, ref Quiz quiz, ref Question question)
        {
            switch (PlayerHelper.Player.TFClass.Id)
            {
                case 1:
                    if (ChargeLevel == ChargesRequired)
                    {
                        PlayVoiceline();

                        question.IsCorrect = true;
                        question.IsAnswered = true;
                        ChargeLevel = 0;
                        TimesUsed++;
                    }
                    break;

                case 2:
                    if (ChargeLevel == ChargesRequired)
                    {
                        PlayVoiceline();

                        quiz.ScoreMultiplier = 2;
                        ChargeLevel = 0;
                        TimesUsed++;
                    }
                    break;
                case 3:
                    if (ChargeLevel == ChargesRequired)
                    {
                        PlayVoiceline();

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
                        PlayVoiceline();

                        int i = 0;

                        foreach (Control control in form.Controls)
                        {
                            if (control.GetType() == typeof(TableLayoutPanel) && question.Type != QuestionType.GapFill)
                            {
                                foreach (Control answer in control.Controls)
                                {
                                    if (UInt32.Parse(answer.Controls[i].Tag.ToString()) != question.CorrectAnswerIndex)
                                    {
                                        answer.Controls[i].ForeColor = Color.DarkGray;
                                    }

                                    i++;
                                }
                            }
                        }

                        ChargeLevel = 0;
                        TimesUsed++;
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

        public void Reset()
        {
            this.ChargeLevel = this.ChargesRequired;
            this.TimesUsed = 0;
        }

        private void PlayVoiceline()
        {
            Random rnd = new();

            string[] vo = Directory.GetFiles(@$"Sounds/Classes/{PlayerHelper.Player.TFClass.Id}");

            WindowsMediaPlayer wmp = new();

            wmp.URL = vo[rnd.Next(1, vo.Length)];

            if (vo.Contains("auxillary"))
            {
                SoundPlayer sp = new();

                sp.SoundLocation = vo[0];
                sp.Play();
            }
        }

        #endregion
    }
}
