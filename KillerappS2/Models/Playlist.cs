using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Playlist
    {
        private int playlist_id;
        private string name;
        private eColor color;
        private List<Song> songs;

        public int Playlist_id { get => playlist_id; set => playlist_id = value; }
        public string Name { get => name; set => name = value; }
        public List<Song> Songs { get => songs; set => songs = value; }
        public eColor Color { get => color; set => color = value; }

        
        public Playlist()
        {

        }

        public Playlist(string name)
        {
            this.name = name;
        }

        public Playlist(string name, eColor color)
        {
            this.Name = name;
            this.color = color;
        }

        public Playlist(string name, eColor color, List<Song> songs)
        {
            this.Name = name;
            this.Color = color;
            this.Songs = songs;
        }
    }
}
