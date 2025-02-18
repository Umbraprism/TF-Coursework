namespace Coursework.Exceptions
{
    public class InvalidUsernameException : Exception
    {
        private static readonly new string Message = "The font used does not exist. Please use either the Build or Secondary font.";

        public InvalidUsernameException() : base(Message)
        {
        }
        public InvalidUsernameException(string message) : base(message)
        {
        }
    }
}
