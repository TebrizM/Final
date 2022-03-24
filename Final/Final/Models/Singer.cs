using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Album> Albums { get; set; }
    }
}
