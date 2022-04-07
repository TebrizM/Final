using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class MyPlaylistViewModel
    {
        public List<Album> Albums { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Singer> Singers { get; set; }
        public List<AlbumTrack> AlbumTracks { get; set; }
    }
}
