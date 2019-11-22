using System;

namespace _07.CustomException
{
    public class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException(string message)
            : base(message)
        {

        }
    }
}
