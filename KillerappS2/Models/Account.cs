using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Account
    {
        private int account_id;
        private List<Account> friends = new List<Account>();
        private string name;
        private string password;
        private string email;
        private eLanguage language;

        public int Account_Id { get => account_id; set => account_id = value; }
        public List<Account> Friends { get => friends; set => friends = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        

        public Account()
        {

        }

        public Account(int id)
        {
            this.account_id = id;
        }
        public Account(int id, string name)
        {
            this.account_id = id;
        }

        public Account(string name)
        {
            this.name = name;
        }
        
        public Account(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public Account(int id, string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }

        

    }
}
