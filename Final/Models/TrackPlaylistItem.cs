using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class TrackPlaylistItem
    {
        public int Id { get; set; }

        public string AppUserId { get; set; }
        public int AlbumTrackId { get; set; }
        public int Count { get; set; }
        public DateTime CreatedAt { get; set; }

        public AppUser AppUser { get; set; }
        public AlbumTrack AlbumTrack { get; set; }
    }
}
