namespace Coursework.Exceptions
{
    public class FontNotFoundException : Exception
    {
        #region Field declarations
        private static readonly new string Message = "The font used does not exist. Please use either the Build or Secondary font.";
        #endregion

        #region Constructor
        public FontNotFoundException() : base(Message)
        {
        }
        public FontNotFoundException(string message) : base(message)
        {
        }
        #endregion
    }
}
