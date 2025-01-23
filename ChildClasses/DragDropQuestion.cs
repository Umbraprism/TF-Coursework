using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.ParentClasses;

namespace Coursework.ChildClasses
{
    internal class DragDropQuestion : Question
    {
        public string[] answers = new string[4];
        
        public DragDropQuestion() { }

        public DragDropQuestion(string[] answers, string questionText, string type, uint imageId) : base(questionText, type, imageId)
        {
            this.answers = answers;
        }
    }
}
