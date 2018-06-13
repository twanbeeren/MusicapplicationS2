using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    interface IPlaylistContext
    {
        List<Playlist> GetAllPlaylists();
    }
}
