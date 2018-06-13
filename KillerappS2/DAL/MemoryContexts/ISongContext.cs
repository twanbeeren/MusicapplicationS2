using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    interface ISongContext
    {
        List<Song> GetAllSongs();
        List<Song> SearchSongList();
    }
}
