using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Artist : Account
    {
        private bool verification;
        
        public Artist(string name)
        {
            this.Name = name;
        }
        
    }
}
