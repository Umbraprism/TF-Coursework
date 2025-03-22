namespace Coursework.Exceptions
{
    public class InvalidUsernameException : Exception
    {
        #region Field declarations
        private static readonly new string Message = "The username entered is invalid. Please ensure that your username/n/nIs at least 3 characters long./nDoes not contain any spaces.".Replace("/n", Environment.NewLine);
        #endregion

        #region Constructor
        public InvalidUsernameException() : base(Message)
        {
        }
        public InvalidUsernameException(string message) : base(message)
        {
        }
        #endregion
    }
}
