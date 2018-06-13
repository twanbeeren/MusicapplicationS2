using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class UsernameOrPasswordIncorrectException : Exception
    {
        public UsernameOrPasswordIncorrectException(string message) : base(message)
        {

        }
    }
}
