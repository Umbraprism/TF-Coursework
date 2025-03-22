namespace Coursework.Exceptions
{
    public class CursorNotFoundException : Exception
    {
        #region Field declarations
        private static readonly new string Message = "The cursor specified does not exist. Please use either the Default or TFClass cursor.";
        #endregion

        #region Constructor
        public CursorNotFoundException() : base(Message)
        {
        }
        public CursorNotFoundException(string message) : base(message)
        {
        }
        #endregion
    }
}
