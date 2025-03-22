namespace Coursework.Exceptions
{
    public class InvalidPasswordException : Exception
    {
        #region Field declarations
        private static readonly new string Message = "The password entered is not strong enough. Please ensure that your password/n/nIs at least 8 characters long./nIncludes at least one capital letter./nIncludes at least one lowercase letter/nIncludes at least one number./nIncludes at least one special character, such as '*, #, £'".Replace("/n", Environment.NewLine);
        #endregion

        #region Constructor
        public InvalidPasswordException() : base(Message)
        {
        }
        public InvalidPasswordException(string message) : base(message)
        {
        }
        #endregion
    }
}
