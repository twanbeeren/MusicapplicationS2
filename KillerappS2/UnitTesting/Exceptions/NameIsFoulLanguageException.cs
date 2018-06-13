using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class NameIsFoulLanguageException : Exception
    {
        public NameIsFoulLanguageException(string message) : base(message)
        {

        }
    }
}
