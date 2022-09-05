using System;

namespace DdosUsingGoogleSheets
{
    public class LimitException : Exception
    {
        public LimitException(string message) : base(message)
        {
        }
    }
}
