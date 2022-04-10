using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Album> Albums { get; set; }
 
        public List<AlbumTrack> AlbumTracks { get; set; }
        public List<Tours> Tours { get; set; }
        public Dictionary<string, string> Settings { get; set; }
    }
}
