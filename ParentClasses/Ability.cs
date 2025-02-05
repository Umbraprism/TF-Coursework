using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Ability
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public uint? ChargesRequired { get; set; }

        private string name;
        private string info;
        private int chargeLevel;


        public Ability(string Name, string Info)
        {
            this.Name = Name;
            this.Info = Info;
        }

        public virtual void UseAbility(Quiz quiz)
        {
            switch (FormHelper.s_quizPlayer.TFClass.Id)
            {
                case 1:
                    chargeLevel = 0;
                    throw new NotImplementedException();
                    // skip question - 3 charge
                case 2:
                    chargeLevel = 0;
                    throw new NotImplementedException();
                    // double points for three qus - 4 charge
                case 3:
                    chargeLevel = 0;
                    throw new NotImplementedException();
                    // if previous qu correct triple points - 3 charge
                case 4:
                    throw new NotImplementedException();
                    // plus 25% more points per question right but gone if answer wrong - passive
                case 5:
                    chargeLevel = 0;
                    throw new NotImplementedException();
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
                    quiz.currentDifficulty = quiz.easyQuizForms;
                    quiz.isDisguised = true;
                    break;
                    // 'disguise' to blu until question wrong - once
            }
        }
    }
}
