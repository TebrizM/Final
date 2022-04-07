using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class AlbumDetailViewModel
    {
        public Album Albums { get; set; }
        public List<AlbumTrack> Tracks { get; set; }
    }
}
