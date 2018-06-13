using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class EmailAlreadyExcistsException : Exception
    {
        public EmailAlreadyExcistsException(string message) : base(message)
        {

        }
    }
}
