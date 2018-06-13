using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Song
    {
        private int song_id;
        private List<Artist> artists = new List<Artist>();
        private string title;
        private DateTime released;
        private int total_streams;
        private eGenre genre;

        public int Song_id { get => song_id; set => song_id = value; }
        public IEnumerable<Artist> Artists { get => artists; }
        public string Title { get => title; set => title = value; }
        public DateTime Released { get => released; set => released = value; }
        public int Total_streams { get => total_streams; set => total_streams = value; }
        public eGenre Genre { get => genre; set => genre = value; }

        public Song()
        {

        }
        public Song(int id, string title)
        {
            this.song_id = id;
            this.title = title;
        }

        public Song(string title)
        {
            this.title = title;
        }

        public Song(string title , int streams)
        {
            this.title = title;
            this.total_streams = streams;
        }

        public Song(Artist artist, string title, int streams)
            : this(new List<Artist>() { artist }, title, streams)
        {
        }

        public Song(List<Artist> artists, string title, int streams)
        {
            this.artists = artists;
            this.Title = title;
            this.Total_streams = streams;
        }

        public void AddArtist(Artist artist)
        {
            artists.Add(artist);
        }
    }
}
