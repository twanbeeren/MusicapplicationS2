using Xunit;
using DAL;
using Models;
using Logic;

namespace UnitTesting
{
    public class UnitTests
    {
        Account_Logic accountLogic = new Account_Logic();
        Song_Logic songLogic = new Song_Logic();
        Playlist_Logic playlistlogic = new Playlist_Logic();
        private Account newaccount;
        private Song newsong;
        private Playlist newplaylist;
        private Rapport newrapport;
        private TestContext testContext = new TestContext();

        
        [Fact]
        private void CheckRegister()
        {
            //Hier een vraag over stellen bij feedback
            Assert.False(accountLogic.CheckRegisterData(new Account("Bert")));
            Assert.False(accountLogic.CheckRegisterData(new Account("Bert", "12346846")));
            Assert.True(accountLogic.CheckRegisterData(new Account(1, "Bert", "12346846", "bert@gmail.com")));
        }

        
        [Fact]
        private void CheckRegisterGroftaalgebruik()
        {
            Assert.False(accountLogic.CheckRegisterName(new Account("fuck")));
            Assert.True(accountLogic.CheckRegisterName(new Account("Bert")));
        }

        [Fact]
        private void CheckRegisterPasswordLength()
        {
            Account_Logic accountLogic = new Account_Logic();
            Assert.False(accountLogic.CheckRegisterPassword(new Account(1, "Bert", "12345", "bert@ernie.com")));
            Assert.True(accountLogic.CheckRegisterPassword(new Account(2, "Bert", "123456", "bert@ernie.com")));
        }


        [Fact]
        public void CheckLog_in()
        {
            // Arrange
            Account account = new Account(1, "Bert", "123456", "bert@ernie.com");
            Assert.False(accountLogic.Log_in(account.Name, account.Password));

            // Act
            Assert.True(accountLogic.CheckRegisterData(account));
            Assert.True(accountLogic.CheckRegisterName(account));
            Assert.True(accountLogic.CheckRegisterPassword(account));

            // Assert
            Assert.True(accountLogic.Log_in(account.Name, account.Password));
        }

        [Fact]
        public void CheckSearchSong()
        {
            Assert.False(songLogic.SearchSong(new Song("Summer")));
            Assert.True(songLogic.SearchSong(new Song("Never gone give you up")));
        }

        [Fact]
        public void CheckPlaylistAdd()
        {
            //Arrange
            Account account = new Account(1, "Bert", "123456", "bert@ernie.com");
            Assert.True(playlistlogic.CheckMakeNewPlaylist(account , new Playlist("NewPlaylist")));

            //Act
            Assert.False(playlistlogic.CheckMakeNewPlaylist(account , new Playlist("NewPlaylist")));

        }

        [Fact]
        public void CheckSongAddToPlaylist()
        {
            Assert.True(playlistlogic.CheckAddNewSongToPlaylist(new Song(1, "RandomSong")));
        }
        
    }
}
