using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    class PlaylistContext : IPlaylistContext
    {

        private List<Song> songs;
        private Playlist playlist;

        private List<Playlist> MakePlaylist()
        {
            List<Playlist> playlists = new List<Playlist>();
            songs = new List<Song>();
            songs.Add(new Song(new Artist("Tobu"), "Roots", 1283464));
            songs.Add(new Song(new Artist("Summer was fun"), "Run To You", 321263));
            songs.Add(new Song(new Artist("Nigel Good"), "Space Plus One", 426021));
            playlist = new Playlist("Firstplaylist", eColor.Blue, songs);
            playlists.Add(playlist);
            playlist = new Playlist("Secondplaylist", eColor.Red, songs);
            playlists.Add(playlist);
            return playlists;
        }

        public List<Playlist> GetAllPlaylists()
        {
            return MakePlaylist();
        }
    }
}
