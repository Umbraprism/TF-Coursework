namespace Coursework.Exceptions
{
    public class CursorNotFoundException : Exception
    {
        private static readonly new string Message = "The cursor specified does not exist. Please use either the Default or TFClass cursor.";

        public CursorNotFoundException() : base(Message)
        {
        }
        public CursorNotFoundException(string message) : base(message)
        {
        }
    }
}
