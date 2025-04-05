using System.Media;
using System.Text.Json.Serialization;
using Coursework.Helpers;
using WMPLib;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// Holds info on the user's TFClass' ability, including a method to use it.
    /// </summary>
    [Serializable] // Allows serialization to binary file so it is not easily edited by the end-user.
    public class Ability
    {
        #region Field declarations

        public string Name { get; private set; }
        public string Info { get; private set; }
        public int ChargesRequired { get; set; }
        [JsonIgnore]
        public int ChargeLevel { get; set; }
        [JsonIgnore]
        public int TimesUsed { get; set; }
        [JsonIgnore]
        public int Duration { get; set; } = 0;

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
            switch (Session.Player.TFClass.Id)
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
                        Duration = 3;
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
                            Duration = 1;
                            TimesUsed++;
                        }
                    }
                    break;
                case 4:
                    if (ChargeLevel == ChargesRequired)
                    {
                        PlayVoiceline();

                        if (quiz.CurrentDifficulty[quiz.CurrentQuestionIndex - 1].IsCorrect)
                        {
                            quiz.ScoreMultiplier = 5;

                            ChargeLevel = 0;
                            Duration = 1;
                            TimesUsed++;
                        }
                    }
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
                    if (ChargeLevel == ChargesRequired)
                    {
                        Random rnd = new();

                        List<Question> incorrectQuestions = quiz.CurrentDifficulty.Where(question => question.IsAnswered && !question.IsCorrect).ToList();

                        if (incorrectQuestions.Count > 0)
                        {
                            Session.Quiz.CurrentQuestionIndex = quiz.CurrentDifficulty.IndexOf(incorrectQuestions[rnd.Next(0, incorrectQuestions.Count) - 1]);
                        }
                        else
                        {
                            return;
                        }

                        PlayVoiceline();

                        ChargeLevel = 0;
                        TimesUsed++;
                    }

                    break;
                case 7:
                    if (ChargeLevel == ChargesRequired)
                    {
                        Duration = 1;

                        PlayVoiceline();

                        quiz.ScoreMultiplier = 2;

                        ChargeLevel = 0;
                        TimesUsed++;
                    }

                    break;
                case 8:
                    if (ChargeLevel == ChargesRequired)
                    {
                        PlayVoiceline();

                        question.IsCorrect = true;
                        question.IsAnswered = true;

                        ChargeLevel = 0;
                        TimesUsed++;
                    }

                    break;
                case 9:
                    if (ChargeLevel == ChargesRequired)
                    {
                        PlayVoiceline();

                        ChargeLevel = 0;
                        TimesUsed++;
                    }

                    break;
            }
        }

        public void Reset()
        {
            this.ChargeLevel = this.ChargesRequired;
            this.TimesUsed = 0;
        }

        private void PlayVoiceline()
        {
            WindowsMediaPlayer wmp = new();

            Random rng = new Random();

            string voDirectory = @$"Sounds\Classes\{Session.Player.TFClass.Id}";

            string[] sounds = Directory.GetFiles(voDirectory);

            int soundToPlay = 0;

            if (sounds != null && sounds.Length > 1)
            {
                soundToPlay = rng.Next(1, sounds.Length);
            }

            if (sounds != null)
            {
                wmp.URL = sounds[soundToPlay];

                wmp.controls.play();

                if (sounds.Contains(@$"{voDirectory}\auxillary.wav"))
                {
                    SoundPlayer player = new();
                    player.SoundLocation = sounds[0];
                    player.Play();
                }
            }
        }

        #endregion
    }
}
