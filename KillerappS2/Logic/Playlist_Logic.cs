using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;

namespace Logic
{
    public class Playlist_Logic
    {
        TestContext testContext = new TestContext();
        Repository repo = new Repository();

        public List<Playlist> GetAllPlaylists()
        {
            return repo.GetAllPlaylists();
        }

        public List<Playlist> GetAllPlaylistsDatabase(Account account)
        {
            return repo.GetAllPlaylistsDatabase(account);
        }

        public bool CheckMakeNewPlaylist(Account acc, Playlist playlist)
        {
            if (!repo.GetAllPlaylistsDatabase(acc).Contains(playlist))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckAddNewSongToPlaylist(Account acc, Song song)
        {
            
        }
    }
}
