using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Exceptions
{
    public class FontNotFoundException : Exception
    {
        private static readonly new string Message = "The font used does not exist. Please use either the Build or Secondary font.";

        public FontNotFoundException() : base(Message)
        {
        }
        public FontNotFoundException(string message) : base(message)
        {
        }
    }
}
