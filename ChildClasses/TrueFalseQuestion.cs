using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.ParentClasses;

namespace Coursework.ChildClasses
{
    internal class TrueFalseQuestion : Question
    {
        public string[] answers = { "True", "False" };

        public TrueFalseQuestion() { }

        public TrueFalseQuestion(string questionText, string type, uint imageId) : base(questionText, type, imageId)
        {
        }
    }
}
