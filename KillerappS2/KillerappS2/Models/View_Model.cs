using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Logic;

namespace KillerappS2.Models
{
    public class View_Model
    {
        private static Account_Logic account_Logic = new Account_Logic();
        private static Song_Logic songlogic = new Song_Logic();
        private static Playlist_Logic playlistlogic = new Playlist_Logic();
        private List<Account> accounts = new List<Account>();
        private List<Account> friends = new List<Account>();
        private List<Account> friendrequests = new List<Account>();
        private List<Song> songs = new List<Song>();
        private List<Playlist> playlists = new List<Playlist>();
        private Account account = new Account();
        private Song song = new Song();
        private Playlist playlist = new Playlist();
        private int NumberOfFriends;

        public List<Account> Accounts { get => accounts; set => accounts = value; }
        public List<Account> Friends { get => friends; set => friends = value; }
        public List<Account> FriendRequests { get => friendrequests; set => friendrequests = value; }
        public List<Song> Songs { get => songs; set => songs = value; }
        public List<Playlist> Playlists { get => playlists; set => playlists = value; }
        public Account Account { get => account; set => account = value; }
        public Song Song { get => song; set => song = value; }
        public Playlist Playlist { get => playlist; set => playlist = value; }
        public int NumberOfFriends1 { get => NumberOfFriends; set => NumberOfFriends = value; }

        public void GetAccountsDatabase(string searchterm)
        {
            foreach (Account acc in account_Logic.GetAccountsBySearch(searchterm))
            {
                Accounts.Add(acc);
            }
        }

        public void GetSongsDatabase(Song song)
        {
            foreach (Song newsong in songlogic.GetAllSongsDatabase(song))
            {
                Songs.Add(newsong);
            }
        }

        public void GetFriendsDatabase()
        {
            foreach(Account acc in account_Logic.GetAllFriendsDatabase(account))
            {
                Friends.Add(acc);
            }
        }

        public void GetFriendRequestsDatabase()
        {
            foreach (Account acc in account_Logic.GetAllFriendRequestsDatabase(account))
            {
                FriendRequests.Add(acc);
            }
        }

        public void GetPlaylistsDatabase()
        {
            foreach(Playlist playlist in playlistlogic.GetAllPlaylistsDatabase(account))
            {
                Playlists.Add(playlist);
            }
        }

        public void GetNumberOfFriends()
        {
            NumberOfFriends = account_Logic.NumberOfFriends(account);
        }

    }
}
