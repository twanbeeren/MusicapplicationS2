using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Models;

namespace Logic
{
    public class Account_Logic
    {
        Repository repo = new Repository();

        public bool Log_in(string name, string password)
        {
            return repo.Login(name, password);
        }

        public bool Register(Account account)
        {
            if(CheckRegisterData(account) && CheckRegisterName(account) && CheckRegisterPassword(account))
            {
                repo.Register(account);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckRegisterData(Account account)
        {
            if (account.Name == null || account.Password == null || account.Email == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public bool CheckRegisterPassword(Account account)
        {
            if (account.Password.Length < 6)
            {
                return false;
            }
            repo.Register(account);
            return true;
        }

        public bool CheckRegisterName(Account account)
        {
            if (repo.TaalgebruikLijst().Contains(account.Name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GetAccount_Id(Account account)
        {
            repo.GetAccount_Id(account);
        }

        public List<Account> GetAccountsBySearch(string searchterm)
        {
            return repo.GetAccountsBySearch(searchterm);
        }

        public List<Account> GetAllFriendsDatabase(Account account)
        {
            return repo.GetAllFriendsDatabase(account);
        }
        
        public List<Account> GetAllFriendRequestsDatabase(Account account)
        {
            return repo.GetAllFriendRequestsDatabase(account);
        }

        public void SendFriendRequest(Account user, Account account) => repo.InsertFriendRequest(user, account);
        
        public int NumberOfFriends(Account account)
        {
            return repo.NumberOfFriends(account);
        }

    }
}
