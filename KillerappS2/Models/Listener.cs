using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Listener: Account
    {
        private bool privé;

        public bool Privé { get => privé; set => privé = value; }
    }
}
