using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.ChildClasses;

namespace Coursework.Classes
{
    internal class Question
    {
        public Dictionary<int, Bitmap?> idToPhoto = new()
        {
            {0, null},
            {1, Properties.Resources.soldierEmblem}
        };

        public string QuestionText { get; set; }
        public string Type { get; set; }
        public List<String> Answers { get; set; }
        public uint ImageId { get; set; } 
    }
}
