using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class AlbumViewModel
    {
        public List<Album> Albums { get; set; }
        public List<AlbumTrack> AlbumTracks { get; set; }
    }
}
