using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class PasswordIsTooShortException : Exception
    {
        public PasswordIsTooShortException(string message) : base(message)
        {

        }
    }
}
