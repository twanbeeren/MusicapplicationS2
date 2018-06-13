using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Rapport
    {
        private Account owner;
        private Account reported;
        private eDetail detail;

        public Account Owner { get => owner; set => owner = value; }
        public Account Reported { get => reported; set => reported = value; }
        private eDetail Detail1 { get => detail; set => detail = value; }

        

        public Rapport(Account owner, Account reported, eDetail detail)
        {
            this.owner = owner;
            this.reported = reported;
            this.detail = detail;
        }
    }
}
