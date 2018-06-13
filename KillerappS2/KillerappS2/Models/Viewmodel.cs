using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Models;

namespace KillerappS2.Models
{
    public class Viewmodel
    {
        private static List<Song> songs = new List<Song>();
        private static List<Account> friends = new List<Account>();
        private Account account = new Account();
        private Account_Logic account_Logic = new Account_Logic();
        private Song_Logic songlogic = new Song_Logic();
        private Playlist_Logic playlistlogic = new Playlist_Logic();

        public List<Song> Songs { get => songs; set => songs = value; }
        public Account Account { get => account; set => account = value; }

        public List<Song> GetSongs()
        {
            return songlogic.GetAllSongs();
        }

        public void GetSongsDatabase(Song song)
        {
            foreach(Song newsong in songlogic.GetAllSongsDatabase(song))
            {
                Songs.Add(newsong);
            }
        }

        public List<Playlist> GetPlaylists()
        {
            return playlistlogic.GetAllPlaylists();
        }

        public List<Account> GetFriendsDatabase(Account account)
        {
            return account_Logic.GetAllFriendsDatabase(account);
        }

        public List<Playlist> GetAllPlaylistsDatabase(Account account)
        {
            return playlistlogic.GetAllPlaylistsDatabase(account);
        }

        public List<Account> GetAccountsBySearch(string searchterm)
        {
            return account_Logic.GetAccountsBySearch(searchterm);
        }

        public Song NewSong()
        {
            Song song = new Song();
            return song;
        }
    }
}
