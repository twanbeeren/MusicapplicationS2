using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public class TestContext
    {
        private List<Account> accountslist = new List<Account>();
        private List<Song> songslist = new List<Song>();
        private List<Playlist> playlists = new List<Playlist>();
        private List<Rapport> rapports = new List<Rapport>();

        public List<Account> Accountslist { get => accountslist; set => accountslist = value; }
        public List<Song> Songslist { get => songslist; set => songslist = value; }
        public List<Playlist> Playlists { get => playlists; set => playlists = value; }
        public List<Rapport> Rapports { get => rapports; set => rapports = value; }

        public void AddAccountsToList()
        {
            Accountslist.Add(new Account(1, "Twan", "twanbeeren","twanbeeren@home.nl"));
            Accountslist.Add(new Account(2, "Bert", "bert", "bertboon@gmail.com"));
            Accountslist.Add(new Account(3, "Tom", "tommie7", "tommie@hotmail.com"));
            
        }

        public void AddSongsToList()
        {
            Songslist.Add(new Song(new Artist("Tobu"), "Roots", 1283464));
            Songslist.Add(new Song(new Artist("Summer was fun"), "Run To You", 321263));
            Songslist.Add(new Song(new Artist("Nigel Good"), "Space Plus One", 426021));
        }

        public List<Playlist> AddPlaylistsToList()
        {
            Playlists.Add(new Playlist("firstplaylist", eColor.Green));
            Playlists.Add(new Playlist("secondplaylist", eColor.Blue));
            Playlists.Add(new Playlist("thirdplaylist", eColor.Red));
            return playlists;
        }

        public void AddRapportsToList()
        {
            Rapports.Add(new Rapport(new Account(3), new Account(4), eDetail.Hacking));
            Rapports.Add(new Rapport(new Account(53), new Account(3569), eDetail.Inappropriate_picture));
            Rapports.Add(new Rapport(new Account(14265), new Account(530), eDetail.Hacking));
        }

        public List<string> Taalgebruiklijst()
        {
            List<string> groftaalgebruik = new List<string>();
            groftaalgebruik.Add("fuck");
            groftaalgebruik.Add("kut");
            groftaalgebruik.Add("godverdomme");
            groftaalgebruik.Add("homeopatische genotsflikker");
            return groftaalgebruik;
        }

        public Account NewAccount()
        {
            Account account = new Account(1, "Twan", "twanbeeren", "twanbeeren@gmail.com");
            return account;
        }

        public Song NewSong()
        {
            Song song = new Song(new Artist("K-391"), "Ignite", 3216718);
            return song;
        }

        public Playlist NewPlaylist()
        {
            Playlist playlist = new Playlist("fourthplaylist", eColor.Red, songslist);
            return playlist;
        }

        public Rapport NewRapport()
        {
            Rapport rapport = new Rapport(new Account(1), new Account(2), eDetail.Inappropriate_picture);
            return rapport;
        }
        

    }
}
