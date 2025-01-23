using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.Helpers;

namespace Coursework.ParentClasses
{
    [Serializable]
    public class Ability
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public virtual void UseAbility()
        {
            switch (FormHelper.s_quizPlayer.TFClass.Id)
            {
                case 1:
                    throw new NotImplementedException();
                case 2:
                    throw new NotImplementedException();
                case 3:
                    throw new NotImplementedException();
                case 4:
                    throw new NotImplementedException();
                case 5:
                    throw new NotImplementedException();
                case 6:
                    throw new NotImplementedException();
                case 7:
                    throw new NotImplementedException();
                case 8:
                    throw new NotImplementedException();
                case 9:
                    throw new NotImplementedException();
            }
        }

        public Ability(string Name, string Info)
        {
            this.Name = Name;
            this.Info = Info;
        }
    }
}
